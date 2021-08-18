using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static CopyFiles.Form1;

namespace CopyFiles
{
    public class CopyFile
    {
        public async void ProcessCopy(FileInfo file, string path,string name)
        {
            try
            {
                DataClass.flagEndCopy = false;
                await Task.Run(() => file.CopyTo(path + name, true));
                DataClass.flagEndCopy = true;

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
