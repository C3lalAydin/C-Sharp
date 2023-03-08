using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace For_Döngü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;                      //İnt tipinde X değişkeni oluştur
            for (x = 0; x < 10; x++)    //X e 0 değerini ata. X in değeri 10dan büyük olasaya kadar devam et. X in değerine 1 ekle
            {
                listBox1.Items.Add(x);  //listBox1 e X in değerini item olarak ekle
                label1.Text = x.ToString(); //X in değerini String e çevirerek Label1 in Textine Yazdır (X in değeri en son 9 olduğu için 9 Rakamını yazar)
            }

             
            //    FARKLI YÖNTEM
            //int x;                       İnt tipinde X değişkeni oluştur
            // for (x = 0; x < 10; )       X e 0 değerini ata. X in değeri 10 dan büyük olasaya kadar devam et. X in değeri 10 yada daha büyükse dur
            //{
            //    listBox1.Items.Add(x);   listBox1 e X in değerini item olarak ekle
            //    x+=1                     X değerini 1 artır
            // }
            

            //    FARKLI YÖNTEM 2
            //for (int i = 10; i < 20; i++)   İ diye br değişken oluştur 10 değerini ata.İ nin değeri 20 den büyük olasaya kadar devam et. İ nin değerine 1 ekle
            //{
            //    listBox1.Items.Add(i);      listBox1 e İ nin değerini item olarak ekle
            // }


        }
    }
}
