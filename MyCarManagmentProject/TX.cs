using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarManagmentProject
{
    public class TX
    {
        public int CustomerId { get; set; }
        public bool IsRented { get; set; }
        public int CarId { get; set; }
        public int CarCount { get; set; }

        public Cars SelectedCar { get; set; }
    }
}
