using System;
using System.Collections.Generic;
using System.Text;

namespace SOILD.Open_Closed
{
    class Triangle : IShape
    {

        public double Height { set; get; }
        public double Width { set; get; }

        public Triangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double CalculateArea()
        {
            return this.Height * this.Width * 0.5;
        }

    }
}
