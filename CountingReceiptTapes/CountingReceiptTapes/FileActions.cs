using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingReceiptTapes
{
   public  class FileActions
    {
        public void ReceiptsWriteFile (List<Receipt> receipts)
        {
            var serializationReceipts = JsonConvert.SerializeObject(receipts);
            
            string path = Path.Combine("d:", "Tests", "Files");
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            using (FileStream fileStream = new FileStream($"{path}\\Receipts.txt", FileMode.Create))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(serializationReceipts);
                fileStream.Write(array, 0, array.Length);
            }

        }

        public List<Receipt> ReceiptsReadFile(string filename)
        {
            string path = Path.Combine("d:", "Tests", "Files");

            using (FileStream fileStream = new FileStream($"{path}\\{filename}", FileMode.Open))
            {

                byte[] array = new byte[fileStream.Length];
                fileStream.Read(array, 0, array.Length);
                string text = System.Text.Encoding.Default.GetString(array);

                List<Receipt> receipts = JsonConvert.DeserializeObject<List<Receipt>> (text);
                return receipts;

            }
         }
    }
}
