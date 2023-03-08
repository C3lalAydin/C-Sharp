using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SaatDakikaHesaplamaModAlma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int saat, dakika,sayi;

            sayi=Convert.ToInt32(textBox1.Text);

            saat = sayi / 60;
            dakika = sayi % 60;

            label2.Text = saat.ToString();
            label3.Text = dakika.ToString();

            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
        }
    }
}
