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
    public partial class MyOrders : Form
    {
        public MyOrders()
        {
            InitializeComponent();
        }

        private void MyOrders_Load(object sender, EventArgs e)
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
                carControl.ShowaAcceptBtn=false;
                carControl.lblCus = false;
                carControl.ShowUserDetailButton = false;
                carControl.ShowRejectButton = false;
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

                string query = @"
        SELECT c.ID, c.Name, c.MaximumPower, c.Acceleration, c.Transmission, 
               c.DoorCount, c.EngineDetails, c.Price, c.Fuel, 
               c.TopSpeed, c.MaximumTorque, c.Factory, c.IMAGEPATH,
               m.IsRented,
               m.CarCount
        FROM CarInfo c
        INNER JOIN TX m ON c.Id = m.CarId
        WHERE m.CustomerId = @CustomerId";

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
                                CarCount = Convert.ToInt32(reader["CarCount"]),
                                Model = (Cars.CarModel)reader["Factory"],
                                CarImage = carImage
                            };
                            TX Person = new TX
                            {
                                IsRented = (bool)reader["IsRented"],
                                CarId = car.Id
                            };

                            myCarsList.Add(car);
                        }
                    }
                }
            }

            return myCarsList;
        }


        public void LoadMyOrders(int customerId)
        {
            flpCars.Controls.Clear(); // اول همه کارت‌ها رو پاک کن

            string connectionString = "Data Source=.;Initial Catalog=CarShop;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
        SELECT C.Id, C.Name, C.Price, C.Acceleration, C.Transmission, 
               C.DoorCount, C.EngineDetails, C.Fuel, C.TopSpeed, 
               C.MaximumPower, C.MaximumTorque, T.IsRented,C.ImagePath,
               T.CarCount
        FROM TX T
        JOIN CarInfo C ON T.CarId = C.Id
        WHERE T.CustomerId=@CustomerId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                SqlDataReader reader = cmd.ExecuteReader();
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
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Price = Convert.ToInt32(reader["Price"]),
                        Acceleration = reader["Acceleration"].ToString(),
                        Transmission = reader["Transmission"].ToString(),
                        DoorCount = reader["DoorCount"].ToString(),
                        Engine_Details = reader["EngineDetails"].ToString(),
                        Fuel = reader["Fuel"].ToString(),
                        TopSpeed = reader["TopSpeed"].ToString(),
                        MaxPower = reader["MaximumPower"].ToString(),
                        MaxTorque = reader["MaximumTorque"].ToString(),
                        CarCount = Convert.ToInt32(reader["CarCount"]),
                        CarImage = carImage
                        
                        
                    };
                   TX person = new TX
                    {
                        IsRented = (bool)reader["IsRented"],
                        CarId = car.Id
                    };
              

                    UC_MyCars carControl = new UC_MyCars();
                    carControl.ShowSellButton = false;
                    carControl.ShowNumUpDw = false;
                    carControl.ShowaAcceptBtn = false;
                    carControl.lblCus = false;
                    carControl.ShowUserDetailButton = false;
                    carControl.ShowRejectButton = false;
                    carControl.SelectedCar = car;
                    carControl.SetDesigner();
                    carControl.Margin = new Padding(20); // فاصله بین کنترل‌ها
                    carControl.Width = 832; // اندازه مناسب بده
                    carControl.Height = 188;

                    flpCars.Controls.Add(carControl);
                }
            }
        }



    }
}

