using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            string chain = textBox1.Text;
            string[] words = chain.Split(' ');
            int count = words.Length;
            labelPocetSlov1.Text = ("počet slov: " + count);
        }

        private void buttonExecute2_Click(object sender, EventArgs e)
        {
            string chain = textBox1.Text;
            chain = chain.Trim();
            string[] words = chain.Split(' ');
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != string.Empty) count++;
            }
            labelPocetSlov2.Text = ("počet slov: " + count);
        }
    }
}
