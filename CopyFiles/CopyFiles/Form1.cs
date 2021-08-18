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
        public Form2 formCopy;
        public List<CopyFile> cpf = new List<CopyFile>();
        public int i;
        public Form1()
        {
            InitializeComponent();
            i = 0;
            CreateListBoxes();
            formCopy = new Form2();
            formCopy.Owner = this;
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

                    if(!formCopy.Created)
                    {
                        formCopy = new Form2();
                    }

                    if (!formCopy.Visible)
                    {
                        formCopy.Show();
                    }
                    else
                    {
                        formCopy.Refresh();
                    }

                    cpf.Add(new CopyFile());
                    cpf[i].ProcessCopy(file, pathTo, fileName);
                    i++;

                   // formCopy.Close(); //
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
                 lbCopyFrom.Items.Add(file1);
            }

            DirectoryInfo dirInfo2 = new DirectoryInfo(path2);
            foreach (FileInfo file2 in dirInfo2.GetFiles("*.*"))
            {
                lbCopyTo.Items.Add(file2);
            }

          }
    }
}
