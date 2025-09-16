using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCarManagmentProject.Controls
{
    public partial class UC_MyCarsDetails : UserControl
    {
        List<Cars> allCars;
        Cars.CarModel selectedModel;

        public UC_MyCarsDetails(Cars.CarModel carModel)
        {
            InitializeComponent();
            this.selectedModel = carModel;
        }
        

        private void UC_MyCarsDetails_Load(object sender, EventArgs e)
        {
            LoadCarList();

            if (selectedModel == Cars.CarModel.Benz)
            {
                List<Cars> benzcars = new List<Cars>();

                foreach (var car in allCars)
                {
                    if (car.Model == Cars.CarModel.Benz)
                    {
                        benzcars.Add(car);
                    }
                }
                panel1.Controls.Clear();

                int y = 10; // فاصله اولیه از بالا
                foreach (var car in benzcars)
                {
                    CartCarDetail detail = new CartCarDetail();
                    detail.SelectedCar = car;
                    detail.SetDesigner();

                    // محل قرارگیری کنترل
                    detail.Location = new Point(10, y);
                    detail.Width = panel1.Width - 30;
                    detail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                    panel1.Controls.Add(detail);

                    y += detail.Height + 10; // فاصله بین کارت‌ها
                }
            }

        



        
            else if (selectedModel == Cars.CarModel.BMW)
            {
                
            }
            else if(selectedModel == Cars.CarModel.Ferari)
            {

            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadCarList()
        {
            allCars = new List<Cars>()
            {
                //new Cars(Cars.CarModel.Ferari,"F1_1"),
                //new Cars(Cars.CarModel.Benz,"GClass_1"),
                //new Cars(Cars.CarModel.BMW,"X4_1"),
                //new Cars(Cars.CarModel.Ferari,"F1_2"),
                //new Cars(Cars.CarModel.Benz,"GClass_2"),
                //new Cars(Cars.CarModel.BMW,"X4_2"),
                //new Cars(Cars.CarModel.Ferari,"F1_3"),
                //new Cars(Cars.CarModel.Benz,"GClass_3"),
                new Cars("a","b","c","d","e","f","g","h","i","j",Cars.CarModel.Benz,"m","Benzs"),
                 new Cars("b", "b", "b", "b", "b", "b", "b", "b", "b", "b", Cars.CarModel.Benz, "b","Benze"),
                 new Cars("v", "v", "v", "v", "v", "v", "v", "v", "v", "v", Cars.CarModel.Benz, "v","Benzb"),
                  new Cars("v", "v", "v", "v", "v", "v", "v", "v", "v", "v", Cars.CarModel.Benz, "v","Benzc")


            };

        }

        private void cartCarDetail1_Load(object sender, EventArgs e)
        {

        }
    }



}

