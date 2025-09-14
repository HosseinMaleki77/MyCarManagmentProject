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
        Cars Benz1 = new Cars("a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a","Benz");
        Cars Benz2 = new Cars("b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "b", "Benz");
        Cars Benz3 = new Cars("c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "Benz");
        
        Dictionary<CarModel, List<Cars>> CarData = new Dictionary<CarModel, List<Cars>>();
        
        List<Cars> Benz = new List<Cars>();
        List<Cars> BMW = new List<Cars>();
        List<Cars> Ferrari = new List<Cars>();
        List<Cars> Lexus = new List<Cars>();
        List<Cars> Toyota = new List<Cars>();
        List<Cars> Audi = new List<Cars>();
        List<Cars> Ford = new List<Cars>();

        
        
        
        

        CarModel selectedModel;
        public enum CarModel 
        {
            Benz,
            BMW,
            Ferari
        }

        public UC_MyCarsDetails(CarModel carModel)
        {
            InitializeComponent();
            this.selectedModel = CarModel.Benz;
        }
      

        private void UC_MyCarsDetails_Load(object sender, EventArgs e)
        {
            LoadCarList(selectedModel);

            if(selectedModel == CarModel.Benz)
            {
                
            }
            else if (selectedModel == CarModel.BMW)
            {
                
            }
            else if(selectedModel == CarModel.Ferari)
            {

            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadCarList(CarModel model)
        {
            Benz.Add(Benz1);
            Benz.Add(Benz2);
            Benz.Add(Benz3);
            

        }
    }



}

