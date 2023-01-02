namespace Sharper2._0
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_nav_Performance = new Guna.UI2.WinForms.Guna2Button();
            this.btn_nav_Privatsphäre = new Guna.UI2.WinForms.Guna2Button();
            this.btn_nav_Scanner = new Guna.UI2.WinForms.Guna2Button();
            this.btn_nav_Status = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.status1 = new Sharper2._0.Status();
            this.scanner1 = new Sharper2._0.Controller.Scanner();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 1;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.btn_nav_Performance);
            this.guna2Panel1.Controls.Add(this.btn_nav_Privatsphäre);
            this.guna2Panel1.Controls.Add(this.btn_nav_Scanner);
            this.guna2Panel1.Controls.Add(this.btn_nav_Status);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 38);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(160, 646);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Location = new System.Drawing.Point(157, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1065, 643);
            this.guna2Panel3.TabIndex = 2;
            // 
            // btn_nav_Performance
            // 
            this.btn_nav_Performance.Animated = true;
            this.btn_nav_Performance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_nav_Performance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_nav_Performance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_nav_Performance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_nav_Performance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.btn_nav_Performance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_nav_Performance.ForeColor = System.Drawing.Color.White;
            this.btn_nav_Performance.Location = new System.Drawing.Point(0, 257);
            this.btn_nav_Performance.Name = "btn_nav_Performance";
            this.btn_nav_Performance.Size = new System.Drawing.Size(160, 90);
            this.btn_nav_Performance.TabIndex = 5;
            this.btn_nav_Performance.Text = "Perfomance";
            this.btn_nav_Performance.Click += new System.EventHandler(this.btn_nav_Performance_Click);
            // 
            // btn_nav_Privatsphäre
            // 
            this.btn_nav_Privatsphäre.Animated = true;
            this.btn_nav_Privatsphäre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_nav_Privatsphäre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_nav_Privatsphäre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_nav_Privatsphäre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_nav_Privatsphäre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.btn_nav_Privatsphäre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_nav_Privatsphäre.ForeColor = System.Drawing.Color.White;
            this.btn_nav_Privatsphäre.Location = new System.Drawing.Point(0, 171);
            this.btn_nav_Privatsphäre.Name = "btn_nav_Privatsphäre";
            this.btn_nav_Privatsphäre.Size = new System.Drawing.Size(160, 90);
            this.btn_nav_Privatsphäre.TabIndex = 4;
            this.btn_nav_Privatsphäre.Text = "Privatsphäre";
            this.btn_nav_Privatsphäre.Click += new System.EventHandler(this.btn_nav_Privatsphäre_Click);
            // 
            // btn_nav_Scanner
            // 
            this.btn_nav_Scanner.Animated = true;
            this.btn_nav_Scanner.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_nav_Scanner.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_nav_Scanner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_nav_Scanner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_nav_Scanner.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.btn_nav_Scanner.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_nav_Scanner.ForeColor = System.Drawing.Color.White;
            this.btn_nav_Scanner.Location = new System.Drawing.Point(0, 84);
            this.btn_nav_Scanner.Name = "btn_nav_Scanner";
            this.btn_nav_Scanner.Size = new System.Drawing.Size(160, 90);
            this.btn_nav_Scanner.TabIndex = 3;
            this.btn_nav_Scanner.Text = "Scanner";
            this.btn_nav_Scanner.Click += new System.EventHandler(this.btn_nav_Scanner_Click);
            // 
            // btn_nav_Status
            // 
            this.btn_nav_Status.Animated = true;
            this.btn_nav_Status.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_nav_Status.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_nav_Status.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_nav_Status.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_nav_Status.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.btn_nav_Status.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_nav_Status.ForeColor = System.Drawing.Color.White;
            this.btn_nav_Status.Location = new System.Drawing.Point(0, 0);
            this.btn_nav_Status.Name = "btn_nav_Status";
            this.btn_nav_Status.Size = new System.Drawing.Size(160, 90);
            this.btn_nav_Status.TabIndex = 2;
            this.btn_nav_Status.Text = "Status";
            this.btn_nav_Status.Click += new System.EventHandler(this.btn_nav_Status_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(68, 38);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1222, 38);
            this.guna2Panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(68, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sharper Antivirus";
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.guna2ControlBox3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1132, 3);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(25, 23);
            this.guna2ControlBox3.TabIndex = 4;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.guna2ControlBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1163, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(25, 23);
            this.guna2ControlBox2.TabIndex = 3;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.guna2ControlBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1194, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(25, 23);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // status1
            // 
            this.status1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.status1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status1.Location = new System.Drawing.Point(157, 38);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(1062, 646);
            this.status1.TabIndex = 2;
            // 
            // scanner1
            // 
            this.scanner1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.scanner1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanner1.Location = new System.Drawing.Point(157, 38);
            this.scanner1.Name = "scanner1";
            this.scanner1.Size = new System.Drawing.Size(1062, 646);
            this.scanner1.TabIndex = 3;
            this.scanner1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1222, 684);
            this.Controls.Add(this.scanner1);
            this.Controls.Add(this.status1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharper";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_nav_Status;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btn_nav_Performance;
        private Guna.UI2.WinForms.Guna2Button btn_nav_Privatsphäre;
        private Guna.UI2.WinForms.Guna2Button btn_nav_Scanner;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Status status1;
        private Controller.Scanner scanner1;
    }
}

