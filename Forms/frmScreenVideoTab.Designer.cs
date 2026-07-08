namespace Screenshot_X.Forms
{
    partial class frmScreenVideoTab
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
            this.pnlVideoTab = new Guna.UI2.WinForms.Guna2Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.pbStartRecording = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbMic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.RecordTime = new System.Windows.Forms.Timer(this.components);
            this.pnlVideoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStartRecording)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVideoTab
            // 
            this.pnlVideoTab.BackColor = System.Drawing.Color.Transparent;
            this.pnlVideoTab.BackgroundImage = global::Screenshot_X.Properties.Resources.BackGround_Gray1;
            this.pnlVideoTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlVideoTab.Controls.Add(this.lblExit);
            this.pnlVideoTab.Controls.Add(this.lblCounter);
            this.pnlVideoTab.Controls.Add(this.pbStartRecording);
            this.pnlVideoTab.Controls.Add(this.pbMic);
            this.pnlVideoTab.Location = new System.Drawing.Point(91, 58);
            this.pnlVideoTab.Name = "pnlVideoTab";
            this.pnlVideoTab.Size = new System.Drawing.Size(398, 73);
            this.pnlVideoTab.TabIndex = 0;
            this.pnlVideoTab.UseTransparentBackground = true;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblExit.Location = new System.Drawing.Point(311, 21);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(27, 30);
            this.lblExit.TabIndex = 3;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCounter.Location = new System.Drawing.Point(157, 21);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(89, 30);
            this.lblCounter.TabIndex = 2;
            this.lblCounter.Text = "00:00:00";
            // 
            // pbStartRecording
            // 
            this.pbStartRecording.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbStartRecording.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStartRecording.FillColor = System.Drawing.Color.Transparent;
            this.pbStartRecording.Image = global::Screenshot_X.Properties.Resources.Record_Video;
            this.pbStartRecording.ImageRotate = 0F;
            this.pbStartRecording.Location = new System.Drawing.Point(69, 12);
            this.pbStartRecording.Name = "pbStartRecording";
            this.pbStartRecording.Size = new System.Drawing.Size(82, 49);
            this.pbStartRecording.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStartRecording.TabIndex = 1;
            this.pbStartRecording.TabStop = false;
            this.pbStartRecording.UseTransparentBackground = true;
            this.pbStartRecording.Click += new System.EventHandler(this.pbStartRecording_Click);
            // 
            // pbMic
            // 
            this.pbMic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMic.FillColor = System.Drawing.Color.Transparent;
            this.pbMic.Image = global::Screenshot_X.Properties.Resources.Muted;
            this.pbMic.ImageRotate = 0F;
            this.pbMic.Location = new System.Drawing.Point(261, 21);
            this.pbMic.Name = "pbMic";
            this.pbMic.Size = new System.Drawing.Size(30, 30);
            this.pbMic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMic.TabIndex = 0;
            this.pbMic.TabStop = false;
            this.pbMic.UseTransparentBackground = true;
            this.pbMic.Click += new System.EventHandler(this.pbMic_Click);
            // 
            // RecordTime
            // 
            this.RecordTime.Interval = 1000;
            this.RecordTime.Tick += new System.EventHandler(this.RecordTime_Tick);
            // 
            // frmScreenVideoTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(576, 188);
            this.Controls.Add(this.pnlVideoTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmScreenVideoTab";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmScreenVideo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmScreenVideoTab_Load);
            this.pnlVideoTab.ResumeLayout(false);
            this.pnlVideoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStartRecording)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlVideoTab;
        private Guna.UI2.WinForms.Guna2PictureBox pbMic;
        private Guna.UI2.WinForms.Guna2PictureBox pbStartRecording;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Timer RecordTime;
    }
}