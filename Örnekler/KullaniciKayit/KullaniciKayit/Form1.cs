using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KullaniciKayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Merhaba";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Deneme";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
        }
    }
}
