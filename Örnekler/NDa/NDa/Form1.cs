using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fgfh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi1, sayi2, toplam;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            if (sayi1 > sayi2)
            {
                for (int x = sayi2; x <= sayi1; x++)
                {
                    listBox1.Items.Add(x);
                }
            }
            if (sayi1 < sayi2)
            {
                for (int x = sayi1; x <= sayi2; x++)
                {
                    listBox1.Items.Add(x);
                }
            }
        }
    }
}
