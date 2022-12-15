using System;
using System.Collections.Generic;
using System.Text;

namespace SOILD.Single_Responsibility
{
    class Driver
    {
        public Car Car { get; set; }

        public Driver(Car car)
        {
            this.Car = car;
        }

        public void Drive(double miles)
        {
            this.Car.Mileage += miles;
        }

    }
}
