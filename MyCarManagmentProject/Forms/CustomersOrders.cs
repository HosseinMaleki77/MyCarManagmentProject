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
            var carTxPairs = LoadCustomersOrders(); // 👈 بدون فیلتر مشتری

            flpCars.Controls.Clear();
            flpCars.FlowDirection = FlowDirection.LeftToRight;
            flpCars.WrapContents = true;

            foreach (var pair in carTxPairs)
            {
                UC_MyCars carControl = new UC_MyCars();
                carControl.ShowSellButton = false;
                carControl.ShowNumUpDw = false;
                carControl.ShowCancelBtn = false;

                carControl.SelectedCar = pair.Car;
                carControl.SelectedTx = pair.Transaction;

                carControl.SetDesigner();
                carControl.Margin = new Padding(20);
                carControl.Width = 832;
                carControl.Height = 188;

                flpCars.Controls.Add(carControl);
            }
        }




        // در بالای کلاس CustomersOrders اضافه کن:
        private Dictionary<int, TX> carTransactions = new Dictionary<int, TX>();

        public List<(Cars Car, TX Transaction)> LoadCustomersOrders()
        {
            List<(Cars, TX)> result = new List<(Cars, TX)>();

            string connectionString = ConfigurationManager.ConnectionStrings["CarShop"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT c.ID AS CarId, c.Name, c.MaximumPower, c.Acceleration, c.Transmission,
                                c.DoorCount, c.EngineDetails, c.Price, c.Fuel, c.TopSpeed, c.MaximumTorque,
                                c.Factory, c.IMAGEPATH,
                                t.ID AS TxId, t.CustomerId, t.CarId, t.Time, t.IsRented
                         FROM CarInfo c
                         INNER JOIN TX t ON c.Id = t.CarId
                         WHERE t.IsDone = 0
                         ORDER BY t.Time ASC";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // 📷 خواندن تصویر
                            string folderPath = @"E:\test c#\MyCarManagmentProject\MyCarManagmentProject\UserImages";
                            string imageName = reader["IMAGEPATH"]?.ToString() ?? string.Empty;
                            string imagePath = Path.Combine(folderPath, imageName);

                            Image carImage = null;
                            if (!string.IsNullOrEmpty(imageName) && File.Exists(imagePath))
                            {
                                using (var temp = Image.FromFile(imagePath))
                                    carImage = new Bitmap(temp);
                            }
                            else
                            {
                                carImage = Properties.Resources.no_image_icon_4;
                            }

                            // 🚗 ساخت شیء ماشین
                            Cars car = new Cars
                            {
                                Id = Convert.ToInt32(reader["CarId"]),
                                Name = reader["Name"]?.ToString(),
                                MaxPower = reader["MaximumPower"]?.ToString(),
                                Acceleration = reader["Acceleration"]?.ToString(),
                                Transmission = reader["Transmission"]?.ToString(),
                                DoorCount = reader["DoorCount"]?.ToString(),
                                Engine_Details = reader["EngineDetails"]?.ToString(),
                                Price = Convert.ToInt32(reader["Price"]),
                                Fuel = reader["Fuel"]?.ToString(),
                                TopSpeed = reader["TopSpeed"]?.ToString(),
                                MaxTorque = reader["MaximumTorque"]?.ToString(),
                                CarImage = carImage
                            };

                            // 💾 ساخت شیء تراکنش
                            TX tx = new TX
                            {
                                CustomerId = Convert.ToInt32(reader["CustomerId"]),
                                CarId = Convert.ToInt32(reader["CarId"]),
                                Time = reader["Time"] != DBNull.Value ? (DateTime?)reader["Time"] : null,
                                IsRented = Convert.ToBoolean(reader["IsRented"]),
                                SelectedCar = car
                            };

                            result.Add((car, tx));
                        }
                    }
                }
            }

            return result;
        }




        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Person user = CurrentUser.User;

            RefreshCars();
        }
        public void RefreshCars()
        {
            flpCars.Controls.Clear();
            var carTxPairs = LoadCustomersOrders(); // ✅ همه تراکنش‌ها بدون فیلتر

            foreach (var pair in carTxPairs)
            {
                UC_MyCars carControl = new UC_MyCars();
                carControl.ShowSellButton = false;
                carControl.ShowNumUpDw = false;
                carControl.ShowCancelBtn = false;

                carControl.SelectedCar = pair.Car;
                carControl.SelectedTx = pair.Transaction;

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

