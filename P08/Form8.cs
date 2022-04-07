using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P08
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            labelCheckedFinish.Text = "Výsledky:";
            labelEdit.Text = "Úprava: " + textBox1.Text;
            if (radioButton12px.Checked) labelEdit.Font = new Font(labelEdit.Font.Name, 12);
            else labelEdit.Font = new Font(labelEdit.Font.Name, 20);

            if (radioButtonBlack.Checked) labelEdit.ForeColor = Color.Black;
            else labelEdit.ForeColor = Color.Red;

            string[] chain = textBox1.Text.Split(' ');
            if (checkBoxCount.Checked)
            {
                int count = chain.Length;
                if (chain[0] == string.Empty) count = 0;
                labelCheckedFinish.Text += "\nPočet slov je " + count;
            }
            if (checkBoxLongest.Checked)
            {
                string longest = string.Empty;
                int length = 0;
                foreach (string value in chain)
                {
                    if (value.Length > length)
                    {
                        length = value.Length;
                        longest = value;
                    }
                }
                labelCheckedFinish.Text += "\nNejdelší slovo je: " + longest;
            }
        }
    }
}
