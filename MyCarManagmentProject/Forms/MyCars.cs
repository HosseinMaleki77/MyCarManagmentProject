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

        private void btnMercedesBenz_Click(object sender, EventArgs e)
        {
            pnlCar.Controls.Clear();


            LoadUserControl(new UC_MyCarsDetails(CarModel.Benz));
            UC_MyCarsDetails carControl = new UC_MyCarsDetails(CarModel.Benz);

    

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

        private void button2_Click(object sender, EventArgs e)
        {
            pnlCar.Controls.Clear();

         
        }
    }
}
