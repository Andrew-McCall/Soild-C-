using System;
using System.Collections.Generic;
using System.Text;

namespace SOILD.Liskov_Substitution
{
    class Owl : FlyingBird
    {
        public override void Fly()
        {
            this.Altitude += 1000;
        }
    }
}
