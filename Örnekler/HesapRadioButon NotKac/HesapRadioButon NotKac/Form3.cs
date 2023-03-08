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
    public partial class Form3 : Form
    {
        public Form3()
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
            if (not > 100)
            {
                MessageBox.Show("Notunuz 100 den büyük olamaz");
            }
            if (not >= 0 && not < 50)
            {
                label2.Text="Sınıfta Kaldınız";
            }
            if (not >= 50 && not < 70)
            {
                label2.Text="Belge Alamadınız";
            }
            if (not >= 70 && not <= 85)
            {
                label2.Text = "Teşekkür Belgesi Aldınız ";
            }
            if (not >= 85 && not <= 100)
            {
                label2.Text = "Takdir Belgesi Aldınız ";
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
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
