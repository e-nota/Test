using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingReceiptTapes
{
    public class Receipt
    {
        public int Num { get; set; }
        public DateTime Dat { get; set; }
        public double Sum { get; set; }
        public List<ReceiptString> receiptString { get; set; }

    }
}
