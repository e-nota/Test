using System;
using System.Collections.Generic;

namespace CountingReceiptTapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Receipt> receipts = new List<Receipt>(); //Receipt Tape
          //  Random rndReceipts = new Random();
            int countReceipts = 10;  //100;
            ManualRound round = new ManualRound();
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
                    receiptString.Sum = round.SampleRound((receiptString.Quantity * receiptString.Price), 0); 
                    receiptStrings.Add(receiptString);

                    sumReceipt += receiptString.Quantity * receiptString.Price; //Сумма чека
                }
                //---------------------
                Console.WriteLine("№  Price  Qnt  Sum");
                foreach (var recs in receiptStrings)
                {
                    Console.WriteLine($"{recs.Num} {recs.Price}   {recs.Quantity}  {recs.Sum} \n");
                }
                //----------------------
                receipt.Sum = round.SampleRound(sumReceipt, 1); // округление до 5 коп
                receipt.receiptString = receiptStrings;
                receipts.Add(receipt);
            }
            //----------------------
            double itogo = 0;
            Dictionary<DateTime, double> result = new Dictionary<DateTime, double>();

            Console.WriteLine("№ Date       Sum");
            foreach (var rec in receipts)
            {
                Console.WriteLine($"{rec.Num} {rec.Dat.ToString("d")}  {rec.Sum} \n");
                
                itogo += round.SampleRound(rec.Sum, 0);

                if (!result.ContainsKey(rec.Dat))
                {
                    result.Add(rec.Dat, rec.Sum);
                }
                else
                {
                    result[rec.Dat] = result[rec.Dat] + rec.Sum;
                }
            }
            itogo = round.SampleRound(itogo, 0);
            
            foreach (var r in result)
            {
                Console.WriteLine($"{r.Key.ToString("d")} - {r.Value}");
            }
            Console.WriteLine($"Itogo: {itogo} \n");
            //----------------------

            FileActions fileActions = new FileActions();
            fileActions.ReceiptsWriteFile(receipts);
            List<Receipt> readReceipts = fileActions.ReceiptsReadFile("Receipts.txt");
            
            Console.WriteLine("Receipts from file:");
            itogo = 0;
            foreach (var rec in readReceipts)
            {
                Console.WriteLine($"{rec.Num} {rec.Dat.ToString("d")}  {rec.Sum} \n");

                itogo += round.SampleRound(rec.Sum, 0);
            }
            itogo = round.SampleRound(itogo, 0);
            Console.WriteLine($"Itogo: {itogo} \n");
            // ---------------
    


        }
    }
}
