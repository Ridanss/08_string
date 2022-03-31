using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            string chain = textBoxInput.Text;
            string newchain = chain;
            int takeit;
            for (int i = 0; i < textBoxInput.Text.Length; i++)
            {
                if (chain[i] >= '0' && chain[i] <= '9')
                {
                    takeit = textBoxInput.Text.Length - (Convert.ToInt32(chain[i]) - 48);
                    if (takeit <= 0) newchain = string.Empty;
                    else newchain = newchain.Remove(takeit, textBoxInput.Text.Length - takeit);   
                    break;
                }
            }
            textBoxOutput.Text = newchain;
        }
    }
}
