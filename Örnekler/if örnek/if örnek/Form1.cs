using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace if_örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte skor1, skor2;
        Random rand = new Random();
        byte a, b;
        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToByte(rand.Next(1, 4));
            b = Convert.ToByte(rand.Next(1, 4));
            
            skor1 = a;
            skor2 = b;

            label2.Text = "Skor1:   " + a.ToString();
            label3.Text = "Skor2:   " + b.ToString();
            if (skor1 > skor2)
            {
                MessageBox.Show("1. Takım Kazandı");
            }
            if (skor1<skor2)
            {
                MessageBox.Show("2. Takım Kazandı");
            }
            if (skor1 == skor2)
            {
                MessageBox.Show("Skorlar Eşit");
            }
            
        }
        byte yas;
        private void button2_Click(object sender, EventArgs e)
        {
            yas = Convert.ToByte(textBox1.Text);
            if (yas > 17)
            {
                MessageBox.Show("Ehliyet Alabilirsiniz");
            }
            if (yas<=17)
            {
                MessageBox.Show("Ehliyet Alamazsınız");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
