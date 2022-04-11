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
            string chain = string.Empty, newchain = string.Empty;
            for (int i = 0; i < textBox1.Lines.Count(); i++)
            { 
                chain = textBox1.Lines[i];
                if (chain != string.Empty) {
                    chain = chain.Trim();
                    if (checkBoxUpper.Checked)
                    {
                        newchain += char.ToUpper(chain[0]).ToString();
                        chain = chain.Remove(0, 1);
                        newchain += chain;
                    }
                    if (checkBoxDot.Checked)
                    {
                        if (chain != string.Empty)
                        {
                            if (chain[chain.Length - 1] != '.') newchain += '.';
                        }
                    }
                    newchain += Environment.NewLine;
                }
            }
            textBox1.Text = newchain;
        }
    }
}
