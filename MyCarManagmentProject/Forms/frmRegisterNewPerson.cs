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
    public partial class frmRegisterNewPerson : Form
    {
     
        public frmRegisterNewPerson()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
           

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            try
            {
                InsertPerson();
            }
            catch
            {

                MessageBox.Show("Username Has Already Been Taken By Someone Else", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertPerson()
        {
           
            string name = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string username = txtRPassword.Text;
            string password = txtRPassword.Text;




            string connectionString = "Data Source=.;Initial Catalog=CarShop;Integrated Security=True;";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO USERS (NAME, LASTNAME, USERNAME, [PASSWORD]) VALUES (@Name, @LASTNAME, @USERNAME, @PASSWORD)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NAME", name);
                cmd.Parameters.AddWithValue("@LASTNAME", lastname);
                cmd.Parameters.AddWithValue("@USERNAME", username);
                cmd.Parameters.AddWithValue("@PASSWORD", password);




                conn.Open();
                cmd.ExecuteNonQuery();
            }

        }
    }
}
