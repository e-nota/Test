using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingReceiptTapes
{
    public class RandomExtensions
    {
        public double GetRandomDouble(int  minValue, int maxValue)
        {
            Random random = new Random();
            //return random.NextDouble() * (maxValue - minValue) + minValue;
            
            double result = (double)(random.Next(minValue, maxValue)) / 100;
            return result;
        }
              

    }
}
