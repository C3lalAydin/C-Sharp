using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MatematikHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int birkenar;
            int alan, cevre;
            

            birkenar = Convert.ToInt32(textBox1.Text);
            
            alan = birkenar * birkenar;
            cevre = birkenar * 4;
            

            label4.Text = alan.ToString();
            label5.Text = cevre.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
            button3.Visible = false;
            button4.Visible = true;
            label2.Text = "Bir Kenarı Girin:";
            textBox2.Visible = false;
            label1.Text = "KARE";
            panel1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button3.Visible = true;
            textBox1.Clear();
            textBox2.Clear();
            label1.Text = "DİKDÖRTGEN";
            label2.Text = "Uzun Kenar:";
            label7.Visible = true;
            textBox2.Visible = true;
            panel1.Visible = true;

  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dikalan, dikcevre;
            int uzun, kisa;

            uzun = Convert.ToInt32(textBox2.Text);
            kisa = Convert.ToInt32(textBox1.Text);

            dikalan = kisa * uzun;
            dikcevre = (2 * uzun) + (2 * kisa);

            label4.Text = dikalan.ToString();
            label5.Text = dikcevre.ToString();
        }
    }
}
