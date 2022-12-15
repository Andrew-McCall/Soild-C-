using System;
using System.Collections.Generic;
using System.Text;

namespace SOILD.Dependency_Inversion
{
    class Phone
    {
        public void Alert(string weather)
        {
            if (weather.Equals("sunny"))
            {
                Console.WriteLine("It is sunny.");
            }
        }

    }
}
