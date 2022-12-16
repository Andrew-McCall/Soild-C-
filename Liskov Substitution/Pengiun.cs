using System;
using System.Collections.Generic;
using System.Text;

namespace SOILD.Liskov_Substitution
{
    class Pengiun : IFlightlessBird
    {
        public void Flap()
        {
            Console.WriteLine("Flap Flap");
        }

    }
}
