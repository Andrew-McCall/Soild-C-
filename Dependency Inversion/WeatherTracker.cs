using System;
using System.Collections.Generic;
using System.Text;

namespace SOILD.Dependency_Inversion
{
    class WeatherTracker
    {
        public string Conditions { set; get;}

        public void CreatePhoneAlert(Phone phone)
        {
            phone.Alert(Conditions);
        }

        public void CreateEmailAlert(Email email)
        {
            email.Alert(Conditions);
        }

    }
}
