using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            string chain = textBox1.Text;
            while (chain.Contains("  "))
            {
                chain = chain.Replace("  ", " ");
            }
            string[] values = chain.Split(' ');
            foreach (string value in values)
            {
                if (value.Any(char.IsDigit)) listBox1.Items.Add(value);
            }
        }
    }
}
