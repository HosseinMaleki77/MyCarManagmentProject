using MyCarManagmentProject.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCarManagmentProject.Controls
{

    public partial class CartCarDetail : UserControl
    {
        


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
            if (SelectedCar.CarCount >= 0)
            {
                nmCarCount.Value = (int)SelectedCar.CarCount;

            }
            else
            {
                nmCarCount.Value = 0;

            }
        }

        private void UpdateCount()
        {
            int carCount = (int)nmCarCount.Value;

            if ((int)nmCarCount.Value == 0)
            {
                carCount = 0;
            }
            else
            {
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
                if (SelectedCar.CarCount >= 0)
                {
                    if (result == DialogResult.Yes)
                    {
                        if (p.WalletBalance >= SelectedCar.Price)
                        {

                            p.WalletBalance = p.WalletBalance - SelectedCar.Price;
                            UpdateWalletBalance(p);
                            //AddMoneyToAdmin(SelectedCar.Price);

                            DeleteCarFromDataBase();
                            p.MyCars.Add(SelectedCar);
                            AddMyCarToTX(p);
                            MessageBox.Show("Your request To Purchase This Car Has Been Sent TO Admins.\n Wait For Admin Approval. !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            nmCarCount.Value = SelectedCar.CarCount;
                        }
                        else
                        {
                            MessageBox.Show("Your Money Isn't Enough!Please Charge Your Wallet.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
               
                }
                else
                {
                    MessageBox.Show("The Car Isn't Available!.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }

        private void DeleteCarFromDataBase()
        {
            string connectionString = "Data Source=.;Initial Catalog=CarShop;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE CarInfo SET COUNT=@Count WHERE ID=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);

                // از مقدار واقعی ماشین استفاده می‌کنیم
                int newCount = SelectedCar.CarCount - 1;
                cmd.Parameters.AddWithValue("@Count", newCount);
                cmd.Parameters.AddWithValue("@Id", SelectedCar.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            // مقدار موجودی کاربر را هم بروز کنیم
            SelectedCar.CarCount -= 1;
        }


        private void AddMyCarToTX(Person p)
        {
            string connectionString = "Data Source=.;Initial Catalog=CarShop;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string checkQuery = "SELECT Id FROM TX WHERE CustomerId=@CustomerId AND CarId=@CARID";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@CustomerId", p.Id);
                    checkCmd.Parameters.AddWithValue("@CARID", SelectedCar.Id);

                    object result = checkCmd.ExecuteScalar();

                        // 3) اضافه کردن رکورد جدید
                        string insertQuery = "INSERT INTO TX (CustomerId, isRented,CarId,Price,IsDone) VALUES (@CustomerId,0,@CARID,@Price,0)";
                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@CustomerId", p.Id);
                            insertCmd.Parameters.AddWithValue("@CARID", SelectedCar.Id);
                            insertCmd.Parameters.AddWithValue("@Price", SelectedCar.Price);

                            insertCmd.ExecuteNonQuery();
                        }
                   
                    conn.Close();
                }
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
            //LoadCarsFromDatabase();

            lblSoldOut.Visible=false;

            if (CurrentUser.User != null && CurrentUser.User.IsAdmin == false)
            {
                btnSave.Visible = false;
                nmCarCount.Visible = false;

            }
            if (nmCarCount.Value==0)
            {
                btnBuy.Visible = false;
                btnRent.Visible= false;
                lblSoldOut.Visible = true;
            }
        }


        private void AddMoneyToAdmin(decimal amount)
        {
            string connectionString = "Data Source=.;Initial Catalog=CarShop;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // پیدا کردن ادمین
                string selectQuery = "SELECT WalletBalance FROM USERS WHERE IsAdmin=1";
                SqlCommand selectCmd = new SqlCommand(selectQuery, conn);
                object result = selectCmd.ExecuteScalar();

                if (result != null)
                {
                    decimal adminBalance = Convert.ToDecimal(result);
                    adminBalance += amount;

                    string updateQuery = "UPDATE USERS SET WalletBalance=@WalletBalance WHERE IsAdmin=1";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@WalletBalance", adminBalance);

                    updateCmd.ExecuteNonQuery();
                }
            }
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            Person p = CurrentUser.User;

            if (p != null)
            {
                if (SelectedCar.CarCount >= 0)
                {
                    decimal payAmount = SelectedCar.Price * 0.1m;
                    {
                        DialogResult result = MessageBox.Show($"Price of Car: {SelectedCar.Price:N0}\n" + $"You will pay 10%: {payAmount:N0}\n\n" + "Do you want to continue?", "Confirm Purchase", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {

                            if (p.WalletBalance >= payAmount)
                            {



                                //p.WalletBalance -= payAmount;

                                //UpdateWalletBalance(p);
                                //AddMoneyToAdmin(payAmount);
                                //DeleteCarFromDataBase();
                                UpdateCount();
                                p.MyCars.Add(SelectedCar);
                                AddMyCarToTX(p);
                                MessageBox.Show("Your request To Rent This Car Has Been Sent TO Admins.\n Wait For Admin Approval. !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                nmCarCount.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("Your Money Isn't Enough!Please Charge Your Wallet.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("The Car Isn't Available!.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }

       
    }
    
}



