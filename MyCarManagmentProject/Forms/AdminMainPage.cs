using MyCarManagmentProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            Person p = CurrentUser.User;

            if (p != null)
            {

                tsAccount.Text = p.Name + " " + p.LastName;
                tsWallet.Text = p.WalletBalance.ToString("N2");
            }
        }

        private void btnCustomerAndOrders_Click(object sender, EventArgs e)
        {
            CustomersOrders customersOrders = new CustomersOrders();

            customersOrders.FormClosed += (s, args) => UpdateWallet();

            customersOrders.ShowDialog();
        }

        private void BtnMyCars_Click(object sender, EventArgs e)
        {
            MyCars myCars = new MyCars();

            myCars.FormClosed += (s, args) => UpdateWallet();

            myCars.ShowDialog();
        }

        private void btnAddNewCar_Click(object sender, EventArgs e)
        {
            AddNewCar addNewCar = new AddNewCar();
            addNewCar.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
             this.DialogResult = DialogResult.Abort; // نشونه‌ی logout
            this.Close();
        }

        private void UpdateWallet()
        {
            Person p = CurrentUser.User;

            string connectionString = @"Server=.;Database=CarShop;Trusted_Connection=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT walletbalance FROM USERS WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", p.Id);
                object result = cmd.ExecuteScalar();
                p.WalletBalance = result != null ? Convert.ToInt32(result) : 0;
            }

            // آپدیت ToolStrip
            tsWallet.Text = p.WalletBalance.ToString("N0"); // فرمت عددی بدون اعشار
        }

        private void frmUserMainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.None)
            {
                this.DialogResult = DialogResult.Abort;
            }
        }

        private void frmAdminMainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                this.DialogResult = DialogResult.Abort;
            }
        }
    }
}
