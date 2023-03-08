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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "12345") // şu işaret(&&) iki kere kullanınca and (ve) anlamına gelir
            {
                Form2 yeni;      //Yeni adında değişken oluştur
                yeni = new Form2();  //yeni değişkenine Form2 yi ata
                yeni.Show();    //yeni değişkenini (Form2) göster
                this.Hide();


            }
            else 
            {
                MessageBox.Show("Hatalı Giriş");

            }
            
        }
    }
}
