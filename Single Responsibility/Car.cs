using System;
using System.Collections.Generic;
using System.Text;

namespace SOILD.Single_Responsibility
{
    class Car
    {

        public string Colour { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }

        public Car(string colour, string model, double mileage) {
            this.Colour = colour;
            this.Model = model;
            this.Mileage = mileage;
        }

    }

}
