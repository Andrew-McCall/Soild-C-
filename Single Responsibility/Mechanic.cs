using System;
using System.Collections.Generic;
using System.Text;

namespace SOILD.Single_Responsibility
{
    class Mechanic
    {

        public double Repair(Car car)
        {
            return car.Mileage * 0.002;
        }
        
    }
}
