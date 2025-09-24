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
                tsWallet.Text = p.WalletBalance.ToString("N0");
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
    }
}

