using MyCarManagmentProject.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyCarManagmentProject.Controls.UC_MyCarsDetails;

namespace MyCarManagmentProject.Forms
{
    public partial class MyCars : Form
    {
        public MyCars()
        {
            InitializeComponent();

        }

        private void btnBENZ_Click(object sender, EventArgs e)
        {
            pnlCar.Controls.Clear();

            var uc = new UC_MyCarsDetails();
            uc.FactoryFilter = Cars.CarModel.Benz;

            LoadUserControl(uc);




        }



        private void btnBMW_Click(object sender, EventArgs e)
        {

            pnlCar.Controls.Clear();

            var uc = new UC_MyCarsDetails();
            uc.FactoryFilter = Cars.CarModel.BMW;

            LoadUserControl(uc);


        }

        private void btnFERRARI_Click(object sender, EventArgs e)
        {
             pnlCar.Controls.Clear();

            var uc = new UC_MyCarsDetails();
            uc.FactoryFilter = Cars.CarModel.Ferari;

            LoadUserControl(uc);
        }

        private void btnLEXUS_Click(object sender, EventArgs e)
        {
            pnlCar.Controls.Clear();

            var uc = new UC_MyCarsDetails();
            uc.FactoryFilter = Cars.CarModel.Lexus;

            LoadUserControl(uc);
        }

        private void btnTOYOTA_Click(object sender, EventArgs e)
        {
            pnlCar.Controls.Clear();

            var uc = new UC_MyCarsDetails();
            uc.FactoryFilter = Cars.CarModel.Toyota;

            LoadUserControl(uc);
        }

        private void btnAUDI_Click(object sender, EventArgs e)
        {
            pnlCar.Controls.Clear();

            var uc = new UC_MyCarsDetails();
            uc.FactoryFilter = Cars.CarModel.Audi;

            LoadUserControl(uc);
        }

        private void btnFORD_Click(object sender, EventArgs e)
        {
            pnlCar.Controls.Clear();

            var uc = new UC_MyCarsDetails();
            uc.FactoryFilter = Cars.CarModel.Ford;

            LoadUserControl(uc);
        }
        private void LoadUserControl(UserControl uc)
        {
            // پاک کردن کنترل‌های قبلی
            pnlCar.Controls.Clear();

            // پر کردن تمام پنل
            uc.Dock = DockStyle.Fill;

            // اضافه کردن کنترل به پنل
            pnlCar.Controls.Add(uc);
        }
    }
}
