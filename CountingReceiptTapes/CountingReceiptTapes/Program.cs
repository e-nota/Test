using System;
using System.Collections.Generic;

namespace CountingReceiptTapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Receipt> receipts = new List<Receipt>();
          //  Random rndReceipts = new Random();
            int countReceipts = 4;
            for (int i = 0; i < countReceipts; i++)
            {
                Random gen = new Random();

                Receipt receipt = new Receipt();
                receipt.Num = i + 1;
                receipt.Dat = DateTime.Today.AddDays(-gen.Next(7));
                
                // Create Receipt strings
                List <ReceiptString> receiptStrings = new List<ReceiptString>();   //List of receipts strings
                Random rnd = new Random();
                int countStrings = rnd.Next(1, 10);
                double sumReceipt = 0;
                for (int j = 0; j < countStrings; j++)
                {
                    ReceiptString receiptString = new ReceiptString();
                    receiptString.Num = j + 1;
                    RandomExtensions rndExt = new RandomExtensions();
                    receiptString.Price = rndExt.GetRandomDouble(5, 10000); 
                    receiptString.Quantity = rnd.Next(1, 20);
                    ManualRound round = new ManualRound();
                    receiptString.Sum = round.SampleRound((receiptString.Quantity * receiptString.Price), 0); 
                    receiptStrings.Add(receiptString);

                    sumReceipt += receiptString.Quantity * receiptString.Price; //Сумма чека
                }
                //--- Проверка полученного --- //
                Console.WriteLine("№  Price  Qnt  Sum");
                foreach (var recs in receiptStrings)
                {
                    Console.WriteLine($"{recs.Num} {recs.Price}   {recs.Quantity}  {recs.Sum} \n");
                }
                //----------------------
                ManualRound round1 = new ManualRound();
                receipt.Sum = round1.SampleRound(sumReceipt, 1); // округление до 5 коп
                receipt.receiptString = receiptStrings;
                receipts.Add(receipt);
            }
            //--- Проверка полученного --- //
            Console.WriteLine("№ Date       Sum");
            foreach (var rec in receipts)
            {
                Console.WriteLine($"{rec.Num} {rec.Dat.ToString("d")}  {rec.Sum} \n");
            }
            //----------------------



        }
    }
}
