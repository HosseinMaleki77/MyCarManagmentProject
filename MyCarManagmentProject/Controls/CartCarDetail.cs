using MyCarManagmentProject.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCarManagmentProject.Controls
{
    public partial class CartCarDetail : UserControl
    {


        // سازنده پیش‌فرض (ضروری برای Designer)
        public CartCarDetail()
        {
            InitializeComponent();
        }

        public Cars SelectedCar { get; set; }

        // متد برای ست کردن نقش


        public void SetDesigner()
        {
            if (SelectedCar == null) return;

            lblName.Text = SelectedCar.Name;
            lblMaxPower.Text = SelectedCar.MaxPower;
            lblAcceleration.Text = SelectedCar.Acceleration;
            lblTransmission.Text = SelectedCar.Transmission;
            lblDoors.Text = SelectedCar.DoorCount;
            lblEngineDetails.Text = SelectedCar.Engine_Details;
            lblPrice.Text = SelectedCar.Price.ToString();
            lblFuel.Text = SelectedCar.Fuel;
            lblTopSpeed.Text = SelectedCar.TopSpeed;
            lblMaxTorque.Text = SelectedCar.MaxTorque;
            pictureBox1.Image = SelectedCar.CarImage;
            nmCarCount.Value = (int)SelectedCar.CarCount;
        }

        private void UpdateCount()
        {
            int carCount = (int)nmCarCount.Value;
            string connectionString = "Data Source=.;Initial Catalog=CarShop;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE CarInfo SET COUNT=@Count WHERE ID=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Count", carCount);
                cmd.Parameters.AddWithValue("@Id", SelectedCar.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateCount();
                MessageBox.Show("Save Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

            Person p = CurrentUser.User;

            if (p != null)
            {
                DialogResult result = MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (p.WalletBalance >= SelectedCar.Price)
                    {

                        p.WalletBalance =p.WalletBalance - SelectedCar.Price;
                        UpdateWalletBalance(p);
                        DeleteCarFromDataBase();
                        p.MyCars.Add(SelectedCar);
                        AddMyCarToDataBase(p);
                        MessageBox.Show("Your Purchase Has Been Completed Successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        nmCarCount.Refresh();
                    }

                    else
                    {
                        MessageBox.Show("Your Money Isn't Enough!Please Charge Your Wallet.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }



                }


            }
        }

        private void DeleteCarFromDataBase()
        {
            int carCount = (int)nmCarCount.Value;
            string connectionString = "Data Source=.;Initial Catalog=CarShop;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE CarInfo SET COUNT=@Count WHERE ID=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Count", carCount - 1);
                cmd.Parameters.AddWithValue("@Id", SelectedCar.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void AddMyCarToDataBase(Person p)
        {
            string connectionString = "Data Source=.;Initial Catalog=CarShop;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1) بررسی اینکه آیا مشتری این ماشین را دارد یا نه
                string checkQuery = "SELECT CarCount FROM MyCars WHERE CustomerId=@CustomerId AND CarName=@CarName";

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@CustomerId", p.Id);
                    checkCmd.Parameters.AddWithValue("@CarName", SelectedCar.Name);

                    object result = checkCmd.ExecuteScalar();

                    if (result != null)  // یعنی ماشین پیدا شد
                    {
                        int currentCount = Convert.ToInt32(result);

                        // 2) آپدیت تعداد
                        string updateQuery = "UPDATE MyCars SET CarCount = @CarCount WHERE CustomerId=@CustomerId AND CarName=@CarName";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@CarCount", currentCount + 1);
                            updateCmd.Parameters.AddWithValue("@CustomerId", p.Id);
                            updateCmd.Parameters.AddWithValue("@CarName", SelectedCar.Name);


                            updateCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // 3) اضافه کردن رکورد جدید
                        string insertQuery = "INSERT INTO MyCars (CarName, CarCount, CustomerId, isRented) VALUES (@CarName, 1, @CustomerId,0)";
                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@CustomerId", p.Id);
                            insertCmd.Parameters.AddWithValue("@CarName", SelectedCar.Name);

                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }

                conn.Close();
            }
        }
        private void UpdateWalletBalance(Person p)
        {

            int carCount = (int)nmCarCount.Value;
            string connectionString = "Data Source=.;Initial Catalog=CarShop;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE USERS SET WalletBalance=@WalletBalance WHERE ID=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@WalletBalance", p.WalletBalance);
                cmd.Parameters.AddWithValue("@Id", p.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void CartCarDetail_Load(object sender, EventArgs e)
        {
            if (CurrentUser.User != null && CurrentUser.User.IsAdmin == false)
            {
                btnSave.Visible = false;
                nmCarCount.Visible = false;
            }
        }
    }
}


