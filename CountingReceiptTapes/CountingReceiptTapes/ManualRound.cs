using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingReceiptTapes
{
   public  class ManualRound
    {
        public double SampleRound(double sum,int typ)
        {
            double roundSum = 0;
            int s = 0;
            if (typ == 0)   //Математическое округление 
            {
                int lastdigit = ((int)(sum * 1000) % 10);
                if (lastdigit < 5)
                {
                    s = (int)(sum * 100);
                    roundSum = (double)s / 100;
                }
                else
                {
                    s = (int)(sum * 100) + 1;
                    roundSum = (double)s / 100;
                }
            }
            if (typ == 1)   //Округление до 5 копеек
            {
                int lastdigit = ((int)(sum * 100) % 10);
                if (lastdigit <= 4)
                {
                    s = (int)(sum * 10);
                    roundSum = (double)s / 10;
                }
                if (lastdigit == 5)
                {
                    s = (int)(sum * 100);
                    roundSum = (double)s / 100;
                }
                if (lastdigit > 5)
                {
                    s = (int)(sum * 10) + 1;
                    roundSum = (double)s / 10;
                }
            }
            if (typ == 2)   //Округление до 10 копеек
            {
                int lastdigit = ((int)(sum * 100) % 10);
                if (lastdigit < 5)
                {
                    s = (int)(sum * 10);
                    roundSum = (double)s / 10;
                }
                else
                {
                    s = (int)(sum * 10) + 1;
                    roundSum = (double)s / 10;
                }
            }

            return roundSum;
        }
    }
}
