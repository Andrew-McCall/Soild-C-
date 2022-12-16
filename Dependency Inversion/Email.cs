using System;
using System.Collections.Generic;
using System.Text;

namespace SOILD.Dependency_Inversion
{
    class Email : INotifier
    {
        public void Alert(string weather)
        {
            if (weather.Equals("rainy"))
            {
                Console.WriteLine("It is rainy.");
            }
        }

    }
}
