using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void buttonCode_Click(object sender, EventArgs e)
        {
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //0a 1b 2c 3d 4e 5f 6g 7h 8i 9j 10k 11l 12m 13n 14o 15p 16q 17r 18s 19t 20u 21v 22w 23x 24y 25z
            string chain = textBox1.Text;
            string newchain = string.Empty;
            foreach (char value in chain)
            {
                if (value == ' ') newchain += "/ ";
                else
                {
                    for (int i = 0; i < alphabet.Length; i++)
                    {
                        if (value == alphabet[i])
                        {
                            newchain += morse[i] + " ";
                            break;
                        }
                    }
                }
            }
            textBox1.Text = newchain;
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //0a 1b 2c 3d 4e 5f 6g 7h 8i 9j 10k 11l 12m 13n 14o 15p 16q 17r 18s 19t 20u 21v 22w 23x 24y 25z
            string[] chain = textBox1.Text.Split(' ');
            string newchain = string.Empty;
            foreach (string value in chain)
            {
                if (value == "/") newchain += " ";
                else
                {
                    for (int i = 0; i < morse.Length; i++)
                    {
                        if (value == morse[i])
                        {
                            newchain += alphabet[i];
                            break;
                        }
                    }
                }
            }
            textBox1.Text = newchain;
        }
    }
}
