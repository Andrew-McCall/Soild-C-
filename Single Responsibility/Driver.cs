using System;
using System.Collections.Generic;
using System.Text;

namespace SOILD.Single_Responsibility
{
    class Driver
    {

        public void Drive(double miles, Car car)
        {
            car.Mileage += miles;
        }

    }
}
