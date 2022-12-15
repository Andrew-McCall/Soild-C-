using System;
using System.Collections.Generic;
using System.Text;

namespace SOILD.Open_Closed.Bad
{
    class Rectangle
    {

        public double Length { set; get; }

        public double Width { set; get; }

        public Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }

    }
}
