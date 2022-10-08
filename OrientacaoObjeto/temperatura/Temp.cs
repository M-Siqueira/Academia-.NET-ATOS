using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatura
{
    internal class Temp
    {

        private double celsius = 0;

        public double getCelsius(double celsius)
        {
            return (((celsius * 9) / 5) + 32);
        }

        public void setCelsius(double fh)
        {
            double b  = ((fh * 9) / 5) + 32;

            
        }


    }
}
