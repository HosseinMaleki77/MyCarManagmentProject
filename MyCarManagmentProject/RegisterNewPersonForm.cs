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
    public partial class frmRegisterNewPerson : Form
    {
        List<Person> list = new List<Person>();
        public frmRegisterNewPerson()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            foreach (var item in collection)
            {

            }
            Person person = new Person();
            person.Name = txtFirstName.Text;
            person.Family = txtLastName.Text;
            person.UserName = txtRUserName.Text;
            person.Password = txtRPassword.Text;
          
        }
    }
}
