using System;
using System.Collections.Generic;
using System.Text;

namespace SOILD.Dependency_Inversion
{
    class WeatherTracker
    {
        public string Conditions { set; get;}

        // ArrayList Of INotifers
        // On the set of conditions - loops through list and all

        public void Notify(INotifier device)
        {
            device.Alert(this.Conditions);
        }

    }
}
