using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kuvvet_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi, kuvvet,sonuc;

            sayi = Convert.ToDouble(textBox1.Text);
            kuvvet = Convert.ToDouble(textBox2.Text);

            sonuc = Math.Pow(sayi, kuvvet);   //Math.Pow   Kuvvet Hesaplama
            label4.Text = sonuc.ToString();

            label3.Visible = true;
            label4.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi, karekök;

            sayi = Convert.ToDouble(textBox4.Text);

            karekök = Math.Sqrt(sayi); //Math.Sqrt  Karekök Hesaplama

            label5.Text = karekök.ToString();

            label6.Visible = true;
            label5.Visible = true;
        }
    }
}
