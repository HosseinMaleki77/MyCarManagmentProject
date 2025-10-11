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


namespace MyCarManagmentProject.Controls
{
    public partial class UC_MyCarsDetails : UserControl
    {
        public Cars.CarModel FactoryFilter;
        List<Cars> carsList = new List<Cars>();


        public UC_MyCarsDetails()
        {
            InitializeComponent();
         

        }
        private void UC_MyCarsDetails_Load(object sender, EventArgs e)
        {



            panel1.Controls.Clear();
            
            int y = 10; // فاصله اولیه از بالا
            foreach (var car in carsList)
            {
                if (car.Model == FactoryFilter)
                {
                    CartCarDetail detail = new CartCarDetail();
                    detail.SelectedCar = car;
                    detail.SetDesigner();

                    // محل قرارگیری کنترل
                    detail.Location = new Point(100, y);
                    detail.Width = panel1.Width - 10;
                    detail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                    panel1.Controls.Add(detail);

                    y += detail.Height + 70; // فاصله بین کارت‌ها

                }



            }

        }


        
    }
}






