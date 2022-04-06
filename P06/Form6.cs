using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string chain = textBox1.Text;
            chain = chain.Trim();
            char prevVal = chain[1];
            int i = 2;
            while (i < chain.Length)
            {
                if (chain[i] == ' ' && prevVal == ' ')
                {
                    chain = chain.Remove(i, 1);
                }
                else
                {
                    prevVal = chain[i];
                    i++;
                }
            }
            textBox2.Text = chain;
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            string chain = textBox1.Text;
            chain = chain.Trim();
            while (chain.Contains("  "))
            {
                chain = chain.Replace("  ", " ");
            }
            textBox2.Text = chain;
        }
    }
}
