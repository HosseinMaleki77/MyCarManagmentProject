using MyCarManagmentProject.Forms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MyCarManagmentProject.Controls
{
    
    public partial class UC_MyCars : UserControl
    { 
      


        //برای نشان دادن یا ندادن دکمه ها نوشتیم
        private bool _showSellButton = true;
        public bool ShowSellButton
        {
            get => _showSellButton;
            set
            {
                _showSellButton = value;
                btnSell.Visible = _showSellButton; // کنترل نمایش دکمه
            }
        }
        private bool _showNumUpDw = true;
        public bool ShowNumUpDw
        {
            get => _showNumUpDw;
            set
            {
                _showNumUpDw = value;
                nmSellCount.Visible = _showNumUpDw; // کنترل نمایش دکمه
            }
        }


        private bool _showCancelBtn = true;
        public bool ShowCancelBtn
        {
            get => _showCancelBtn;
            set
            {
                _showCancelBtn = value;
                btnCancel.Visible = _showCancelBtn; // کنترل نمایش دکمه
            }
        }

        private bool _showAcceptBtn = true;
        public bool ShowaAcceptBtn
        {
            get => _showAcceptBtn;
            set
            {
                _showAcceptBtn = value;
                btnAccept.Visible = _showAcceptBtn; // کنترل نمایش دکمه
            }
        }

        private bool _lblCustomer = true;
        public bool lblCus
        {
            get => _lblCustomer;
            set
            {
                _lblCustomer = value;
                lblCustomer.Visible = _lblCustomer; // کنترل نمایش دکمه
            }
        }
        private bool _showRejectButton = true;
        public bool ShowRejectButton
        {
            get => _showRejectButton;
            set
            {
                _showRejectButton = value;
                btnReject.Visible = _showRejectButton; // کنترل نمایش دکمه
            }
        }
        private bool _showUserDetailButton = true;
        public bool ShowUserDetailButton
        {
            get => _showSellButton;
            set
            {
                _showUserDetailButton = value;
                btnUserDetail.Visible = _showUserDetailButton; // کنترل نمایش دکمه
            }
        }



        public UC_MyCars()
        {
            InitializeComponent();
            btnSell.Visible = _showSellButton;
            nmSellCount.Visible= _showNumUpDw;
            btnCancel.Visible= _showCancelBtn;
            
        }

        public Cars SelectedCar { get; set; }
        public TX SelectedTx { get; set; }


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
            lblCount.Text = SelectedCar.CarCount.ToString();
            if (SelectedTx != null)
            {
                lblIsRented.Text = "Is Rented: " + SelectedTx.IsRented.ToString();
                lblCustomer.Text = "Customer ID: " + SelectedTx.CustomerId.ToString();
            }
            else
            {
                lblIsRented.Text = "Is Rented: -";
                lblCustomer.Text = "Customer ID: -";
            }



            //nmSellCount.Minimum = 1; // حداقل یک ماشین برای فروش
            //nmSellCount.Maximum = SelectedCar.CarCount; // حداکثر برابر تعداد موجود
            //nmSellCount.Value = 1;   // مقدار پیش‌فرض
        }

        private void UpdateCount()
        {
            string connectionString = "Data Source=.;Initial Catalog=CarShop;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE CarInfo SET COUNT=@Count WHERE ID=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", SelectedCar.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }






        private void AddCarToDataBase()
        {
            string connectionString = "Data Source=.;Initial Catalog=CarShop;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1. مقدار فعلی رو از دیتابیس بخون
                string selectQuery = "SELECT COUNT FROM CarInfo WHERE ID=@Id";
                SqlCommand selectCmd = new SqlCommand(selectQuery, conn);
                selectCmd.Parameters.AddWithValue("@Id", SelectedCar.Id);

                int currentCount = 0;
                object result = selectCmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    currentCount = Convert.ToInt32(result);
                }

                // 2. مقدار جدید رو محاسبه کن
                int newCount = currentCount + 1;

                // 3. مقدار جدید رو در دیتابیس ذخیره کن
                string updateQuery = "UPDATE CarInfo SET COUNT=@Count WHERE ID=@Id";
                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@Count", newCount);
                updateCmd.Parameters.AddWithValue("@Id", SelectedCar.Id);

                updateCmd.ExecuteNonQuery();
            }
        }


        private void DeleteCarFromDataBase(Person p)
        {
            string connectionString = "Data Source=.;Initial Catalog=CarShop;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1) بررسی اینکه آیا مشتری این ماشین را دارد یا نه
                string checkQuery = "SELECT CarCount FROM TX WHERE CustomerId=@CustomerId AND CarName=@CarName";

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@CustomerId", p.Id);
                    checkCmd.Parameters.AddWithValue("@CarName", SelectedCar.Name);

                    object result = checkCmd.ExecuteScalar();

                    if (result != null)  // یعنی ماشین پیدا شد
                    {
                        int currentCount = Convert.ToInt32(result);

                        if (currentCount > 1)
                        {
                            // 2) کم کردن یک عدد از تعداد
                            string updateQuery = "UPDATE MyCars SET CarCount = @CarCount WHERE CustomerId=@CustomerId AND CarName=@CarName";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@CarCount", currentCount - 1);
                                updateCmd.Parameters.AddWithValue("@CustomerId", p.Id);
                                updateCmd.Parameters.AddWithValue("@CarName", SelectedCar.Name);

                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // 3) اگه تعداد 1 بود، کل ردیف حذف بشه
                            string deleteQuery = "DELETE FROM MyCars WHERE CustomerId=@CustomerId AND CarName=@CarName";
                            using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                            {
                                deleteCmd.Parameters.AddWithValue("@CustomerId", p.Id);
                                deleteCmd.Parameters.AddWithValue("@CarName", SelectedCar.Name);

                                deleteCmd.ExecuteNonQuery();
                            }
                        }
                    }

                }

                conn.Close();
            }
        }

        private void UpdateWalletBalance(Person p)
        {

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

        private void UC_MyCars_Load(object sender, EventArgs e)
        {


        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            Person p = CurrentUser.User;
            p.AdminOrderAccept = false;
            if (p.AdminOrderAccept)
            {
                if (p != null)
                {
                    DialogResult result = MessageBox.Show("Are You Sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {


                        p.WalletBalance = p.WalletBalance + SelectedCar.Price;
                        UpdateWalletBalance(p);
                        DeleteCarFromDataBase(p);
                        AddCarToDataBase();
                        MessageBox.Show("Your Car Has Been Sell!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
            
              
                }
            }

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Person p = CurrentUser.User;

            if (p == null) return;

            DialogResult result = MessageBox.Show("Are You Sure to Cancel This Car?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            int customerId = SelectedTx.CustomerId;

            if (result == DialogResult.Yes)
            {
                DeleteCarFromMyOrders(p.Id);   // حذف یا کم کردن از TX
                MessageBox.Show("Car cancelled and money refunded!",
                    "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // رفرش فرم اصلی و FlowLayoutPanel
                MyOrders frm = (MyOrders)Application.OpenForms["MyOrders"];
                if (frm != null)
                    frm.LoadMyOrders(p.Id);
            }
        }


        private void DeleteCarFromMyOrders(int customerId)
        {
            string connectionString = "Data Source=.;Initial Catalog=CarShop;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // گرفتن تعداد و قیمت
                string checkQuery = "SELECT CarCount, Price FROM TX WHERE CustomerId=@CustomerId AND CarId=@CarId";

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@CustomerId", customerId);
                    checkCmd.Parameters.AddWithValue("@CarId", SelectedCar.Id);

                    using (SqlDataReader reader = checkCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int currentCount = Convert.ToInt32(reader["CarCount"]);
                            decimal carPrice = Convert.ToDecimal(reader["Price"]);
                            reader.Close();

                            if (currentCount > 1)
                            {
                                // کم کردن تعداد در TX
                                string updateQuery = "UPDATE TX SET CarCount = CarCount - 1 WHERE CustomerId=@CustomerId AND CarId=@CarId";
                                using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                                {
                                    updateCmd.Parameters.AddWithValue("@CustomerId", customerId);
                                    updateCmd.Parameters.AddWithValue("@CarId", SelectedCar.Id);
                                    updateCmd.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // حذف کامل
                                string deleteQuery = "DELETE FROM TX WHERE CustomerId=@CustomerId AND CarId=@CarId";
                                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                                {
                                    deleteCmd.Parameters.AddWithValue("@CustomerId", customerId);
                                    deleteCmd.Parameters.AddWithValue("@CarId", SelectedCar.Id);
                                    deleteCmd.ExecuteNonQuery();
                                }
                            }

                            // برگرداندن پول به کاربر
                            string updateUserBalance = "UPDATE Users SET WalletBalance = WalletBalance + @Refund WHERE Id=@UserId";
                            using (SqlCommand updateBalanceCmd = new SqlCommand(updateUserBalance, conn))
                            {
                                updateBalanceCmd.Parameters.AddWithValue("@Refund", carPrice);
                                updateBalanceCmd.Parameters.AddWithValue("@UserId", customerId);
                                updateBalanceCmd.ExecuteNonQuery();
                            }

                            // اضافه کردن به Count جدول CarInfo
                            string updateCarCount = "UPDATE CarInfo SET Count = Count + 1 WHERE ID=@Id";
                            using (SqlCommand updateCarCmd = new SqlCommand(updateCarCount, conn))
                            {
                                updateCarCmd.Parameters.AddWithValue("@Id", SelectedCar.Id);
                                updateCarCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                conn.Close();
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (SelectedCar == null || SelectedCar == null)
            {
                MessageBox.Show("No transaction info available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure to reject this car?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result != DialogResult.Yes) return;

            int customerId = SelectedTx.CustomerId;

            DeleteCarFromMyOrders(customerId);

            MessageBox.Show("Car cancelled and money refunded!",
                "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 🔹 پیدا کردن فرم و به‌روزرسانی فوری
            var frm = Application.OpenForms.OfType<MyCarManagmentProject.Forms.CustomersOrders>().FirstOrDefault();
            if (frm != null)
            {
                // رفرش بر اساس شناسه‌ی مشتری مربوطه
                frm.RefreshCars(customerId);
            }
        }
        private void btnUserDetail_Click(object sender, EventArgs e)
        {
            if (SelectedTx == null)
            {
                MessageBox.Show("No transaction info available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // استفاده از CustomerId موجود در SelectedTx
            UserDetails userDetails = new UserDetails(SelectedTx.CustomerId);
            userDetails.ShowDialog();
        }
    }
}

