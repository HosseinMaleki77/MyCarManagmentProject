using MyCarManagmentProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCarManagmentProject
{
    public partial class frmAdminMainPage : Form
    {
        public frmAdminMainPage()
        {
            InitializeComponent();

            
        }

        private void frmAdminMainPage_Load(object sender, EventArgs e)
        {
            int balance = 250000; // مثلا از دیتابیس گرفتید
            tsWallet.Text = " $" + balance.ToString("N0") + " ";
        }

        private void btnCustomerAndOrders_Click(object sender, EventArgs e)
        {

        }

        private void BtnMyCars_Click(object sender, EventArgs e)
        {
            MyCars myCars = new MyCars();
            myCars.ShowDialog();
        }

        private void btnAddNewCar_Click(object sender, EventArgs e)
        {
            AddNewCar addNewCar = new AddNewCar();
            addNewCar.ShowDialog();
        }
    }
}
