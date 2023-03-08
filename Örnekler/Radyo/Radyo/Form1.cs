using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Radyo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string fenomen="https://listen.radyofenomen.com/fenomen/128/icecast.audio";
        string fenomenrap = "https://listen.radyofenomen.com/fenomenrap/128/icecast.audio";
        string fenomenturkcerap="https://listen.radyofenomen.com/fenomenturkrap/128/icecast.audio";
        string virgunradio="https://playerservices.streamtheworld.com/api/livestream-redirect/VIRGIN_RADIO.mp3";

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL=fenomen;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL=fenomenrap;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL=fenomenturkcerap;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL=virgunradio;
        }

    }
}