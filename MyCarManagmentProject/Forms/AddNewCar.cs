using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static MyCarManagmentProject.Cars;

namespace MyCarManagmentProject.Forms
{
    public partial class AddNewCar : Form
    {
        public AddNewCar()
        {
            InitializeComponent();
            picBoxNewCar.AllowDrop = true;
            picBoxNewCar.DragEnter += picBoxNewCar_DragEnter;
            picBoxNewCar.DragDrop += picBoxNewCar_DragDrop;
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void AddNewCar_Load(object sender, EventArgs e)
        {
            cbFactory.DataSource = Enum.GetValues(typeof(CarModel)); // نشان دادن اسم ها در کومبو بامس و هم مقادیر آن ها نه فقط استرینگ  

        }

        private void picBoxNewCar_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {

                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0)
                {
                    string ext = System.IO.Path.GetExtension(files[0]).ToLower();
                    if (ext == ".png")
                    {
                        e.Effect = DragDropEffects.Copy; // فقط اگه عکس بود
                        return;
                    }
                }
            }
            e.Effect = DragDropEffects.None; // در غیر این صورت اجازه نده
        }
        private void picBoxNewCar_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {

                string selectedImagePath = files[0];

                // گرفتن نام کاربر از TextBox
                string userName = txtCarName.Text.Trim();
                if (string.IsNullOrEmpty(userName))
                {
                    MessageBox.Show("لطفاً ابتدا نام خود را وارد کنید.");
                    return;
                }

                // امن‌سازی نام فایل (حذف کاراکترهای غیرمجاز)
                foreach (char c in Path.GetInvalidFileNameChars())
                    userName = userName.Replace(c, '_');

                string projectFolder = @"C:\C# TESTS\CarManagementProject\MyCarManagmentProject\UserImages";
                // مسیر فولدر ذخیره‌سازی عکس
                string folderPath = Path.Combine(projectFolder, "UserImages");
                Directory.CreateDirectory(folderPath);

                // نام فایل بر اساس نام کاربر
                string fileName = userName + Path.GetExtension(selectedImagePath);
                string savePath = Path.Combine(folderPath, fileName);

                // کپی عکس به فولدر
                File.Copy(selectedImagePath, savePath, true); // جایگزینی در صورت وجود

                // نمایش عکس در PictureBox
                picBoxNewCar.Image = Image.FromFile(savePath);

                MessageBox.Show("عکس با نام شما ذخیره شد: " + fileName);
            }
        }



        private void btnAddCar_Click(object sender, EventArgs e)
        {
            InsertCount();
            MessageBox.Show("New Car Added SuccessFully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void InsertCount()
        {
            int carCount = (int)nmCarCountAdd.Value;
            string name = txtCarName.Text;
            string enginedetails = txtEngineDet.Text;
            string maxpower = txtMaxPower.Text;
            string maxtorque = txtMaxTorq.Text;
            string topspeed = txtTopSpeed.Text;
            string transmission = txtTransmission.Text;
            string acceleration = txtAcceler.Text;
            string doorsnumber = txtDoorsNum.Text;
            string fuel = txtFuel.Text;
            int factory = (int)cbFactory.SelectedItem;
            string price = txtPrice.Text;



            string connectionString = "Data Source=.;Initial Catalog=CarShop;Integrated Security=True;";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO CARINFO (Name, ENGINEDETAILS, MAXIMUMPOWER, MaximumTorque, Transmission,Acceleration, TopSpeed, DoorsNumber, Fuel, Price, Factory, Count) VALUES (@Name, @ENGINEDETAILS, @MAXIMUMPOWER, @MaximumTorque, @Transmission,@Acceleration, @TopSpeed, @DoorsNumber, @Fuel, @Price, @Factory, @Count)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Count", carCount);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@enginedetails", enginedetails);
                cmd.Parameters.AddWithValue("@maximumpower", maxpower);
                cmd.Parameters.AddWithValue("@maximumtorque", maxtorque);
                cmd.Parameters.AddWithValue("@topspeed", topspeed);
                cmd.Parameters.AddWithValue("@transmission", transmission);
                cmd.Parameters.AddWithValue("@acceleration", acceleration);
                cmd.Parameters.AddWithValue("@doorsnumber", doorsnumber);
                cmd.Parameters.AddWithValue("@fuel", fuel);
                cmd.Parameters.AddWithValue("@factory", factory);
                cmd.Parameters.AddWithValue("@price", price);



                conn.Open();
                cmd.ExecuteNonQuery();
            }

        }

        //private void picBoxNewCar_DragDrop(object sender, DragEventArgs e)
        //{
        //    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

        //if (files != null && files.Length > 0)
        //{

        //    string ext = System.IO.Path.GetExtension(files[0]).ToLower();
        //    if (ext == ".png")
        //    {
        //        // عکس قبلی رو آزاد کن
        //        if (picBoxNewCar.Image != null)
        //            picBoxNewCar.Image.Dispose();

        //        // عکس جدید رو لود کن
        //        picBoxNewCar.Image = Image.FromFile(files[0]);
        //    }
        //    else
        //    {
        //        MessageBox.Show("فقط فایل عکس مجاز است ( png )");

        //    }
        //}

    }
}

