using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GtaSetup
{
    public partial class Cikis : Form
    {
        public string durum = "";
        public Cikis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            durum = "Evet";
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            durum = "Hayır";
            this.Close();
        }

        private void Cikis_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
