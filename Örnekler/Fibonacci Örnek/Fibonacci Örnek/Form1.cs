using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fibonacci_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = 1; //sayi1 adından değişken oluşturulup 1 değeri atanıyor
            int sayi2 = 1; //sayi2 adından değişken oluşturulup 1 değeri atanıyor
            int sayi3;     //sayi3 Adında değişken oluşturuluyor

            listBox1.Items.Add(sayi1);  //sayi1 listbox a item olarak ekleniyor
            listBox1.Items.Add(sayi2);  //sayi2 listbox a item olarak ekleniyor

            for (int x = 1; x < 19; x+=1) //X adında değişken oluşturulup 1 değeri atanıyor.X in değeri 19 dan Büyük olasaya kadar devam et(18 kere tekrar et).X e 1 ekle
            {
                sayi3 = sayi1 + sayi2; //Sayi3 e sayi1 ve sayi2 toplanıp atanıyor

                sayi1 = sayi2; //sayi1 ye sayi2 nin değeri atanıyor
                sayi2 = sayi3; //sayi2 ye sayi3 ün değeri atanıyor

                listBox1.Items.Add(sayi3);  //Sayi3 listbox a item olarak ekleniyor
            }
        }
    }
}
