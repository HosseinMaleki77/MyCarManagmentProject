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
        //List<Cars> allCars;
        public Cars.CarModel FactoryFilter;
        List<Cars> carsList = new List<Cars>();

        //public string FactoryFilter { get; set; }

        public UC_MyCarsDetails()
        {
            InitializeComponent();
         

        }
        private void UC_MyCarsDetails_Load(object sender, EventArgs e)
        {


            //LoadCarsFromDatabase();

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






        //    else if (selectedModel == Cars.CarModel.BMW)
        //    {

        //    }
        //    else if(selectedModel == Cars.CarModel.Ferari)
        //    {

        //    }
        //}



        //public void LoadCarList()
        //{
        //    //allCars = new List<Cars>()
        //    //{
        //        //new Cars(Cars.CarModel.Ferari,"F1_1"),
        //        //new Cars(Cars.CarModel.Benz,"GClass_1"),
        //        //new Cars(Cars.CarModel.BMW,"X4_1"),
        //        //new Cars(Cars.CarModel.Ferari,"F1_2"),
        //        //new Cars(Cars.CarModel.Benz,"GClass_2"),
        //        //new Cars(Cars.CarModel.BMW,"X4_2"),
        //        //new Cars(Cars.CarModel.Ferari,"F1_3"),
        //        //new Cars(Cars.CarModel.Benz,"GClass_3"),
        //        //new Cars(1,"b", "b", "b", "b", "b", "b", "b", "b", "b", Cars.CarModel.Benz, "b","Benze",Properties.Resources.mercedes_S500),
        //        //new Cars(2,"a","c","d","e","f","g","h","i","j",Cars.CarModel.Benz,"m","Benzs",Properties.Resources.S580),
        //        // new Cars(3,"v", "v", "v", "v", "v", "v", "v", "v", "v", Cars.CarModel.Benz, "v","Benzb",Properties.Resources.S63AMG),
        //        //  new Cars(4,"v", "v", "v", "v", "v", "v", "v", "v", "v", Cars.CarModel.Benz, "v","Benzc",Properties.Resources.AMG_E_53_PHEV)


        //    };



        //private void cartCarDetail1_Load(object sender, EventArgs e)
        //{

        //}
        
        
    }
}






