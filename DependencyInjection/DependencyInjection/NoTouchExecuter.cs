using DependencyInjection.BL.NoTouch;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class NoTouchExecuter
    {
        private IBaseNoTouch _baseNoTouch;

        
        public NoTouchExecuter(IBaseNoTouch baseNoTouch)
        {
            _baseNoTouch = baseNoTouch;
        }

        
        public void RunNotouch()
        {
            _baseNoTouch.GetConceptClaims();
            _baseNoTouch.LoadNoTouchClaims();


        }        
        
    }
}
