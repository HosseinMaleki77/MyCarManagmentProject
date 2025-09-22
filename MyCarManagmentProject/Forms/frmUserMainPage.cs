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
    public partial class frmUserMainPage : Form
    {
        public frmUserMainPage()
        {
            InitializeComponent();

            
        }

        private void frmUserMainPage_Load(object sender, EventArgs e)
        {

            Person p = CustomerUser.User;

            if (p != null)
            {
     
                tsWallet.Text = p.WalletBalance.ToString("N0");
                tsAccount.Text = p.Name +" "+ p.LastName;

            }
        }

        private void btnCustomerAndOrders_Click(object sender, EventArgs e)
        {

        }

        private void BtnMyCars_Click(object sender, EventArgs e)
        {
           
            MyCars myCars = new MyCars();
            myCars.ShowDialog();
        }

    }
}
