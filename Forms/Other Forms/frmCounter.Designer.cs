namespace Screenshot_X.Forms
{
    partial class frmCounter
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
            this.components = new System.ComponentModel.Container();
            this.CountDownTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlCountDownTimer = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCountDownTimer = new System.Windows.Forms.Label();
            this.pnlCountDownTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // CountDownTimer
            // 
            this.CountDownTimer.Interval = 1000;
            this.CountDownTimer.Tick += new System.EventHandler(this.CountDownTimer_Tick);
            // 
            // pnlCountDownTimer
            // 
            this.pnlCountDownTimer.BackColor = System.Drawing.Color.Transparent;
            this.pnlCountDownTimer.BackgroundImage = global::Screenshot_X.Properties.Resources.Rexord_Setting_Tab;
            this.pnlCountDownTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlCountDownTimer.Controls.Add(this.lblCountDownTimer);
            this.pnlCountDownTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCountDownTimer.Location = new System.Drawing.Point(0, 0);
            this.pnlCountDownTimer.Name = "pnlCountDownTimer";
            this.pnlCountDownTimer.Size = new System.Drawing.Size(322, 210);
            this.pnlCountDownTimer.TabIndex = 11;
            // 
            // lblCountDownTimer
            // 
            this.lblCountDownTimer.AutoSize = true;
            this.lblCountDownTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblCountDownTimer.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDownTimer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCountDownTimer.Location = new System.Drawing.Point(124, 62);
            this.lblCountDownTimer.Name = "lblCountDownTimer";
            this.lblCountDownTimer.Size = new System.Drawing.Size(74, 86);
            this.lblCountDownTimer.TabIndex = 8;
            this.lblCountDownTimer.Text = "3";
            this.lblCountDownTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(322, 210);
            this.ControlBox = false;
            this.Controls.Add(this.pnlCountDownTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCounter";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCounter";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCounter_Load);
            this.pnlCountDownTimer.ResumeLayout(false);
            this.pnlCountDownTimer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Timer CountDownTimer;
        public Guna.UI2.WinForms.Guna2Panel pnlCountDownTimer;
        public System.Windows.Forms.Label lblCountDownTimer;
    }
}