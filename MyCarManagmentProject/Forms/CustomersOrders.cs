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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCarManagmentProject.Forms
{
    public partial class CustomersOrders : Form
    {
        public CustomersOrders()
        {
            InitializeComponent();
        }

        private void CustomersOrders_Load(object sender, EventArgs e)
        {
            Person user = CurrentUser.User;
            var cars = LoadMyCarsFromDatabase(user.Id);

            flpCars.Controls.Clear(); // خالی کردن قبل از پر کردن
            flpCars.FlowDirection = FlowDirection.LeftToRight;
            flpCars.WrapContents = true; // برای ردیف بعدی


            foreach (var car in cars)
            {
                UC_MyCars carControl = new UC_MyCars();
                carControl.ShowSellButton = false;
                carControl.ShowNumUpDw = false;
                carControl.ShowCancelBtn = false;
                carControl.ShowRejectButton = false;
                carControl.ShowUserDetailButton = false;
                this.Controls.Add(carControl);
                carControl.SelectedCar = car;
                carControl.SetDesigner();
                carControl.Margin = new Padding(20); // فاصله بین کنترل‌ها
                carControl.Width = 832; // اندازه مناسب بده
                carControl.Height = 188;

                flpCars.Controls.Add(carControl);
            }
        }
        private List<Cars> LoadMyCarsFromDatabase(int customerId)
        {
            List<Cars> myCarsList = new List<Cars>();

            string connectionString = ConfigurationManager.ConnectionStrings["CarShop"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT c.ID, c.Name, c.MaximumPower, c.Acceleration, c.Transmission,
       c.DoorCount, c.EngineDetails, c.Price, c.Fuel,
       c.TopSpeed, c.MaximumTorque, c.Factory, c.IMAGEPATH,
       m.CarCount, m.CustomerId, m.IsRented
        FROM CarInfo c
        INNER JOIN TX m ON c.Id = m.CarId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customerId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string folderPath = @"E:\test c#\MyCarManagmentProject\MyCarManagmentProject\UserImages";
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
                                DoorCount = reader["DoorCount"].ToString(),
                                Engine_Details = reader["EngineDetails"].ToString(),
                                Price = Convert.ToInt32(reader["Price"]),
                                Fuel = reader["Fuel"].ToString(),
                                TopSpeed = reader["TopSpeed"].ToString(),
                                MaxTorque = reader["MaximumTorque"].ToString(),
                                CarCount = Convert.ToInt32(reader["CarCount"]), // از جدول MyCars
                                Model = (Cars.CarModel)reader["Factory"],
                                CarImage = carImage
                            };

                            car.TxInfo = new TX
                            {
                                CustomerId = Convert.ToInt32(reader["CustomerId"]),
                                IsRented = (bool) reader["IsRented"],
                                CarId = car.Id
                            };


                            myCarsList.Add(car);
                        }
                    }
                }
            }

            return myCarsList;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshCars();
        }
        private void RefreshCars()
        {
            flpCars.Controls.Clear();
            Person user = CurrentUser.User;
            var cars = LoadMyCarsFromDatabase(user.Id);

            //var TXs = LoadTXFromDataBase();

            
            foreach (var car in cars)
            {
                UC_MyCars carControl = new UC_MyCars();
                carControl.SelectedCar = car;
                carControl.SetDesigner();
                carControl.Margin = new Padding(10);
                carControl.Width = 832;  // مطابق اندازه دیزاینر
                carControl.Height = 188;
                //foreach (var T in TXs)
                //{
                //    if (T.CarId==car.Id)
                //    {
                //        carControl.SelectedTx = T;
                //    }
                //}
                flpCars.Controls.Add(carControl);
                
            }
        }

        //private List<TX> LoadTXFromDataBase()
        //{
        //    List<TX> txList = new List<TX>();

        //    string connectionString = ConfigurationManager.ConnectionStrings["CarShop"].ConnectionString;

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();
        //        string query = @"SELECT CustomerId, IsRented, CarId FROM TX";

        //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //        {
        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    TX tx = new TX
        //                    {
        //                        CustomerId = Convert.ToInt32(reader["CustomerId"]),
        //                        IsRented = Convert.ToBoolean(reader["IsRented"]),
        //                        CarId = Convert.ToInt32(reader["CarId"])
        //                    };

        //                    txList.Add(tx);
        //                }
        //            }
        //        }
        //    }

        //    return txList;
        //}
    }
}

