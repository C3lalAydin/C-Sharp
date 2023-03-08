using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int dk=Convert.ToInt32(label2.Text);
            int saniye = Convert.ToInt32(label1.Text);
        

           
            saniye += 1;
            
            if (saniye == 60)
            {
                saniye = 0; label1.Text = saniye.ToString();
                dk += 1;
                label2.Text = dk.ToString();
            }
            label1.Text = saniye.ToString();
            label2.Text = dk.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int salise = Convert.ToInt32(label6.Text);
            int saniye = Convert.ToInt32(label1.Text);
            salise += 1;

            if (salise == 60)
            {
                salise = 0;
                label6.Text = salise.ToString();
                saniye += 1;
                label1.Text = saniye.ToString();
            
            }
            label6.Text = salise.ToString();
        }
    }
}
