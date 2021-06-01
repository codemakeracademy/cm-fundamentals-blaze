using System;
using System.Collections.Generic;
using System.Text;

namespace CM.Fundamentals
{
    public class Car
    {
        public string Make { set; get; }
        public string Model { set; get; }
        public int Year { set; get; }
        public int Odometer { set; get; }
        public VehicleClassification Type { get; set; }

        public Car()
        {
           
        }
    }

    public class Sedan : Car
    {
        public Sedan()
        {
            Type = VehicleClassification.Sedan;  
        }
    }

    public class Truck : Car
    {
     
        public Truck()
        {
            Type = VehicleClassification.Truck;
        }
    }

    public enum VehicleClassification
    {
        Motorcycle,
        Sedan, // 2
        Truck // 3
    }
}
