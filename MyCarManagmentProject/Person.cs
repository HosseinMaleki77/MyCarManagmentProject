using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarManagmentProject
{
    public class Person
    {

        public string Name { get; set; }
        public string Family { get; set; }
        public string Id { get; set; }
        public int WalletBalance { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class Admin : Person
    {
        public string UserAdmin { get; set; }
        public string  PassAdmin { get; set; }
    }
}
