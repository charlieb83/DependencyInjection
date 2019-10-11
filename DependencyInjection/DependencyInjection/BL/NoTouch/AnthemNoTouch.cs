using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.BL.NoTouch
{
    public class AnthemNoTouch : IBaseNoTouch
    {

        public void GetConceptClaims()
        {
            Console.WriteLine("Getting Concept Claims...");
            Console.WriteLine("This is Anthem, also get Business Areas...");
        }

        public void LoadNoTouchClaims()
        {
            Console.WriteLine("Get Legacy system No Touch Claims...");
            Console.WriteLine("This is Anthem, also check Business Areas in Legacy system...");
        }

    }
}
