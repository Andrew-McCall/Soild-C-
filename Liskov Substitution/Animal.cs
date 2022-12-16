using System;
using System.Collections.Generic;
using System.Text;

namespace SOILD.Liskov_Substitution
{
    class Animal
    {
        public void LearnToFly(FlyingBird bird)
        {
           bird.Fly();
        }

    }
}
