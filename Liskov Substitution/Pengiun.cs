using System;
using System.Collections.Generic;
using System.Text;

namespace SOILD.Liskov_Substitution
{
    class Pengiun : Bird
    {
        public override void Fly()
        {
            throw new NotImplementedException();
        }

    }
}
