using System;
using System.Collections.Generic;
using System.Text;

namespace SOILD.Liskov_Substitution.Bad
{
    class Animal
    {
        public static void LearnToFly(Bird bird)
        {
            if (bird is Owl)
            {
                bird.Fly();
            }
        }
    }
}
