using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarManagmentProject
{
    public class Person
    {

        //private static int _Counter = 0;
      
        public string Name { get;  set; }
       
        public string LastName { get;  set; }
 
        public decimal WalletBalance { get;  set; }
        public string UserName { get; set; }
        public string Password { get;  set; }
        public int Id { get; set; }

        public List<Cars> MyCars { get; set; } = new List<Cars>();  // اینجا new شد
        public bool IsAdmin { get; set; }


       


    }
    public class Admin
    {

        public string UserAdmin { get; private set; }
        public string PassAdmin { get; private set; }
        public int WalletBalance { get; set; }

        public Admin(string userAdmin, string passAdmin, string name, string lastname, int walletBalance)
        {
            
                UserAdmin = userAdmin;
                PassAdmin = passAdmin;
            
            
   
        }

    }
}
    

