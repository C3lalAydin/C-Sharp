﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomLig
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
                Form2 oyun = new Form2();
                oyun.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 oyun = new Form2();
            oyun.Show();
            this.Hide();
        }
    }
}
