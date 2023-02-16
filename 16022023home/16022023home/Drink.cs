using System;
using System.Collections.Generic;
using System.Text;

namespace _16022023home
{
    internal class Drink:Product
    {

        protected double _percent = 40;

        public double AlchocolPercent
        {
            get 
            {
                return _percent;
            }
            set
            {
                if (_percent <= 40)
                    _percent= value;
            }
        } 

    }
}
