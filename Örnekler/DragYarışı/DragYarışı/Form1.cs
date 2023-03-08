using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AtYarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int car1solauzaklık, car2solauzaklık, car3solauzaklık;

        Random rstg = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            car1solauzaklık = pictureBox1.Left;
            car2solauzaklık = pictureBox2.Left;
            car3solauzaklık = pictureBox3.Left;
            button2.Enabled = false;
            audiobox.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int car1genislik, car2genislik, car3genislik;
            int bitisuzaklik = label5.Left;

            car1genislik = pictureBox1.Width;
            car2genislik = pictureBox2.Width;
            car3genislik = pictureBox3.Width;

            pictureBox1.Left += rstg.Next(3, 12);
            pictureBox2.Left += rstg.Next(3, 12);
            pictureBox3.Left += rstg.Next(3, 12);
            if (pictureBox1.Left > pictureBox2.Left + 3 && pictureBox1.Left > pictureBox3.Left + 3)
            {
                label6.Text = "1 Numaralı Araba Önde";
            }
            if (pictureBox2.Left > pictureBox1.Left + 3 && pictureBox2.Left > pictureBox3.Left + 3)
            {
                label6.Text = "2 Numaralı Araba Önde";
            }
            if (pictureBox3.Left > pictureBox2.Left + 3 && pictureBox3.Left > pictureBox1.Left + 3)
            {
                label6.Text = "3 Numaralı Araba Önde";
            }

            if (car1genislik + pictureBox1.Left >= bitisuzaklik)
            {
                timer2.Enabled = false;
                timer1.Enabled=false;
                MessageBox.Show("1. Araba Kazandı", "KAZANAN");
                button2.Enabled = true;
            }
            if (car2genislik + pictureBox2.Left >= bitisuzaklik)
            {
                timer2.Enabled = false;
                timer1.Enabled = false;
                MessageBox.Show("2. Araba Kazandı", "KAZANAN");
                button2.Enabled = true;
            }
            if (car3genislik + pictureBox3.Left >= bitisuzaklik)
            {
                timer2.Enabled = false;
                timer1.Enabled = false;
                MessageBox.Show("3. Araba Kazandı","KAZANAN");
                button2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int sure = Convert.ToInt32(label7.Text);
            sure += 1;
            label7.Text = (sure).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(37, 24);
            pictureBox2.Location = new Point(37, 159);
            pictureBox3.Location = new Point(37, 278);
            label6.Text = " ";
            label7.Text = "0";
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void audiobox_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\c3lal\\Documents\\Visual Studio 2010\\Projects\\DragYarışı\\DragYarışı\\Supraaa drift edit 1 hour.mp3";
            audiobox.Visible = false;
            noaudiobox.Visible = true;
        }

        private void noaudiobox_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "bfzgnzd.mp3";
            noaudiobox.Visible = false;
            audiobox.Visible = true;
        }
    }
}
