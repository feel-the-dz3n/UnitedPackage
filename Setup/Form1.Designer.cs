namespace Setup
{
    partial class Form1
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbManagerPath = new System.Windows.Forms.TextBox();
            this.tbDatabasePath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(510, 147);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "No";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInstall.Location = new System.Drawing.Point(429, 147);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 23);
            this.btnInstall.TabIndex = 1;
            this.btnInstall.Text = "Yes";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Install United Package Manager?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "* provides you fast installing and uninstalling software manager";
            // 
            // tbManagerPath
            // 
            this.tbManagerPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbManagerPath.BackColor = System.Drawing.SystemColors.Control;
            this.tbManagerPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbManagerPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbManagerPath.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.tbManagerPath.Location = new System.Drawing.Point(17, 133);
            this.tbManagerPath.Name = "tbManagerPath";
            this.tbManagerPath.Size = new System.Drawing.Size(402, 15);
            this.tbManagerPath.TabIndex = 4;
            this.tbManagerPath.Text = "Manager: C:\\Program Files\\United Package";
            this.tbManagerPath.Click += new System.EventHandler(this.tbManagerPath_Click);
            // 
            // tbDatabasePath
            // 
            this.tbDatabasePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDatabasePath.BackColor = System.Drawing.SystemColors.Control;
            this.tbDatabasePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDatabasePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbDatabasePath.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.tbDatabasePath.Location = new System.Drawing.Point(17, 152);
            this.tbDatabasePath.Name = "tbDatabasePath";
            this.tbDatabasePath.Size = new System.Drawing.Size(402, 15);
            this.tbDatabasePath.TabIndex = 5;
            this.tbDatabasePath.Text = "Database: C:\\Program Files\\United Package\\Programs";
            this.tbDatabasePath.Click += new System.EventHandler(this.tbDatabasePath_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnInstall;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(597, 182);
            this.Controls.Add(this.tbDatabasePath);
            this.Controls.Add(this.tbManagerPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "United Package Installer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbManagerPath;
        private System.Windows.Forms.TextBox tbDatabasePath;
    }
}

