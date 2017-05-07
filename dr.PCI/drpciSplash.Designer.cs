namespace dr.PCI
{
    partial class drpciSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(drpciSplash));
            this.drpciSplashBtnCancel = new System.Windows.Forms.Button();
            this.drpciSplashLblStatus = new System.Windows.Forms.Label();
            this.drpciSplashLblLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drpciSplashBtnCancel
            // 
            this.drpciSplashBtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpciSplashBtnCancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.drpciSplashBtnCancel.Location = new System.Drawing.Point(313, 195);
            this.drpciSplashBtnCancel.Name = "drpciSplashBtnCancel";
            this.drpciSplashBtnCancel.Size = new System.Drawing.Size(75, 23);
            this.drpciSplashBtnCancel.TabIndex = 0;
            this.drpciSplashBtnCancel.Text = "Cancel";
            this.drpciSplashBtnCancel.UseVisualStyleBackColor = true;
            // 
            // drpciSplashLblStatus
            // 
            this.drpciSplashLblStatus.AutoSize = true;
            this.drpciSplashLblStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.drpciSplashLblStatus.Location = new System.Drawing.Point(12, 200);
            this.drpciSplashLblStatus.Name = "drpciSplashLblStatus";
            this.drpciSplashLblStatus.Size = new System.Drawing.Size(107, 13);
            this.drpciSplashLblStatus.TabIndex = 1;
            this.drpciSplashLblStatus.Text = "drpciSplashTxtStatus";
            // 
            // drpciSplashLblLabel
            // 
            this.drpciSplashLblLabel.AutoSize = true;
            this.drpciSplashLblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpciSplashLblLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.drpciSplashLblLabel.Location = new System.Drawing.Point(92, 64);
            this.drpciSplashLblLabel.Name = "drpciSplashLblLabel";
            this.drpciSplashLblLabel.Size = new System.Drawing.Size(214, 73);
            this.drpciSplashLblLabel.TabIndex = 2;
            this.drpciSplashLblLabel.Text = "dr.PCI";
            // 
            // drpciSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 230);
            this.ControlBox = false;
            this.Controls.Add(this.drpciSplashLblLabel);
            this.Controls.Add(this.drpciSplashLblStatus);
            this.Controls.Add(this.drpciSplashBtnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "drpciSplash";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "drpciSplash";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.drpciSplash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drpciSplashBtnCancel;
        private System.Windows.Forms.Label drpciSplashLblStatus;
        private System.Windows.Forms.Label drpciSplashLblLabel;
    }
}