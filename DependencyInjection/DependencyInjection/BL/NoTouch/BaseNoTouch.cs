using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.BL.NoTouch
{
    public class BaseNoTouch : IBaseNoTouch
    {

        public void GetConceptClaims()
        {
            Console.WriteLine("Getting Concept Claims...");
        }

        public void LoadNoTouchClaims()
        {
            Console.WriteLine("Get Legacy system No Touch Claims...");
        }

    }
}
