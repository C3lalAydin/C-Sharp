using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HesapMakinesi2_Double
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2;

            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);

            LblToplam.Text = (sayi1 + sayi2).ToString();
            LblFark.Text = (sayi1 - sayi2).ToString();
            LblCarpim.Text = (sayi1 * sayi2).ToString();
            LblBolum.Text = (sayi1 / sayi2).ToString();

            label3.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

            LblToplam.Visible = true;
            LblFark.Visible = true;
            LblCarpim.Visible = true;
            LblBolum.Visible = true;

        }
    }
}
