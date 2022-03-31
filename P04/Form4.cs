using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            string chain = textBoxInput.Text;
            int i = 0;
            while (i < chain.Length)
            {
                if (chain[i] >= 'A' && chain[i] <= 'Z')
                {
                    chain = chain.Remove(i, 1);
                }
                else i++;
            }
            textBoxInput.Text = chain;
        }

        private void buttonRemoveUnwanted_Click(object sender, EventArgs e)
        {
            string chain = textBoxInput.Text;
            chain = chain.Replace("*", "");
            textBoxOutput.Text = chain;
        }
    }
}
