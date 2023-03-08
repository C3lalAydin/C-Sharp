using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Oyun1 : Form
    {
        public Oyun1()
        {
            InitializeComponent();
        }

        bool oyuncu = true;
        private void button3_Click(object sender, EventArgs e)
        {
            Random rstgele = new Random();

            
            if (oyuncu == false)
            {
                int a = rstgele.Next(20, 38);
                int p1Y = pictureBox2.Location.Y;
                int p1X = pictureBox2.Location.X;
                pictureBox2.Location = new Point(p1X + a, p1Y);
                
                if (pictureBox5.Location.X >= 545)
                {
                    button3.Enabled = false;
                    label1.Text = "Oyuncu 2 Kazandı";
                }
                oyuncu = true;  
            }
            if (oyuncu == true)
            {
                int b = rstgele.Next(20, 40);
                int p2Y = pictureBox5.Location.Y;
                int p2X = pictureBox5.Location.X;
                pictureBox5.Location = new Point(p2X + b, p2Y);

                if (pictureBox2.Location.X >= 557)
                {
                    button3.Enabled = false;
                    label1.Text = "Oyuncu 1 Kazandı";
                }
                oyuncu = false;
            }           
        }
    }
}
