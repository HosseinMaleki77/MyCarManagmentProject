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
using static MyCarManagmentProject.Controls.UC_MyCarsDetails;

namespace MyCarManagmentProject.Forms
{
    public partial class MyCars : Form
    {
        public Cars.CarModel FactoryFilter;
        List<Cars> carsList = new List<Cars>();


        bool isadmin=false;
        public MyCars()
        {
            InitializeComponent();

        }

        private void btnBENZ_Click(object sender, EventArgs e)
        {
            //pnlCar.Controls.Clear();

            //var uc = new UC_MyCarsDetails();
            //uc.FactoryFilter = Cars.CarModel.Benz;


            //LoadUserControl(uc);
           
             LoadCarsFromDatabase(Cars.CarModel.Benz);
            DisplayCars(carsList);






        }



        private void btnBMW_Click(object sender, EventArgs e)
        {

            ////pnlCar.Controls.Clear();

            //var uc = new UC_MyCarsDetails();
            //uc.FactoryFilter = Cars.CarModel.BMW;

            //LoadUserControl(uc);

            LoadCarsFromDatabase(Cars.CarModel.BMW);
            DisplayCars(carsList);


        }

        private void btnFERRARI_Click(object sender, EventArgs e)
        {
            //     //pnlCar.Controls.Clear();

            //    var uc = new UC_MyCarsDetails();
            //    uc.FactoryFilter = Cars.CarModel.Ferari;

            //    LoadUserControl(uc);

            LoadCarsFromDatabase(Cars.CarModel.Ferari);
            DisplayCars(carsList);
        }

        private void btnLEXUS_Click(object sender, EventArgs e)
        {
            //pnlCar.Controls.Clear();

            //var uc = new UC_MyCarsDetails();
            //uc.FactoryFilter = Cars.CarModel.Lexus;

            //LoadUserControl(uc);

            LoadCarsFromDatabase(Cars.CarModel.Lexus);
            DisplayCars(carsList);
        }

        private void btnTOYOTA_Click(object sender, EventArgs e)
        {
            //pnlCar.Controls.Clear();

            //var uc = new UC_MyCarsDetails();
            //uc.FactoryFilter = Cars.CarModel.Toyota;

            //LoadUserControl(uc);

            LoadCarsFromDatabase(Cars.CarModel.Toyota);
            DisplayCars(carsList);
        }

        private void btnAUDI_Click(object sender, EventArgs e)
        {
            //pnlCar.Controls.Clear();

            //var uc = new UC_MyCarsDetails();
            //uc.FactoryFilter = Cars.CarModel.Audi;

            //LoadUserControl(uc);

            LoadCarsFromDatabase(Cars.CarModel.Audi);
            DisplayCars(carsList);
        }

        private void btnFORD_Click(object sender, EventArgs e)
        {
            ////pnlCar.Controls.Clear();

            //var uc = new UC_MyCarsDetails();
            //uc.FactoryFilter = Cars.CarModel.Ford;

            //LoadUserControl(uc);

            LoadCarsFromDatabase(Cars.CarModel.Ford);
            DisplayCars(carsList);
        }
        //private void LoadUserControl(UserControl uc)
        //{
        //    // پاک کردن کنترل‌های قبلی
        //    //pnlCar.Controls.Clear();

        //    // پر کردن تمام پنل
        //    uc.Dock = DockStyle.Fill;

        //    // اضافه کردن کنترل به پنل
        //    //pnlCar.Controls.Add(uc);
        //}

        private List<Cars> LoadCarsFromDatabase(Cars.CarModel FactoryFilter)
        {
           carsList.Clear();


            string connectionString = ConfigurationManager.ConnectionStrings["CarShop"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM CarInfo WHERE Factory = @Factory";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // اگر در دیتابیس Factory به صورت متن (BMW, Benz ...) ذخیره شده:
                    

                    // اگر در دیتابیس Factory به صورت عدد (0,1,2 ...) ذخیره شده:
                    cmd.Parameters.AddWithValue("@Factory", (int)FactoryFilter);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string folderPath = @"C:\C# TESTS\CarManagementProject\MyCarManagmentProject\UserImages";
                            string imageName = reader["IMAGEPATH"].ToString(); // نام عکس از دیتابیس
                            string imagePath = Path.Combine(folderPath, imageName);

                            Image carImage = null;
                            if (File.Exists(imagePath))
                            {
                                // کپی Bitmap → فایل باز نمی‌ماند
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
                                CarCount = Convert.ToInt32(reader["Count"]),

                                // اگر Factory در دیتابیس متن است:
                              

                                // اگر Factory در دیتابیس عدد است:
                                 Model = (Cars.CarModel)Convert.ToInt32(reader["Factory"]),

                                CarImage = carImage
                            };

                            carsList.Add(car);
                        }
                    }
                }
            }

            return carsList;
        }


        private void DisplayCars(List<Cars> carsList)
        {
            // قبل از پر کردن دوباره، پنل رو خالی کن
            flpCars.Controls.Clear();
            flpCars.FlowDirection = FlowDirection.LeftToRight;
            flpCars.WrapContents = true;

            foreach (var car in carsList)
            {
                CartCarDetail carControl = new CartCarDetail
                {
                    //ShowSellButton = false,
                    //ShowNumUpDw = false,
                    SelectedCar = car,
                    Margin = new Padding(20), // فاصله بین کنترل‌ها
                    Width = 832,
                    Height = 188
                };

                carControl.SetDesigner();

                // اضافه کردن کنترل به پنل
                flpCars.Controls.Add(carControl);
            }
        }
    }
}
