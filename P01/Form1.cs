using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            string samohlasky = "aeiouyáéěíóúůý";
            int samohlasek = 0;
            string souhlasky = "bcčdďfghjklmnpqrřsštťvwxzž";
            int souhlasek = 0;
            value = value.ToLower();
            foreach (char znak in value)
            {
                if (samohlasky.Contains(znak)) samohlasek++;
                else if (souhlasky.Contains(znak)) souhlasek++;
            }
            int nepismenych = value.Length - (souhlasek + samohlasek);
            labelZnaky.Text = string.Format("Znaky:\n{0} samohlásek\n{1} souhlásek\n{2} ostatních znaků", samohlasek, souhlasek, nepismenych);
        }
    }
}
