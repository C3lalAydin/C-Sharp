using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RenkAnlam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "1234")
            {
                Form2 renkform = new Form2();
                renkform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
