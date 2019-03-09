namespace UnitedPackageManager.UI
{
    partial class InstallFinalize
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
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbWPF = new System.Windows.Forms.RadioButton();
            this.rbForms = new System.Windows.Forms.RadioButton();
            this.rbCLI = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(369, 177);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Installation Complete";
            // 
            // rbWPF
            // 
            this.rbWPF.AutoSize = true;
            this.rbWPF.Checked = true;
            this.rbWPF.Location = new System.Drawing.Point(17, 41);
            this.rbWPF.Name = "rbWPF";
            this.rbWPF.Size = new System.Drawing.Size(187, 17);
            this.rbWPF.TabIndex = 2;
            this.rbWPF.TabStop = true;
            this.rbWPF.Text = "Use default drawing engine (WPF)";
            this.rbWPF.UseVisualStyleBackColor = true;
            // 
            // rbForms
            // 
            this.rbForms.AutoSize = true;
            this.rbForms.Location = new System.Drawing.Point(17, 64);
            this.rbForms.Name = "rbForms";
            this.rbForms.Size = new System.Drawing.Size(100, 17);
            this.rbForms.TabIndex = 3;
            this.rbForms.Text = "Windows Forms";
            this.rbForms.UseVisualStyleBackColor = true;
            // 
            // rbCLI
            // 
            this.rbCLI.AutoSize = true;
            this.rbCLI.Location = new System.Drawing.Point(17, 87);
            this.rbCLI.Name = "rbCLI";
            this.rbCLI.Size = new System.Drawing.Size(63, 17);
            this.rbCLI.TabIndex = 4;
            this.rbCLI.Text = "Console";
            this.rbCLI.UseVisualStyleBackColor = true;
            // 
            // InstallFinalize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 212);
            this.ControlBox = false;
            this.Controls.Add(this.rbCLI);
            this.Controls.Add(this.rbForms);
            this.Controls.Add(this.rbWPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InstallFinalize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "United Package Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbWPF;
        private System.Windows.Forms.RadioButton rbForms;
        private System.Windows.Forms.RadioButton rbCLI;
    }
}