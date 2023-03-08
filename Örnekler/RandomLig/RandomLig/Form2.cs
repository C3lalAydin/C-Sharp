using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomLig
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int gspuan = 0;
        int fbpuan = 0;
        int bjkpuan = 0;
        int antspuan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            int sayi1 = rastgele.Next(0, 5);
            int sayi2 = rastgele.Next(0, 5);
            int sayi3 = rastgele.Next(0, 5);
            int sayi4 = rastgele.Next(0, 5);

            label4.Text = sayi1.ToString(); //Galatasaray
            label5.Text = sayi2.ToString(); //Fenerbahçe
            label6.Text = sayi3.ToString(); //Beşiktaş
            label8.Text = sayi4.ToString(); //Antalyaspor

            if (Convert.ToInt32(label4.Text)>Convert.ToInt32(label5.Text))
            {
                gspuan += 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label5.Text) > Convert.ToInt32(label4.Text))
            {
                fbpuan += 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label4.Text) == Convert.ToInt32(label5.Text))
            {
                gspuan += 1;
                fbpuan += 1;
                labelgspuan.Text = gspuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label6.Text) > Convert.ToInt32(label8.Text))
            {
                bjkpuan += 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label8.Text) > Convert.ToInt32(label6.Text))
            {
                antspuan += 3;
                labelantspuan.Text = antspuan.ToString();
            }
            if (Convert.ToInt32(label6.Text) == Convert.ToInt32(label8.Text))
            {
                bjkpuan += 1;
                antspuan += 1;
                labelbjkpuan.Text = bjkpuan.ToString();
                labelantspuan.Text = antspuan.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = true;
            int sayi1 = rastgele.Next(0, 5);
            int sayi2 = rastgele.Next(0, 5);
            int sayi3 = rastgele.Next(0, 5);
            int sayi4 = rastgele.Next(0, 5);

            label22.Text = sayi1.ToString(); //Galatasaray
            label20.Text = sayi2.ToString(); //Beşiktaş
            label15.Text = sayi3.ToString(); //Antalyaspor
            label11.Text = sayi4.ToString(); //Fenerbahçe

            if (Convert.ToInt32(label22.Text) > Convert.ToInt32(label20.Text)) 
            {
                gspuan += 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label20.Text) > Convert.ToInt32(label22.Text))
            {
                bjkpuan += 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label22.Text)==Convert.ToInt32(label20.Text))
            {
                gspuan += 1;
                bjkpuan += 1;
                labelgspuan.Text = gspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label15.Text) > Convert.ToInt32(label11.Text))
            {
                antspuan += 3;
                labelantspuan.Text = antspuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) > Convert.ToInt32(label15.Text))
            {
                fbpuan += 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label15.Text)==Convert.ToInt32(label11.Text))
            {
                antspuan += 1;
                fbpuan += 1;
                labelantspuan.Text = antspuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Enabled = true;
            int sayi1 = rastgele.Next(0, 5);
            int sayi2 = rastgele.Next(0, 5);
            int sayi3 = rastgele.Next(0, 5);
            int sayi4 = rastgele.Next(0, 5);

            label25.Text = sayi1.ToString(); //Galatasaray
            label27.Text = sayi2.ToString(); //Antalyaspor
            label30.Text = sayi3.ToString(); //Beşiktaş 
            label32.Text = sayi4.ToString(); //Fenerbahçe


            if (Convert.ToInt32(label25.Text) > Convert.ToInt32(label27.Text))
            {
                gspuan += 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label27.Text) > Convert.ToInt32(label25.Text))
            {
                antspuan += 3;
                labelantspuan.Text = antspuan.ToString();
            }
            if (Convert.ToInt32(label22.Text) == Convert.ToInt32(label20.Text))
            {
                gspuan += 1;
                antspuan += 1;
                labelgspuan.Text = gspuan.ToString();
                labelantspuan.Text = antspuan.ToString();
            }
            if (Convert.ToInt32(label30.Text) > Convert.ToInt32(label32.Text))
            {
                bjkpuan += 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label32.Text) > Convert.ToInt32(label30.Text))
            {
                fbpuan += 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label32.Text) == Convert.ToInt32(label30.Text))
            {
                bjkpuan += 1;
                fbpuan += 1;
                labelbjkpuan.Text = bjkpuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (gspuan > fbpuan && gspuan > antspuan && gspuan > bjkpuan)
            {
                label35.Text = "Galatasaray Kazandı" + "\n" + "Puanı: " + gspuan;
            }
            if (fbpuan > gspuan && fbpuan > antspuan && fbpuan > bjkpuan)
            {
                label35.Text = "Fenerbahçe Kazandı" + "\n" + "Puanı: " + fbpuan;
            }
            if (bjkpuan > gspuan && bjkpuan > antspuan && bjkpuan > fbpuan)
            {
                label35.Text = "Beşiktaş Kazandı" + "\n" + "Puanı: " + bjkpuan;
            }
            if (antspuan > gspuan && antspuan > bjkpuan && antspuan > bjkpuan)
            {
                label35.Text = "Antalyaspor Kazandı" + "\n" + "Puanı: " + antspuan;
            }
            label35.Visible = true;
        }   
    }
}
