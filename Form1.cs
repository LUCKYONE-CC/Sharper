using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharper2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_nav_Status_Click(object sender, EventArgs e)
        {
            status1.Visible = true;
            scanner1.Visible = false;
        }

        private void btn_nav_Scanner_Click(object sender, EventArgs e)
        {
            status1.Visible = false;
            scanner1.Visible = true;
        }

        private void btn_nav_Privatsphäre_Click(object sender, EventArgs e)
        {
            btn_nav_Status.Visible = false;
            btn_nav_Scanner.Visible = false;
            btn_nav_Privatsphäre.Visible = true;
            btn_nav_Performance.Visible = false;
        }

        private void btn_nav_Performance_Click(object sender, EventArgs e)
        {
            btn_nav_Status.Visible = false;
            btn_nav_Scanner.Visible = false;
            btn_nav_Privatsphäre.Visible = false;
            btn_nav_Performance.Visible = true;
        }
    }
}
