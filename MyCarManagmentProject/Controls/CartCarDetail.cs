using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MyCarManagmentProject.Controls
{
    public partial class CartCarDetail : UserControl
    {
        public CartCarDetail()
        {
            InitializeComponent();

        }

        public Cars SelectedCar { get; set; }


        private void CartCarDetail_Load(object sender, EventArgs e)
        {

        }
        public void SetDesigner()
        {

            lblName.Text = SelectedCar.Name;
            lblMaxPower.Text = SelectedCar.MaxPower;
            lblAcceleration.Text = SelectedCar.Acceleration;
            lblTransmission.Text = SelectedCar.Transmission;
            lblDoors.Text = SelectedCar.DoorCount;
            lblEngineDetails.Text = SelectedCar.Engine_Details;
            lblPrice.Text = SelectedCar.Price;
            lblFuel.Text = SelectedCar.Fuel;
            lblTopSpeed.Text = SelectedCar.TopSpeed;
            lblMaxTorque.Text = SelectedCar.MaxTorque;
            pictureBox1.Image = SelectedCar.CarImage;
            nmCarCount.Value = (int)SelectedCar.CarCount;
        }

        private void nmCarCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UpdateCount()
        {

            int carCount = (int)nmCarCount.Value;

            // اتصال به دیتابیس
            string connectionString = "Data Source=.;Initial Catalog=CarShop;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE CarInfo SET COUNT=" + carCount + " WHERE ID=" + SelectedCar.Id;
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Count", carCount);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}