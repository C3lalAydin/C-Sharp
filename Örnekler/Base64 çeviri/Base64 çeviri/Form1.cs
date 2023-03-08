using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
             var encode = Encoding.UTF8.GetBytes(richTextBox1.Text);
             var ceviri = Convert.ToBase64String(encode);

             richTextBox2.Text = ceviri.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label1.Visible = true;
                label2.Visible = true;
                richTextBox1.Visible = true;
                richTextBox2.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
                richTextBox1.Visible = false;
                richTextBox2.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Base64 = Convert.FromBase64String(richTextBox4.Text);
            var cikti = Encoding.UTF8.GetString(Base64);

            richTextBox3.Text = cikti.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label3.Visible = true;
                label4.Visible = true;
                richTextBox4.Visible = true;
                richTextBox3.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
            }
            else
            {
                label3.Visible = false;
                label4.Visible = false;
                richTextBox3.Visible = false;
                richTextBox4.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
        }
    }
}
