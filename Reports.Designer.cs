namespace Sharper2._0
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.lab_file = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_md5Copy = new Guna.UI2.WinForms.Guna2Button();
            this.tb_filePath = new System.Windows.Forms.TextBox();
            this.tb_MD5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lab_file
            // 
            this.lab_file.AutoSize = true;
            this.lab_file.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lab_file.Location = new System.Drawing.Point(5, 9);
            this.lab_file.Name = "lab_file";
            this.lab_file.Size = new System.Drawing.Size(75, 32);
            this.lab_file.TabIndex = 0;
            this.lab_file.Text = "Datei:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(5, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Verfahren:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label2.Location = new System.Drawing.Point(5, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "MD5:";
            // 
            // btn_md5Copy
            // 
            this.btn_md5Copy.BorderRadius = 5;
            this.btn_md5Copy.BorderThickness = 1;
            this.btn_md5Copy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_md5Copy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_md5Copy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_md5Copy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_md5Copy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.btn_md5Copy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_md5Copy.ForeColor = System.Drawing.Color.Black;
            this.btn_md5Copy.Location = new System.Drawing.Point(5, 119);
            this.btn_md5Copy.Name = "btn_md5Copy";
            this.btn_md5Copy.Size = new System.Drawing.Size(107, 26);
            this.btn_md5Copy.TabIndex = 5;
            this.btn_md5Copy.Text = "MD5 kopieren";
            this.btn_md5Copy.Click += new System.EventHandler(this.btn_md5Copy_Click);
            // 
            // tb_filePath
            // 
            this.tb_filePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.tb_filePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_filePath.Enabled = false;
            this.tb_filePath.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tb_filePath.Location = new System.Drawing.Point(92, 14);
            this.tb_filePath.Name = "tb_filePath";
            this.tb_filePath.Size = new System.Drawing.Size(707, 24);
            this.tb_filePath.TabIndex = 6;
            // 
            // tb_MD5
            // 
            this.tb_MD5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.tb_MD5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_MD5.Enabled = false;
            this.tb_MD5.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tb_MD5.Location = new System.Drawing.Point(89, 154);
            this.tb_MD5.Name = "tb_MD5";
            this.tb_MD5.Size = new System.Drawing.Size(707, 24);
            this.tb_MD5.TabIndex = 7;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_MD5);
            this.Controls.Add(this.tb_filePath);
            this.Controls.Add(this.btn_md5Copy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_file);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reports";
            this.Text = "Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_md5Copy;
        public System.Windows.Forms.TextBox tb_filePath;
        public System.Windows.Forms.TextBox tb_MD5;
    }
}