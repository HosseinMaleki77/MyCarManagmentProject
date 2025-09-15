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

        public bool IsAdmin { get; set; }

        public List<Admin> adminList = new List<Admin>();

        Admin admin = new Admin("a", "123", "Hossein", "Maleki", 0);




        public List<Person> personList = new List<Person>();

        Person person1 = new Person("Mamad", "Maleki",0, "mamad", "1234");
        Person person2 = new Person("ali", "Maleki", 0, "ali", "12345");





        public frmSignin()
        {    
            InitializeComponent();
         
            

          

            personList.Add(person1);
            personList.Add(person2);
            adminList.Add(admin);
        }


        private void frmSignin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
         
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool flag = false;
            

            foreach (var a in adminList)
            {
                if (txtUserName.Text == a.UserAdmin && txtPassword.Text == a.PassAdmin)
                {
                    MessageBox.Show("Hello Hossein (Admin)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.DialogResult = DialogResult.OK;
                    this.IsAdmin = true;
                    this.Close();
                    flag = true;

                    break;
                }
            }
         
            if (!flag)
            {
                foreach (var p in personList)
                {
                    if (p.UserName == txtUserName.Text && p.Password == txtPassword.Text)
                    {
                        MessageBox.Show($"Welcome {p.Name}", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        this.DialogResult = DialogResult.OK;
                        this.IsAdmin = false;
                        this.Close();
                        flag = true;

                        break;
                    }

                }
            }
        
           
     



            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Your UserName Or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if(!flag)
            {
                MessageBox.Show("Your UserName Or Password Is Invalid! ,Please Try Again", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
            }




        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmRegisterNewPerson frm = new frmRegisterNewPerson(personList);

            frm.ShowDialog();

        }
    }
}
