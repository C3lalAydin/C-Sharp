using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seyahat
{
    public partial class HavaDurumu : Form
    {
        public HavaDurumu()
        {
            InitializeComponent();
        }

        private void HavaDurumu_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://mgm.gov.tr/FTPDATA/analiz/harita/png/haritasondurumSH.png");
        }
    }
}
