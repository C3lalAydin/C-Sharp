using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HesapRadioButon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi1, sayi2, toplam, carpma, cikarma, bölme, mod;
        private void button1_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            toplam = sayi1 + sayi2;
            carpma = sayi1 * sayi2;
            cikarma = sayi1 - sayi2;
            bölme = sayi1 / sayi2;
            mod = sayi1 % sayi2;

            if (radioButton1.Checked == true)
            {
                label3.Text = "Sonuç: " + toplam.ToString();
            }

            if (radioButton2.Checked == true)
            {
                label3.Text = "Sonuç: " + carpma.ToString();
            }
            if (radioButton3.Checked == true)
            {
                label3.Text = "Sonuç: " + bölme.ToString();
            }
            if (radioButton4.Checked == true)
            {
                label3.Text = "Sonuç: " + cikarma.ToString();
            }
            if (radioButton5.Checked == true)
            {
                label3.Text = "Sonuç: " + mod.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
