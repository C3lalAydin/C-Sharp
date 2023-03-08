using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZarAtmaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rstgl = new Random();
        int toplampuanben = 0;
        int toplampuanpc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            int a = rstgl.Next(1, 7);
            int b = rstgl.Next(1, 7);
            

            label4.Text = a.ToString();
            label5.Text = b.ToString();

            if (a == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar1.png";
            }
            if (a == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar2.png";
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar3.png";
            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar4.png";
            }
            if (a == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar5.png";
            }
            if (a == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar6.png";
            }


            if (b == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar1.png";
            }
            if (b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar2.png";
            }
            if (b == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar3.png";
            }
            if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar4.png";
            }
            if (b == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar5.png";
            }
            if (b == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar6.png";
            }



            toplampuanben += a + b;
            label6.Text = toplampuanben.ToString();
            label13.Text = toplampuanben.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            int c = rstgl.Next(1, 7);
            int d = rstgl.Next(1, 7);

            if (toplampuanben >= 100 && toplampuanben > toplampuanpc)
            {
                MessageBox.Show("Tebrikler 1. Oyuncu Kazandı", "KAZANAN");
                label9.Text = "0";
                label11.Text = "0";
                label7.Text = "0";
                label6.Text = "0";
                toplampuanben = 0;
                toplampuanpc = 0;
            }
            if (toplampuanpc >= 100 && toplampuanpc > toplampuanben)
            {
                MessageBox.Show("Tebrikler Pc Oyuncu Kazandı Kaybettiniz", "KAZANAN");
                label9.Text = "0";
                label11.Text = "0";
                label7.Text = "0";
                label6.Text = "0";

            }

            label9.Text = c.ToString();
            label11.Text = d.ToString();

            if (c == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar1.png";
            }
            if (c == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar2.png";
            }
            if (c == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar3.png";
            }
            if (c == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar4.png";
            }
            if (c == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar5.png";
            }
            if (c == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar6.png";
            }


            if (d == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar1.png";
            }
            if (d == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar2.png";
            }
            if (d == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar3.png";
            }
            if (d == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar4.png";
            }
            if (d == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar5.png";
            }
            if (d == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\c3lal\\Desktop\\zar\\zar6.png";
            }



            toplampuanpc += c + d;
            label7.Text = toplampuanpc.ToString();
            label15.Text = toplampuanpc.ToString();
        }
    }
}
