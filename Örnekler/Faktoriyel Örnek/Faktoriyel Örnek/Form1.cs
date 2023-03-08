using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Faktoriyel_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = 1;
            int sonuc = 1;
            int aa=Convert.ToInt32(textBox1.Text);
            for (sayi = 1; sayi<=aa; sayi++)
            {
                sonuc = sonuc * sayi;
                label2.Text = textBox1.Text+" Sayısının Faktoriyeli: "+sonuc.ToString();
                label2.Visible = true;


            }
            listBox1.Items.Add(sonuc.ToString());
        }
    }
}
