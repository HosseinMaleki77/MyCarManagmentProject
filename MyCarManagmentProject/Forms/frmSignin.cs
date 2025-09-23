using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCarManagmentProject
{
    public partial class frmSignin : Form
    {
        //public List<Person> personList = new List<Person>();
        public bool IsAdmin { get; set; }






        //Person person1 = new Person("Mamad", "Maleki",0, "mamad", "1234");
        //Person person2 = new Person("ali", "Maleki", 0, "ali", "12345");





        public frmSignin()
        {
            InitializeComponent();




            //personList.Add(person1);
            //personList.Add(person2);

        }


        private void frmSignin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;

        }

    
        private void btnLogin_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please Enter Your UserName Or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // گرفتن کاربر از دیتابیس
            Person user = GetPersonByUserNameAndPassword(txtUserName.Text, txtPassword.Text);

            if (user != null)
            {
                CurrentUser.User = user; // ← ذخیره کاربر لاگین شده
                MessageBox.Show($"Welcome {user.Name}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.IsAdmin = user.IsAdmin;             // بررسی Admin
                this.DialogResult = DialogResult.OK;
               
            }
            else
            {
                MessageBox.Show("Your UserName Or Password Is Invalid! ,Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmRegisterNewPerson frm = new frmRegisterNewPerson();

            frm.ShowDialog();



        }

        private Person GetPersonByUserNameAndPassword(string username, string password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CarShop"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM USERS WHERE USERNAME=@Username AND PASSWORD=@Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Person customer = new Person
                        {
                            Id = Convert.ToInt32(reader["ID"]),
                            Name = reader["Name"].ToString(),
                            LastName = reader["LASTNAME"].ToString(),
                            UserName = reader["USERNAME"].ToString(),
                            Password = reader["PASSWORD"].ToString(),
                            WalletBalance = reader["WalletBalance"] != DBNull.Value ? Convert.ToInt32(reader["WalletBalance"]) : 0,
                            IsAdmin = (bool)reader["ISADMIN"]
                        };


                        return customer; // فقط یک شخص
                    }
                }
            }

            return null; // اگر شخص پیدا نشد
        }
        private void frmSignin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.None)
            {
                // یعنی کاربر X رو زده → خروج کامل
                this.DialogResult = DialogResult.Cancel;
            }
        }


    }

}
