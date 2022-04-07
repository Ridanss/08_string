using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P09
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void buttonCorrect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Lines.Count(); i++)
            {
                string chain = textBox1.Lines[i];
                
            }
        }
    }
}
