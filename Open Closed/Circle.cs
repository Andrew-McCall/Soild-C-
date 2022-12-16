using System;
using System.Collections.Generic;
using System.Text;

namespace SOILD.Open_Closed.Bad
{
    class Circle : IShape
    {
        public double Radius { set; get; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double CalculateArea()
        {
            return this.Radius * this.Radius * Math.PI;
        }
    }
}
