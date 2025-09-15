using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            lblEngine.Text = SelectedCar.Engine_Dis;
            lblPrice.Text = SelectedCar.Price;
            lblFuel.Text = SelectedCar.Fuel;
            lblTopSpeed.Text = SelectedCar.TopSpeed;
            lblMaxTorque.Text = SelectedCar.MaxTorque;
        }
    }
}
