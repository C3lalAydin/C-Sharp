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
            listBox1.Items.Clear();
            if (checkBox1.Checked == true)
            {
                listBox1.Items.Add("Lamba Aç");
            }
            if (checkBox1.Checked == false)
            {
                listBox1.Items.Add("Lamba Kapat");
            }
            if (checkBox2.Checked == true)
            {
                listBox1.Items.Add("Kombi Aç");
            }
            if (checkBox2.Checked == false)
            {
                listBox1.Items.Add("Kombi Kapat");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "Lamba Kapat";
            }
            if (checkBox1.Checked == false)
            {
                checkBox1.Text = "Lamba Aç";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox2.Text = "Kombi Kapat";
            }
            if (checkBox2.Checked == false)
            {
                checkBox2.Text = "Kombi Aç";
            }
        }
    }
}
