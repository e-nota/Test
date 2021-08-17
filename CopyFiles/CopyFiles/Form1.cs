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
        public string copyFiles;
        public Form1()
        {
            InitializeComponent();

             CreateListBoxes();
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            FileInfo file = (FileInfo)lbCopyFrom.SelectedItem;

            string path = "d:\\Dir1\\";
            string pathTo = "d:\\Dir2\\" ;

            try
            {
                if (file.Exists)
                { 
                
                    string fileName = file.Name;
                    copyFiles += path + fileName + " -> " + pathTo + fileName + "\n";
                    DataClass.Text = copyFiles;
                  
                    Form2 formCopy = new Form2();
                    formCopy.Owner = this;
                    formCopy.Show();

                    file.CopyTo(pathTo + fileName, true);

                  //  formCopy.Close();
                }

                
                CreateListBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void CreateListBoxes()
        {
            string path1 = "d:\\Dir1\\"; 
            string path2 = "d:\\Dir2\\"; 

            lbCopyFrom.Items.Clear();
            lbCopyTo.Items.Clear();

            DirectoryInfo dirInfo1 = new DirectoryInfo(path1);
            foreach (FileInfo file1 in dirInfo1.GetFiles("*.*"))
            {
                //File.Copy(file.FullName, path1 + "\\" + file.Name, true);
                lbCopyFrom.Items.Add(file1);
            }

            DirectoryInfo dirInfo2 = new DirectoryInfo(path2);
            foreach (FileInfo file2 in dirInfo2.GetFiles("*.*"))
            {
                //File.Copy(file.FullName, path1 + "\\" + file.Name, true);
                lbCopyTo.Items.Add(file2);
            }

            // string[] files1 = Directory.GetFiles("d:\\Dir1\\"); 
            // lbCopyFrom.Items.AddRange(files1);
            // string[] files2 = Directory.GetFiles("d:\\Dir2\\");
            // lbCopyFrom.Items.AddRange(files2);
        }
    }
}
