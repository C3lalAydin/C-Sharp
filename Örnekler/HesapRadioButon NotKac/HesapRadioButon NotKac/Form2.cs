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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int not;
        private void button1_Click(object sender, EventArgs e)
        {
            not = Convert.ToInt32(textBox1.Text);
            if (not < 0)
            {
                MessageBox.Show("Notunuz 0 dan küçük olamaz");
            }
            if (not>100)
            {
                MessageBox.Show("Notunuz 100 den Büyük olmamaz");
            }
            else if (not<=25)
            {
                label2.Text="Notunuz: 1";
            }
            else if (not<=50)
            {
                label2.Text="Notunuz: 2";
            }
            else if (not<=70)
            {
                label2.Text="Notunuz: 3";
            }
            else if (not<=85)
            {
                label2.Text="Notunuz: 4";
            }
            else if (not<=100)
            {
                label2.Text="Notunuz: 5";
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
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
