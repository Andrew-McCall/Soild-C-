using System;
using System.Collections.Generic;
using System.Text;

namespace SOILD.Liskov_Substitution
{
    class Owl : Bird
    {
        public override void Fly()
        {
            this.Altitude += 1000;
        }
    }
}
