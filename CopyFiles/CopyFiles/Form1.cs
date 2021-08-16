using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyFiles
{
    public partial class Form1 : Form
    {
        public string copyFile;
        public Form1()
        {
            InitializeComponent();

            string path1 = Path.Combine("d:", "Dir1");
            string path2 = Path.Combine("d:", "Dir2");

            string[] files1 = Directory.GetFiles("d:\\Dir1\\"); 
            lbCopyFrom.Items.AddRange(files1);

            string[] files2 = Directory.GetFiles("d:\\Dir2\\");
            lbCopyFrom.Items.AddRange(files2);

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            string fileName = (string)lbCopyFrom.SelectedItem;
            string path = fileName;
            string pathTo = "d:\\Dir2\\" ;

            copyFile = path + " -> " + "pathTo";
            
            Form2 formCopy = new Form2();
            // formCopy.label1.Text = copyFile; 
             formCopy.Show();

            FileInfo file = new FileInfo(path);
            if(file.Exists)
            {
                file.CopyTo(pathTo, true);    
            }

            formCopy.Close();



        }
    }
}
