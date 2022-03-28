using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int counter = 0;
        int posun = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            string chain = textBox1.Text;
            string newchain = string.Empty;
            int podmMale = 'z' - posun;
            int podmVelke = 'Z' - posun;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                char value = chain[i];
                if (value >= 'A' && value <= 'Z')
                {
                    int ascii;
                    if (value > podmVelke) ascii = value - 26 + posun;
                    else ascii = value + posun;
                    newchain += (char)ascii;
                }
                else if (value >= 'a' && value <= 'z')
                {
                    int ascii;
                    if (value > podmMale) ascii = value - 26 + posun;
                    else ascii = value + posun;
                    newchain += (char)ascii;
                }
                else newchain += value;
            }
            textBox1.Text = newchain;
        }

        private void buttonPosun_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text,out posun))
            {
                posun = Convert.ToInt32(textBox2.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string chain = textBox1.Text;
            string newchain = string.Empty;
            int podmMale = 'a' + posun;
            int podmVelke = 'A' + posun;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                char value = chain[i];
                if (value >= 'A' && value <= 'Z')
                {
                    int ascii;
                    if (value < podmVelke) ascii = value + 26 - (counter * posun) + (((counter * posun) / 26) * 26);
                    else ascii = value - counter * posun + (((counter * posun) / 26) * 26);
                    newchain += (char)ascii;
                }
                else if (value >= 'a' && value <= 'z')
                {
                    int ascii;
                    if (value < podmMale) ascii = value + 26 - counter * posun + (((counter * posun) / 26) * 26);
                    else ascii = value - counter * posun + (((counter * posun) / 26) * 26);
                    newchain += (char)ascii;
                }
                else newchain += value;
            }
            textBox1.Text = newchain;
            counter = 0;
        }
    }
}
