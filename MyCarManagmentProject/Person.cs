using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarManagmentProject
{
    public class Person
    {
        private string _name;
        private string _family;
 
        private int _walletBalance;
        private string _userName;
        private string _password;

        public string Name { get; private set; }
        public string Family { get; private set; }
 
        public int WalletBalance { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }

        public Person(string name, string family, int walletBalance, string userName, string password)
        {


            Name = name;
            Family = family;

            WalletBalance = walletBalance;
            UserName = userName;
            Password = password;

        }
    }
    public class Admin : Person
    {
        private string _userAdmin;
        private string _passAdmin;
        public string UserAdmin { get; private set; }
        public string PassAdmin { get; private set; }

        public Admin(string userAdmin, string passAdmin, string name, string family, int walletBalance, string userName, string password) : base(name, family, walletBalance, userName, password)
        {
            {
                UserAdmin = userAdmin;
                PassAdmin = passAdmin;
            }



        }
    }
}
    

