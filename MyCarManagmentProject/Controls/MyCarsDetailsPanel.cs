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
    public partial class UC_MyCarsDetails : UserControl
    {
        CarModel selectedModel;
        public enum CarModel 
        {
            Benz,
            BMW,
            Ferari
        }

        public UC_MyCarsDetails(CarModel carModel)
        {
            InitializeComponent();
            this.selectedModel = CarModel.Benz;
        }
        // مدل ماشین
        public string Fuel
        {
            get { return lblFuel.Text; }
            set { lblFuel.Text = value; }
        }

        // سال ماشین
        public string Engine
        {
            get { return lblEngine.Text; }
            set { lblEngine.Text = value; }
        }

        // قیمت ماشین
        public string CarPrice
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }
        public string EngineDetails
        {
            get { return lblEngineDetails.Text; }
            set { lblEngineDetails.Text = value; }
        }
        public string MaxPower
        {
            get { return lblMaxPower.Text; }
            set { lblMaxPower.Text = value; }
        }
        public string MaxTorque
        {
            get { return lblMaxTorque.Text; }
            set { lblMaxTorque.Text = value; }
        }
        public string TopSpeed
        {
            get { return lblTopSpeed.Text; }
            set { lblTopSpeed.Text = value; }
        }
        public string Transmission
        {
            get { return lblTransmission.Text; }
            set { lblTransmission.Text = value; }
        }
        public string Acceleration
        {
            get { return lblAcceleration.Text; }
            set { lblAcceleration.Text = value; }
        }
        public string Doors
        {
            get { return lblDoors.Text; }
            set { lblDoors.Text = value; }
        }

        private void UC_MyCarsDetails_Load(object sender, EventArgs e)
        {
            if(selectedModel == CarModel.Benz)
            {
                
            }
            else if (selectedModel == CarModel.BMW)
            {
                
            }
            else if(selectedModel == CarModel.Ferari)
            {

            }
        }
    }



}

