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

            var carsAndTx = LoadMyCarsFromDatabase(user.Id);

            foreach (var (car, tx) in carsAndTx)
            {
                UC_MyCars carControl = new UC_MyCars();
                carControl.ShowSellButton = false;
                carControl.ShowNumUpDw = false;
                carControl.ShowaAcceptBtn = false;
                carControl.lblCus = false;
                carControl.ShowUserDetailButton = false;
                carControl.ShowRejectButton = false;

                carControl.SelectedCar = car;
                carControl.SelectedTx = tx;

                carControl.SetDesigner();
                carControl.Margin = new Padding(20);
                carControl.Width = 832;
                carControl.Height = 188;

                flpCars.Controls.Add(carControl);
            }
        }

        private List<(Cars car, TX tx)> LoadMyCarsFromDatabase(int customerId)
        {
            var myCarsList = new List<(Cars, TX)>();

            string connectionString = ConfigurationManager.ConnectionStrings["CarShop"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT c.ID, c.Name, c.MaximumPower, c.Acceleration, c.Transmission, 
                   c.DoorCount, c.EngineDetails, c.Price, c.Fuel, 
                   c.TopSpeed, c.MaximumTorque, c.Factory, c.IMAGEPATH,
                   t.IsRented,t.IsDone,t.Time
            FROM CarInfo c
            INNER JOIN TX t ON c.Id = t.CarId
            WHERE t.CustomerId = @CustomerId AND t.IsDone = 0 AND t.Rejected = 0";

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

                            Image carImage = File.Exists(imagePath)
                                ? new Bitmap(Image.FromFile(imagePath))
                                : Properties.Resources.no_image_icon_4;

                            var car = new Cars
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
                                Model = (Cars.CarModel)reader["Factory"],
                                CarImage = carImage
                            };
                            DateTime? txTime = reader["Time"] != DBNull.Value ? (DateTime?)reader["Time"] : null;


                            var tx = new TX
                            {
                                CarId = car.Id,
                                CustomerId = customerId,
                                IsRented = (bool)reader["IsRented"],
                                Time = txTime


                            };

                            myCarsList.Add((car, tx));
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
               C.MaximumPower, C.MaximumTorque, t.IsRented,C.ImagePath, t.IsDone,t.Time,t.Rejected
        FROM TX T
        JOIN CarInfo C ON T.CarId = C.Id
        WHERE T.CustomerId=@CustomerId AND t.IsDone = 0 AND t.Rejected = 0";

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
                        CarImage = carImage
                    };


                    DateTime? txTime = reader["Time"] != DBNull.Value ? (DateTime?)reader["Time"] : null;



                    TX tx = new TX
                    {
                        CustomerId = customerId,
                        CarId = car.Id,
                        IsRented = (bool)reader["IsRented"],
                        Time = txTime

                    };

                

                    UC_MyCars carControl = new UC_MyCars();
                    carControl.ShowSellButton = false;
                    carControl.ShowNumUpDw = false;
                    carControl.ShowaAcceptBtn = false;
                    carControl.lblCus = false;
                    carControl.ShowUserDetailButton = false;
                    carControl.ShowRejectButton = false;
                    carControl.SelectedCar = car;
                    carControl.SelectedTx = tx;
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

