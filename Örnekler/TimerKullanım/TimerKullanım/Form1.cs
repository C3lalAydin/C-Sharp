using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimerKullanım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dk, saat, saniye;
            saat = DateTime.Now.Hour.ToString();
            dk = DateTime.Now.Minute.ToString();
            saniye = DateTime.Now.Second.ToString();

            label1.Text = saat + ":" + dk + ":" + saniye;
        }
    }
}
