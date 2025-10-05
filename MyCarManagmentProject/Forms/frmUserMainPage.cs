using MyCarManagmentProject.Controls;
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
    public partial class frmUserMainPage : Form
    {
        public frmUserMainPage()
        {


            InitializeComponent();


        }

        private void frmUserMainPage_Load(object sender, EventArgs e)
        {


            Person p = CurrentUser.User;

            if (p != null)
            {

                tsAccount.Text = p.Name + " " + p.LastName;
                tsWallet.Text = p.WalletBalance.ToString("N2");
            }
        }

        private void btnBuyAndRent_Click(object sender, EventArgs e)
        {

           
            MyCars myCars = new MyCars();

            myCars.FormClosed += (s, args) => UpdateWallet();

            myCars.ShowDialog();
        }

        private void btnMyCars_Click(object sender, EventArgs e)
        {
            MyUserCars myUserCars = new MyUserCars();
            myUserCars.FormClosed += (s, args) => UpdateWallet();
            myUserCars.ShowDialog();
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

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort; // نشونه‌ی logout
            this.Close();
        }


        private void frmUserMainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                this.DialogResult = DialogResult.Abort;
            }

        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
            Person p = CurrentUser.User;
            DialogResult result = MessageBox.Show("You Will Add 100,000$ To Your Wallet,Are You Sure?", "Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                p.WalletBalance = p.WalletBalance + 100000;
                string connectionString = @"Server=.;Database=CarShop;Trusted_Connection=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE USERS SET walletbalance=@Balance WHERE ID=@ID", con);
                    cmd.Parameters.AddWithValue("@Balance", p.WalletBalance);
                    cmd.Parameters.AddWithValue("@ID", p.Id);
                    cmd.ExecuteNonQuery();
                }
                UpdateWallet();

            }

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            MyOrders myOrders = new MyOrders();
            myOrders.FormClosed += (s, args) => UpdateWallet();
            myOrders.ShowDialog();
        }
    }
}

