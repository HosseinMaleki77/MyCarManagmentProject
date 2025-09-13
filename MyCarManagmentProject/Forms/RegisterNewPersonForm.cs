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
       private List<Person> _NewPersons;
        public frmRegisterNewPerson(List<Person> personList)
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            _NewPersons = personList;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            foreach (var p in _NewPersons)
            {
                if(p.UserName == txtRUserName.Text)
                {
                    MessageBox.Show("Your UserName Is Taken by Someone else! Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else
                {
                    Person person = new Person(txtFirstName.Text,txtLastName.Text,0,txtRUserName.Text,txtRPassword.Text);
                   
                    _NewPersons.Add(person);
                    MessageBox.Show("Hello Welcome!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                    this.Close();
                    break;

                }

            }
        
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
