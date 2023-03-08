using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Haftanın_Günü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bugun = Convert.ToInt32(DateTime.Now.DayOfWeek);
            int gun = Convert.ToInt32(DateTime.Now.Day);
            int ay = Convert.ToInt32(DateTime.Now.Month);
            int yil = Convert.ToInt32(DateTime.Now.Year);
            string ayy=" ";
            string bugünn=" ";
            string tarih=" ";

            switch (bugun)
            {
                case 1:
                    bugünn =" Pazartesi";
                    break;
                case 2:
                    bugünn=" Salı";
                    break;
                case 3:
                    bugünn = " Çarşamba";
                    break;
                case 4:
                    bugünn =" Perşembe";
                    break;
                case 5:
                    bugünn = " Cuma";
                    break;
                case 6:
                    bugünn = " Cumartesi";
                    break;
                case 0:
                    bugünn = " Pazar";
                    break;
            }
            switch (ay)
            {
                case 1:
                    ayy = "Ocak";
                    break;
                case 2:
                    ayy = "Şubat";
                    break;
                case 3:
                    ayy = "Mart";
                    break;
                case 4:
                    ayy = "Nisan";
                    break;
                case 5:
                    ayy = "Mayıs";
                    break;
                case 6:
                    ayy = "Haziran";
                    break;
                case 7:
                    ayy = "Temmuz";
                    break;
                case 8:
                    ayy = "Ağustos";
                    break;
                case 9:
                    ayy = "Eylül";
                    break;
                case 10:
                    ayy = "Ekim";
                    break;
                case 11:
                    ayy = "Kasım";
                    break;
                case 12:
                    ayy = "Aralık";
                    break;
            }
            tarih = gun.ToString() + " " + ayy  + bugünn+" "+yil;
            MessageBox.Show(tarih);
 
        }
    }
}
