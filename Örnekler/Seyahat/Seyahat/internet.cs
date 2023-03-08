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
    public partial class internet : Form
    {
        public internet()
        {
            InitializeComponent();
        }

        private void internet_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.yandex.com.tr");
        }
    }
}
