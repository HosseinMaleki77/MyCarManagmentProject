using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarManagmentProject
{
    public class Person
    {

        private static int _Counter = 0;
      
        public string Name { get; private set; }
       
        public string Family { get; private set; }
 
        public int WalletBalance { get; private set; }
        public string UserName { get; set; }
        public string Password { get; private set; }
        public int Id { get; private set; }

        public Person(string name, string family, int walletBalance, string userName, string password)
        {

            Id = ++_Counter;

            Name = name;
            Family = family;

            WalletBalance = walletBalance;
            UserName = userName;
            Password = password;

        }
        
        
    }
    public class Admin : Person
    {

        public string UserAdmin { get; private set; }
        public string PassAdmin { get; private set; }

        public Admin(string userAdmin, string passAdmin, string name, string family, int walletBalance) : base(name, family, walletBalance, userName:"", password:"")
        {
            
                UserAdmin = userAdmin;
                PassAdmin = passAdmin;
            
   
        }

    }
}
    

