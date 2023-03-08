using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\c3lal\\Documents\\Visual Studio 2010\\Projects\\MediaPlayer\\Erik_Satie_ Gnossienne_No1_Remix.mp3";
            pictureBox1.ImageLocation = "C:\\Users\\c3lal\\Documents\\Visual Studio 2010\\Projects\\MediaPlayer\\Porçay Logo.png";
            button1.Visible = false;
        }
    }
}
