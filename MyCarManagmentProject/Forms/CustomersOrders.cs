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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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
            var cars = LoadCustomersOrders(user.Id);

            flpCars.Controls.Clear();
            flpCars.FlowDirection = FlowDirection.LeftToRight;
            flpCars.WrapContents = true;

            foreach (var car in cars)
            {
                UC_MyCars carControl = new UC_MyCars();
                carControl.ShowSellButton = false;
                carControl.ShowNumUpDw = false;
                carControl.ShowCancelBtn = false;
                carControl.SelectedCar = car;

                // 🔹 گرفتن TX از دیکشنری با شناسه ماشین
                if (carTransactions.ContainsKey(car.Id))
                    carControl.SelectedTx = carTransactions[car.Id];

                carControl.SetDesigner();
                carControl.Margin = new Padding(20);
                carControl.Width = 832;
                carControl.Height = 188;
                flpCars.Controls.Add(carControl);
            }
        }


        // در بالای کلاس CustomersOrders اضافه کن:
        private Dictionary<int, TX> carTransactions = new Dictionary<int, TX>();

        public List<Cars> LoadCustomersOrders(int customerId)
        {
            List<Cars> myCarsList = new List<Cars>();
            carTransactions.Clear(); // هر بار از نو ساخته شود

            string connectionString = ConfigurationManager.ConnectionStrings["CarShop"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT c.ID, c.Name, c.MaximumPower, c.Acceleration, c.Transmission,
          c.DoorCount, c.EngineDetails, c.Price, c.Fuel,
          c.TopSpeed, c.MaximumTorque, c.Factory, c.IMAGEPATH,m.CustomerId, m.IsRented,m.Time
          FROM CarInfo c
          INNER JOIN TX m ON c.Id = m.CarId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string folderPath = @"E:\test c#\MyCarManagmentProject\MyCarManagmentProject\UserImages";
                            string imageName = reader["IMAGEPATH"]?.ToString() ?? string.Empty;
                            string imagePath = Path.Combine(folderPath, imageName);

                            Image carImage = null;
                            if (!string.IsNullOrEmpty(imageName) && File.Exists(imagePath))
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
                                Id = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : 0,
                                Name = reader["Name"]?.ToString() ?? string.Empty,
                                MaxPower = reader["MaximumPower"]?.ToString() ?? string.Empty,
                                Acceleration = reader["Acceleration"]?.ToString() ?? string.Empty,
                                Transmission = reader["Transmission"]?.ToString() ?? string.Empty,
                                DoorCount = reader["DoorCount"]?.ToString() ?? string.Empty,
                                Engine_Details = reader["EngineDetails"]?.ToString() ?? string.Empty,
                                Price = reader["Price"] != DBNull.Value ? Convert.ToInt32(reader["Price"]) : 0,
                                Fuel = reader["Fuel"]?.ToString() ?? string.Empty,
                                TopSpeed = reader["TopSpeed"]?.ToString() ?? string.Empty,
                                MaxTorque = reader["MaximumTorque"]?.ToString() ?? string.Empty,

                            CarImage = carImage
                            };

                            // نگه‌داشتن TX مرتبط با هر CarId در دیکشنری
                            int txCustomerId = reader["CustomerId"] != DBNull.Value ? Convert.ToInt32(reader["CustomerId"]) : 0;
                            bool txIsRented = reader["IsRented"] != DBNull.Value ? Convert.ToBoolean(reader["IsRented"]) : false;
                            DateTime? txTime = reader["Time"] != DBNull.Value ? (DateTime?)reader["Time"] : null;

                                TX tx = new TX
                            {
                                CustomerId = txCustomerId,
                                IsRented = txIsRented,
                                CarId = car.Id,
                                SelectedCar = car,
                                Time = txTime
                            };

                            // نگهداری در دیکشنری برای دسترسی بعدی
                            carTransactions[car.Id] = tx;

                            myCarsList.Add(car);
                        }
                    }
                }
            }

            return myCarsList;
        }


        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Person user = CurrentUser.User;

            RefreshCars(user.Id);
        }
        public void RefreshCars(int customerId)
        {
            flpCars.Controls.Clear();
            var cars = LoadCustomersOrders(customerId);

            foreach (var car in cars)
            {
                UC_MyCars carControl = new UC_MyCars();
                carControl.ShowSellButton = false;
                carControl.ShowNumUpDw = false;
                carControl.ShowCancelBtn = false;
                carControl.SelectedCar = car;

                if (carTransactions.ContainsKey(car.Id))
                    carControl.SelectedTx = carTransactions[car.Id];

                carControl.SetDesigner();
                carControl.Margin = new Padding(10);
                carControl.Width = 832;
                carControl.Height = 188;
                flpCars.Controls.Add(carControl);
            }

            flpCars.Refresh();
            flpCars.Invalidate();
            flpCars.Update();
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

