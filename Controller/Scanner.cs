using Sharper2._0.Verfahren;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sharper2._0.Controller
{
    public partial class Scanner : UserControl
    {

        public static bool infected = false;
        public static bool report = true;
        Reports reportpage = new Reports();

        public Scanner()
        {
            InitializeComponent();
        }

        private void btn_onlyoneScan_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                reportpage.tb_MD5.Text = MD5_check.GetMD5FromFile(ofd.FileName);
                reportpage.tb_filePath.Text = ofd.FileName.ToString();
            }
            lab_liveFile.Visible = true;
            tb_liveFile.Text = ofd.FileName.ToString();
            btn_clean.Visible = false;
            btn_scan.Visible = true;
        }

        private void btn_driveScan_Click(object sender, EventArgs e)
        {

        }

        private void btn_fullScan_Click(object sender, EventArgs e)
        {

        }

        private void btn_scan_Click_1(object sender, EventArgs e)
        {
            MD5_check.scan(lab_filestatus);
            if (infected == true)
            {
                pic_notinfected.Visible = false;
                pic_infected.Visible = true;
                reportpage.tb_MD5.BackColor = Color.Red;
                btn_clean.Visible = true;
            }
            if (infected == false)
            {
                pic_infected.Visible = false;
                pic_notinfected.Visible = true;
                btn_clean.Visible = false;
                reportpage.tb_MD5.BackColor = Color.FromArgb(47, 55, 63);
            }
            if (report == true)
            {
                btn_report.Visible = true;
            }
        }

        private void btn_clean_Click_1(object sender, EventArgs e)
        {
            try
            {
                File.Delete(reportpage.tb_filePath.Text);
                MessageBox.Show("Erfolgreich entfernt!");
                infected = false;
                reportpage.tb_MD5.Text = "";
                reportpage.tb_filePath.Text = "";
                this.lab_filestatus.ForeColor = Color.LightGreen;
                this.lab_filestatus.Text = "Alles ok!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            reportpage.ShowDialog();
        }
    }
}
