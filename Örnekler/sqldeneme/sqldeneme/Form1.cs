using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace sqldeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conect = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\ogrenciler.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        private void verigoster()
        {
            conect.Open();
            SqlCommand komut = new SqlCommand("Select *from bilgiler", conect);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["adsoyad"].ToString();
                ekle.SubItems.Add(oku["sehir"].ToString());
                ekle.SubItems.Add(oku["okul"].ToString());
                listView1.Items.Add(ekle);
            }

 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verigoster();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
//Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True
//Data Source=BILGISAYAR\\SQLSERVER;Initial Catalog=ogrenciler;Integrated Security=True
//Data Source=.\SQLEXPRESS;AttachDbFilename="C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\ogrenciler.mdf";Integrated Security=True;Connect Timeout=30;User Instance=True
//Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ogrenciler.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True