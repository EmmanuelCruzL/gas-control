using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gas_control
{
    class randomNumber
    {
        Random random = new Random();

        public String getNumRandom(int i,int f)
        {
            return   random.Next(i,f).ToString();
        }

        public double getNumDoubleRandom(double i,double f)
        {
            return (random.NextDouble() * (f - i) + i);
        }
    }
}
