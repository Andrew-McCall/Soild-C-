using System;
using System.Collections.Generic;
using System.Text;

namespace SOILD.Open_Closed.Bad
{
    class AreaCalculator
    {
        public double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }

    }
}
