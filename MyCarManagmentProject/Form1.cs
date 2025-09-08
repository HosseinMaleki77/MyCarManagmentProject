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
    public partial class frmSignin : Form
    {
        public frmSignin()
        {
            InitializeComponent();
        }

        private void frmSignin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            Admin admin = new Admin();
            admin.UserAdmin = "admin";
            admin.PassAdmin = "123";
            admin.Name = "Hossein";


            Person person1 = new Person() {Name = "Ali" , Family="Rezaii" , Id="1" , UserName= "ali" , Password="1234"};
            Person person2 = new Person() { Name = "Mohammad", Family = "Kamali", Id = "2", UserName = "mohammad", Password = "1234" };
            List<Person> personList = new List<Person>();
            personList.Add(person1);
            personList.Add(person2);
            if (txtUserName.Text == admin.UserAdmin && txtPassword.Text == admin.PassAdmin)
            {
                MessageBox.Show("Hello Hossein (Admin)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else if(txtUserName.Text==person1.UserName && txtPassword.Text==person1.Password)
            {
                MessageBox.Show("Hello Ali", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtUserName.Text == person2.UserName && txtPassword.Text == person2.Password)
            {
                MessageBox.Show("Hello Mohammad", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            foreach (var p in personList)
            {
                if (p.UserName != txtUserName.Text || p.Password != txtPassword.Text)
                {
                    MessageBox.Show("Your Password Or UserName Is Invalid! Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                break;
            }

                

            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Your UserName Or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRegisterNewPerson frm = new frmRegisterNewPerson();

            frm.ShowDialog();

        }
    }
}
