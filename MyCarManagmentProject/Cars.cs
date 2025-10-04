using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarManagmentProject
{
    public class Cars
    {
        public enum CarModel
        {
            Benz,
            BMW,
            Ferari,
            Audi,
            Toyota,
            Lexus,
            Ford
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Fuel { get; set; }
        public string Engine_Details { get; set; }
        public string MaxPower { get; set; }
        public string MaxTorque { get; set; }
        public string Transmission { get; set; }
        public string Acceleration { get; set; }
        public string TopSpeed { get; set; }
        public string DoorCount { get; set; }
        public int Price { get; set; }
        public int CarCount { get; set; }
        public bool MustSave { get; set; }
        public CarModel Model { get; set; }

        //public string Factory { get; set; }

        public Image CarImage { get; set; }




        //public Cars(int id,string fuel ,string engine_details,string maxpower, string maxtorque, string transmission, string accleration,string topspeed,string doorcount, string price, CarModel model, string factory,string name, Image image)
        //{
        //    Id=id;
        //    //this.Model = model;
        //    Fuel = fuel;
        //    Engine_Details = engine_details;
        //    MaxPower = maxpower;
        //    MaxTorque = maxtorque;
        //    Transmission = transmission;
        //    Acceleration = accleration;
        //    TopSpeed = topspeed;
        //    DoorCount = topspeed;
        //    Price = price;
        //    Factory = factory;
        //    Name = name;
        //    CarImage = image;

        //}


    }
}
