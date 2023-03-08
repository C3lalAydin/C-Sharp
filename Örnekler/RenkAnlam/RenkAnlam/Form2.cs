using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RenkAnlam
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mavi")
            {
                label4.Text=textBox1.Text+" "+comboBox1.Text+" Rengi"+" sonsuzluğu ve özgürlüğü ifade eder.";
                label4.Visible = true;
                button2.BackColor = Color.Blue;
                button2.Visible = true;
            }
           if (comboBox1.Text=="Beyaz")
            {
                label4.Text=textBox1.Text+" "+comboBox1.Text+" Rengi"+" Saflığı, temizliği ve istikrarı ifade eder.";   
                label4.Visible = true;
                button2.BackColor = Color.White;
                button2.Visible = true;
            }
           if (comboBox1.Text == "Siyah")
           {
               label4.Text = textBox1.Text + " " + comboBox1.Text + " Rengi" + " Gücü, tutkuyu ve çoğu ülkede matemi temsil eder.";
               label4.Visible = true;
               button2.BackColor = Color.Black;
               button2.Visible = true;
           }
           if (comboBox1.Text == "Kırmızı")
           {
               label4.Text = textBox1.Text + " " + comboBox1.Text + " Rengi" + " Canlılık ve dinamizmin rengidir. Ataklık, azim ve kararlılığı ifade eder.";
               label4.Visible = true;
               button2.BackColor = Color.Red;
               button2.Visible = true;
           }
           if (comboBox1.Text == "Sarı")
           {
               label4.Text = textBox1.Text + " " + comboBox1.Text + " Rengi" + " En parlak ve dikkat çekici renktir. Neşe, zeka, incelik ve pratikliği ifade eder.";
               label4.Visible = true;
               button2.BackColor = Color.Yellow;
               button2.Visible = true;
           }
           if (comboBox1.Text == "Yeşil")
           {
               label4.Text = textBox1.Text + " " + comboBox1.Text + " Rengi" + " Doğanın ve huzurun rengidir.";
               label4.Visible = true;
               button2.BackColor = Color.Green;
               button2.Visible = true;
           }

        }
    }
}
