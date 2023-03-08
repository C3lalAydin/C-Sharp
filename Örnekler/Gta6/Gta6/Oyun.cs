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
    public partial class Oyun : Form
    {
        public Oyun()
        {
            InitializeComponent();
        }
        int sayi = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi += 1;
            if (sayi==9)
            {
                pictureBox1.ImageLocation="C:\\Users\\Celal\\Desktop\\Gta_kurulum\\gta6.gif";
                
            }
            if (sayi == 15)
            {
                timer1.Enabled = false;
                pictureBox1.ImageLocation = "C:\\Users\\Celal\\Desktop\\Gta_kurulum\\Oyun.gif";
                sayi += 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
