using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GtaSetup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string durdurma, müzik;
        int sayfa = 0;
        int sayi = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            Cikis cikis = new Cikis();
            cikis.ShowDialog();
            if (cikis.durum == "Evet")
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            müzik = "C:\\Users\\Celal\\Desktop\\Gta_kurulum\\RiverSolo.mp3";
            durdurma = "C:\\Users\\Celal\\Desktop\\Gta_kurulum\\aa.mp3";
            axWindowsMediaPlayer1.URL = müzik;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = müzik;
            button4.Visible = true;
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = durdurma;
            button4.Visible = false;
            button3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayfa += 1;
            if (sayfa == 1)
            {
                geri.Visible = true;
                button1.Enabled = false;
                geri.Enabled = false;
                panel1.Visible = true;
                timer1.Enabled = true;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                pictureBox1.Visible = false;
                button5.Visible = false;
            }
            if (sayfa == 0)
            {
                geri.Visible = false;
                panel1.Visible = false;
                button5.Visible = false;
                timer1.Enabled = false;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                pictureBox1.Visible = true;
                

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sayfa -= 1;
            if (sayfa == 1)
            {
                geri.Visible = true;
                button1.Enabled = false;
                geri.Enabled = false;
                panel1.Visible = true;
                timer1.Enabled = true;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                pictureBox1.Visible = false;
                button5.Visible = false;
            }
            if (sayfa == 0)
            {
                geri.Visible = false;
                panel1.Visible = false;
                button5.Visible = false;
                timer1.Enabled = false;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                pictureBox1.Visible = true;


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            label9.Text = "%" + progressBar1.Value.ToString();
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
                label9.Text = "%100";
                label7.Text = "Dosyalar Çıkartıldı";
                label8.Text = " ";
                
                
                
            }
            if (label9.Text == "%100")
            {
 
            }
            if (progressBar1.Value == 1)
            {
                label8.Text = "C:\\Program Files (x86)\\Grand Theft Auto 6\\gta_sa.exe";
            }
            if (progressBar1.Value == 15)
            {
                label8.Text = "C:\\Program Files (x86)\\Grand Theft Auto 6\\\anim\\anim.img";
            }
            if (progressBar1.Value == 37)
            {
                label8.Text = "C:\\Program Files (x86)\\Grand Theft Auto 6\\Minecraft.exe";
            }
            if (progressBar1.Value == 61)
            {
                label8.Text = "C:\\Program Files (x86)\\Grand Theft Auto 6\\Gta6.exe";
            }
            if (progressBar1.Value == 72)
            {
                label8.Text = "C:\\Program Files (x86)\\Geyta5";
            }
            if (progressBar1.Value == 85)
            {
                label8.Text = "C:\\Program Files (x86)\\Gta5\\Gta8.exe";
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Oyun oyun = new Oyun();
            oyun.Show();
            this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sayi = sayi + 1;
            if (sayi == 4)
            {
                timer2.Enabled = false;
                pictureBox4.ImageLocation = "C:\\Users\\Celal\\Desktop\\Gta_kurulum\\gta6.jpg";
                geri.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                groupBox3.Visible = true;
                pictureBox4.Visible = true;
                button5.Visible = true;
            }
            
        }
    }
}
