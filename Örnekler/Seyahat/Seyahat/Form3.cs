using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seyahat
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string fenomenrap = "https://listen.radyofenomen.com/fenomenrap/128/icecast.audio";
        string fenomenturkcerap = "https://listen.radyofenomen.com/fenomenturkrap/128/icecast.audio";

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 bilet_alani = new Form2();
            bilet_alani.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form internet = new internet();
            internet.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = fenomenrap;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = fenomenturkcerap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            axWindowsMediaPlayer1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "nmtfg.mp3";
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HavaDurumu form_hava = new HavaDurumu();
            form_hava.Show();
        }
    }
}
