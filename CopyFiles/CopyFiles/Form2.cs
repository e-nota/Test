using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CopyFiles.Form1;

namespace CopyFiles
{
    public partial class Form2 : Form
    {
        //public string str = "_1";
        public Form2()
        {
            InitializeComponent();

            label1.Text = DataClass.Text;
        }
    }
}
