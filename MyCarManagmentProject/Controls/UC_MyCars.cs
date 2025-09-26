using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MyCarManagmentProject.Controls
{
    public partial class UC_MyCars : UserControl
    {
        public UC_MyCars()
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
                string checkQuery = "SELECT CarCount FROM MyCars WHERE CustomerId=@CustomerId AND CarName=@CarName";

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

        }

        private List<Cars> LoadMyCarsFromDatabase(int customerId)
        {
            List<Cars> myCarsList = new List<Cars>();

            string connectionString = ConfigurationManager.ConnectionStrings["CarShop"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT c.ID, c.Name, c.MaximumPower, c.Acceleration, c.Transmission, 
                   c.DoorsNumber, c.EngineDetails, c.Price, c.Fuel, 
                   c.TopSpeed, c.MaximumTorque, c.Factory, c.IMAGEPATH,
                   m.CarCount
            FROM CarInfo c
            INNER JOIN MyCars m ON c.Name = m.CarName
            WHERE m.CustomerId = @CustomerId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customerId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string folderPath = @"C:\C# TESTS\CarManagementProject\MyCarManagmentProject\UserImages";
                            string imageName = reader["IMAGEPATH"].ToString();
                            string imagePath = Path.Combine(folderPath, imageName);

                            Image carImage = null;
                            if (File.Exists(imagePath))
                            {
                                using (var temp = Image.FromFile(imagePath))
                                {
                                    carImage = new Bitmap(temp);
                                }
                            }
                            else
                            {
                                carImage = Properties.Resources.no_image_icon_4;
                            }

                            Cars car = new Cars
                            {
                                Id = Convert.ToInt32(reader["ID"]),
                                Name = reader["Name"].ToString(),
                                MaxPower = reader["MaximumPower"].ToString(),
                                Acceleration = reader["Acceleration"].ToString(),
                                Transmission = reader["Transmission"].ToString(),
                                DoorCount = reader["DoorsNumber"].ToString(),
                                Engine_Details = reader["EngineDetails"].ToString(),
                                Price = Convert.ToInt32(reader["Price"]),
                                Fuel = reader["Fuel"].ToString(),
                                TopSpeed = reader["TopSpeed"].ToString(),
                                MaxTorque = reader["MaximumTorque"].ToString(),
                                CarCount = Convert.ToInt32(reader["CarCount"]), // از جدول MyCars
                                Model = (Cars.CarModel)reader["Factory"],
                                CarImage = carImage
                            };

                            myCarsList.Add(car);
                        }
                    }
                }
            }

            return myCarsList;
        }

    }
}
