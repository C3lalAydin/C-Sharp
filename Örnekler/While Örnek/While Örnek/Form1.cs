using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace While_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;  //X diye bir değişken oluştur 0 değerini ata

            while (x <= 10)  //x 10 dan küçük veya eşitse 
            {
                listBox1.Items.Add(x);  //listbox1 e X in değerini ekle
                x += 1;  //X in değerine 1 ekle
            }      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int y = 0; //Y diye bir değişken oluştur 0 değerini ata

            do  //While Döngüsünde Çalışacak Komutları Giriyoruz
            {
                listBox2.Items.Add(y); //listbox2 e Y nin değerini ekle
                y += 1;   //Y nin değerine 1 ekle
            }
            while (y <= 10);  //Do yu kullandığımız için While koşlul oldu ve ; koyduk
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int z = 0; //Z diye bir değişken oluştur 0 değerini ata

            for (z = 0; z <= 10; )  //Z ye 0 değikenini ata. Z 10 dan küçük veya eşitse 
            {
                listBox3.Items.Add(z); //listbox3 e Z nin değerini ekle
                z += 1;  //Z nin değerine 1 ekle
            }
        }
    }
}
