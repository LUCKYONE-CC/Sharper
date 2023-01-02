namespace Sharper2._0.Controller
{
    partial class Scanner
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scanner));
            this.btn_onlyoneScan = new Guna.UI2.WinForms.Guna2Button();
            this.btn_driveScan = new Guna.UI2.WinForms.Guna2Button();
            this.btn_fullScan = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pic_notinfected = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_clean = new Guna.UI2.WinForms.Guna2Button();
            this.btn_scan = new Guna.UI2.WinForms.Guna2Button();
            this.lab_filestatus = new System.Windows.Forms.Label();
            this.pic_infected = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_report = new Guna.UI2.WinForms.Guna2Button();
            this.tb_liveFile = new Guna.UI2.WinForms.Guna2TextBox();
            this.lab_liveFile = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_notinfected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_infected)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_onlyoneScan
            // 
            this.btn_onlyoneScan.Animated = true;
            this.btn_onlyoneScan.BorderRadius = 1;
            this.btn_onlyoneScan.BorderThickness = 1;
            this.btn_onlyoneScan.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_onlyoneScan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_onlyoneScan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_onlyoneScan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_onlyoneScan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_onlyoneScan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.btn_onlyoneScan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_onlyoneScan.ForeColor = System.Drawing.Color.White;
            this.btn_onlyoneScan.Location = new System.Drawing.Point(133, 180);
            this.btn_onlyoneScan.Name = "btn_onlyoneScan";
            this.btn_onlyoneScan.Size = new System.Drawing.Size(221, 146);
            this.btn_onlyoneScan.TabIndex = 0;
            this.btn_onlyoneScan.Text = "Einzelne Datei überprüfen";
            this.btn_onlyoneScan.Click += new System.EventHandler(this.btn_onlyoneScan_Click_1);
            // 
            // btn_driveScan
            // 
            this.btn_driveScan.Animated = true;
            this.btn_driveScan.BorderRadius = 1;
            this.btn_driveScan.BorderThickness = 1;
            this.btn_driveScan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_driveScan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_driveScan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_driveScan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_driveScan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.btn_driveScan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_driveScan.ForeColor = System.Drawing.Color.White;
            this.btn_driveScan.Location = new System.Drawing.Point(423, 180);
            this.btn_driveScan.Name = "btn_driveScan";
            this.btn_driveScan.Size = new System.Drawing.Size(221, 146);
            this.btn_driveScan.TabIndex = 1;
            this.btn_driveScan.Text = "Laufwerk überprüfen";
            this.btn_driveScan.Click += new System.EventHandler(this.btn_driveScan_Click);
            // 
            // btn_fullScan
            // 
            this.btn_fullScan.Animated = true;
            this.btn_fullScan.BorderRadius = 1;
            this.btn_fullScan.BorderThickness = 1;
            this.btn_fullScan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_fullScan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_fullScan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_fullScan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_fullScan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.btn_fullScan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_fullScan.ForeColor = System.Drawing.Color.White;
            this.btn_fullScan.Location = new System.Drawing.Point(713, 180);
            this.btn_fullScan.Name = "btn_fullScan";
            this.btn_fullScan.Size = new System.Drawing.Size(221, 146);
            this.btn_fullScan.TabIndex = 2;
            this.btn_fullScan.Text = "Alle Dateien überprüfen";
            this.btn_fullScan.Click += new System.EventHandler(this.btn_fullScan_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(71)))), ((int)(((byte)(77)))));
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.pic_notinfected);
            this.guna2Panel1.Controls.Add(this.btn_clean);
            this.guna2Panel1.Controls.Add(this.btn_scan);
            this.guna2Panel1.Controls.Add(this.lab_filestatus);
            this.guna2Panel1.Controls.Add(this.pic_infected);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(19, 21);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1020, 60);
            this.guna2Panel1.TabIndex = 3;
            // 
            // pic_notinfected
            // 
            this.pic_notinfected.BackColor = System.Drawing.Color.Transparent;
            this.pic_notinfected.Image = ((System.Drawing.Image)(resources.GetObject("pic_notinfected.Image")));
            this.pic_notinfected.ImageRotate = 0F;
            this.pic_notinfected.Location = new System.Drawing.Point(15, 3);
            this.pic_notinfected.Name = "pic_notinfected";
            this.pic_notinfected.Size = new System.Drawing.Size(63, 57);
            this.pic_notinfected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_notinfected.TabIndex = 6;
            this.pic_notinfected.TabStop = false;
            this.pic_notinfected.UseTransparentBackground = true;
            this.pic_notinfected.Visible = false;
            // 
            // btn_clean
            // 
            this.btn_clean.BorderRadius = 5;
            this.btn_clean.BorderThickness = 1;
            this.btn_clean.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clean.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clean.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clean.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clean.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_clean.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_clean.ForeColor = System.Drawing.Color.Black;
            this.btn_clean.Location = new System.Drawing.Point(732, -1);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(141, 61);
            this.btn_clean.TabIndex = 4;
            this.btn_clean.Text = "Bereinigen";
            this.btn_clean.Visible = false;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click_1);
            // 
            // btn_scan
            // 
            this.btn_scan.BorderRadius = 5;
            this.btn_scan.BorderThickness = 1;
            this.btn_scan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_scan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_scan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_scan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_scan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_scan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_scan.ForeColor = System.Drawing.Color.Black;
            this.btn_scan.Location = new System.Drawing.Point(879, -1);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(141, 61);
            this.btn_scan.TabIndex = 3;
            this.btn_scan.Text = "Scannen";
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click_1);
            // 
            // lab_filestatus
            // 
            this.lab_filestatus.AutoSize = true;
            this.lab_filestatus.BackColor = System.Drawing.Color.Transparent;
            this.lab_filestatus.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lab_filestatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lab_filestatus.Location = new System.Drawing.Point(159, 19);
            this.lab_filestatus.Name = "lab_filestatus";
            this.lab_filestatus.Size = new System.Drawing.Size(0, 25);
            this.lab_filestatus.TabIndex = 2;
            // 
            // pic_infected
            // 
            this.pic_infected.BackColor = System.Drawing.Color.Transparent;
            this.pic_infected.Image = ((System.Drawing.Image)(resources.GetObject("pic_infected.Image")));
            this.pic_infected.ImageRotate = 0F;
            this.pic_infected.Location = new System.Drawing.Point(15, 3);
            this.pic_infected.Name = "pic_infected";
            this.pic_infected.Size = new System.Drawing.Size(63, 57);
            this.pic_infected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_infected.TabIndex = 1;
            this.pic_infected.TabStop = false;
            this.pic_infected.UseTransparentBackground = true;
            this.pic_infected.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(84, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status: ";
            // 
            // btn_report
            // 
            this.btn_report.BorderRadius = 5;
            this.btn_report.BorderThickness = 1;
            this.btn_report.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_report.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_report.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_report.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_report.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(99)))), ((int)(((byte)(79)))));
            this.btn_report.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_report.ForeColor = System.Drawing.Color.Black;
            this.btn_report.Location = new System.Drawing.Point(918, 582);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(141, 61);
            this.btn_report.TabIndex = 5;
            this.btn_report.Text = "Bericht";
            this.btn_report.Visible = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // tb_liveFile
            // 
            this.tb_liveFile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.tb_liveFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_liveFile.DefaultText = "";
            this.tb_liveFile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_liveFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_liveFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_liveFile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_liveFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.tb_liveFile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_liveFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_liveFile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_liveFile.Location = new System.Drawing.Point(277, 603);
            this.tb_liveFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_liveFile.Name = "tb_liveFile";
            this.tb_liveFile.PasswordChar = '\0';
            this.tb_liveFile.PlaceholderText = "";
            this.tb_liveFile.SelectedText = "";
            this.tb_liveFile.Size = new System.Drawing.Size(431, 25);
            this.tb_liveFile.TabIndex = 6;
            // 
            // lab_liveFile
            // 
            this.lab_liveFile.AutoSize = true;
            this.lab_liveFile.BackColor = System.Drawing.Color.Transparent;
            this.lab_liveFile.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lab_liveFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lab_liveFile.Location = new System.Drawing.Point(29, 603);
            this.lab_liveFile.Name = "lab_liveFile";
            this.lab_liveFile.Size = new System.Drawing.Size(219, 25);
            this.lab_liveFile.TabIndex = 7;
            this.lab_liveFile.Text = "Aktuell ausgewählte Datei:";
            this.lab_liveFile.Visible = false;
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.lab_liveFile);
            this.Controls.Add(this.tb_liveFile);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btn_fullScan);
            this.Controls.Add(this.btn_driveScan);
            this.Controls.Add(this.btn_onlyoneScan);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Scanner";
            this.Size = new System.Drawing.Size(1062, 646);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_notinfected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_infected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_onlyoneScan;
        private Guna.UI2.WinForms.Guna2Button btn_driveScan;
        private Guna.UI2.WinForms.Guna2Button btn_fullScan;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lab_filestatus;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_scan;
        private Guna.UI2.WinForms.Guna2Button btn_clean;
        private Guna.UI2.WinForms.Guna2Button btn_report;
        public Guna.UI2.WinForms.Guna2PictureBox pic_notinfected;
        public Guna.UI2.WinForms.Guna2PictureBox pic_infected;
        private Guna.UI2.WinForms.Guna2TextBox tb_liveFile;
        private System.Windows.Forms.Label lab_liveFile;
    }
}
