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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScreenVideoTab));
            this.RecordTime = new System.Windows.Forms.Timer(this.components);
            this.CountDownTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlCountDownTimer = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCountDownTimer = new System.Windows.Forms.Label();
            this.pnlRecordSettingTab = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDash2 = new System.Windows.Forms.Label();
            this.lblDash1 = new System.Windows.Forms.Label();
            this.lblSetCountdownInSec = new System.Windows.Forms.Label();
            this.tbxCountdown_Sec = new Guna.UI2.WinForms.Guna2TextBox();
            this.ckbHideTab = new System.Windows.Forms.CheckBox();
            this.cmbResolution = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlVideoTab = new Guna.UI2.WinForms.Guna2Panel();
            this.pbRecordSetting = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblRecordingTime = new System.Windows.Forms.Label();
            this.pbStartRecording = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbMic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbMoveButton = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlCountDownTimer.SuspendLayout();
            this.pnlRecordSettingTab.SuspendLayout();
            this.pnlVideoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecordSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStartRecording)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoveButton)).BeginInit();
            this.SuspendLayout();
            // 
            // RecordTime
            // 
            this.RecordTime.Interval = 1000;
            this.RecordTime.Tick += new System.EventHandler(this.RecordTime_Tick);
            // 
            // CountDownTimer
            // 
            this.CountDownTimer.Interval = 1000;
            this.CountDownTimer.Tick += new System.EventHandler(this.CountDownTimer_Tick);
            // 
            // pnlCountDownTimer
            // 
            this.pnlCountDownTimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCountDownTimer.BackgroundImage")));
            this.pnlCountDownTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlCountDownTimer.Controls.Add(this.lblCountDownTimer);
            this.pnlCountDownTimer.Location = new System.Drawing.Point(409, 330);
            this.pnlCountDownTimer.Name = "pnlCountDownTimer";
            this.pnlCountDownTimer.Size = new System.Drawing.Size(317, 208);
            this.pnlCountDownTimer.TabIndex = 9;
            this.pnlCountDownTimer.Visible = false;
            // 
            // lblCountDownTimer
            // 
            this.lblCountDownTimer.AutoSize = true;
            this.lblCountDownTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblCountDownTimer.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDownTimer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCountDownTimer.Location = new System.Drawing.Point(121, 61);
            this.lblCountDownTimer.Name = "lblCountDownTimer";
            this.lblCountDownTimer.Size = new System.Drawing.Size(74, 86);
            this.lblCountDownTimer.TabIndex = 8;
            this.lblCountDownTimer.Text = "3";
            this.lblCountDownTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRecordSettingTab
            // 
            this.pnlRecordSettingTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRecordSettingTab.BackgroundImage")));
            this.pnlRecordSettingTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlRecordSettingTab.Controls.Add(this.lblDash2);
            this.pnlRecordSettingTab.Controls.Add(this.lblDash1);
            this.pnlRecordSettingTab.Controls.Add(this.lblSetCountdownInSec);
            this.pnlRecordSettingTab.Controls.Add(this.tbxCountdown_Sec);
            this.pnlRecordSettingTab.Controls.Add(this.ckbHideTab);
            this.pnlRecordSettingTab.Controls.Add(this.cmbResolution);
            this.pnlRecordSettingTab.Location = new System.Drawing.Point(535, 80);
            this.pnlRecordSettingTab.Name = "pnlRecordSettingTab";
            this.pnlRecordSettingTab.Size = new System.Drawing.Size(317, 208);
            this.pnlRecordSettingTab.TabIndex = 7;
            this.pnlRecordSettingTab.Visible = false;
            // 
            // lblDash2
            // 
            this.lblDash2.AutoSize = true;
            this.lblDash2.BackColor = System.Drawing.Color.Silver;
            this.lblDash2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDash2.Location = new System.Drawing.Point(46, 124);
            this.lblDash2.Name = "lblDash2";
            this.lblDash2.Size = new System.Drawing.Size(225, 20);
            this.lblDash2.TabIndex = 9;
            this.lblDash2.Text = "____________________________________";
            this.lblDash2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDash1
            // 
            this.lblDash1.AutoSize = true;
            this.lblDash1.BackColor = System.Drawing.Color.Silver;
            this.lblDash1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDash1.Location = new System.Drawing.Point(46, 56);
            this.lblDash1.Name = "lblDash1";
            this.lblDash1.Size = new System.Drawing.Size(225, 20);
            this.lblDash1.TabIndex = 8;
            this.lblDash1.Text = "____________________________________";
            this.lblDash1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSetCountdownInSec
            // 
            this.lblSetCountdownInSec.AutoSize = true;
            this.lblSetCountdownInSec.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetCountdownInSec.Location = new System.Drawing.Point(67, 84);
            this.lblSetCountdownInSec.Name = "lblSetCountdownInSec";
            this.lblSetCountdownInSec.Size = new System.Drawing.Size(94, 40);
            this.lblSetCountdownInSec.TabIndex = 7;
            this.lblSetCountdownInSec.Text = "Set Counter\r\n( In Seconds)\r\n";
            this.lblSetCountdownInSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxCountdown_Sec
            // 
            this.tbxCountdown_Sec.Animated = true;
            this.tbxCountdown_Sec.BorderRadius = 6;
            this.tbxCountdown_Sec.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxCountdown_Sec.DefaultText = "3";
            this.tbxCountdown_Sec.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxCountdown_Sec.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxCountdown_Sec.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxCountdown_Sec.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxCountdown_Sec.FillColor = System.Drawing.Color.Gainsboro;
            this.tbxCountdown_Sec.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxCountdown_Sec.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxCountdown_Sec.ForeColor = System.Drawing.Color.Black;
            this.tbxCountdown_Sec.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxCountdown_Sec.Location = new System.Drawing.Point(192, 84);
            this.tbxCountdown_Sec.Name = "tbxCountdown_Sec";
            this.tbxCountdown_Sec.PlaceholderText = "";
            this.tbxCountdown_Sec.SelectedText = "";
            this.tbxCountdown_Sec.Size = new System.Drawing.Size(53, 40);
            this.tbxCountdown_Sec.TabIndex = 6;
            this.tbxCountdown_Sec.TextChanged += new System.EventHandler(this.tbxCountdown_Sec_TextChanged);
            // 
            // ckbHideTab
            // 
            this.ckbHideTab.AutoSize = true;
            this.ckbHideTab.BackColor = System.Drawing.Color.Transparent;
            this.ckbHideTab.Checked = true;
            this.ckbHideTab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbHideTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHideTab.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ckbHideTab.Location = new System.Drawing.Point(58, 32);
            this.ckbHideTab.Name = "ckbHideTab";
            this.ckbHideTab.Size = new System.Drawing.Size(200, 21);
            this.ckbHideTab.TabIndex = 5;
            this.ckbHideTab.Text = "Hide This Tab With Recording";
            this.ckbHideTab.UseVisualStyleBackColor = false;
            this.ckbHideTab.CheckedChanged += new System.EventHandler(this.ckbHideTab_CheckedChanged);
            // 
            // cmbResolution
            // 
            this.cmbResolution.AutoRoundedCorners = true;
            this.cmbResolution.BackColor = System.Drawing.Color.Transparent;
            this.cmbResolution.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbResolution.BorderRadius = 17;
            this.cmbResolution.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.cmbResolution.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResolution.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cmbResolution.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbResolution.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbResolution.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbResolution.ForeColor = System.Drawing.Color.White;
            this.cmbResolution.ItemHeight = 30;
            this.cmbResolution.Items.AddRange(new object[] {
            "1920 × 1080 (Full HD)",
            "",
            "1280 × 720 (HD)",
            "",
            "854 × 480 (SD)"});
            this.cmbResolution.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.cmbResolution.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.cmbResolution.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbResolution.Location = new System.Drawing.Point(53, 151);
            this.cmbResolution.Name = "cmbResolution";
            this.cmbResolution.Size = new System.Drawing.Size(210, 36);
            this.cmbResolution.TabIndex = 4;
            // 
            // pnlVideoTab
            // 
            this.pnlVideoTab.BackColor = System.Drawing.Color.Transparent;
            this.pnlVideoTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlVideoTab.BackgroundImage")));
            this.pnlVideoTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlVideoTab.Controls.Add(this.pbMoveButton);
            this.pnlVideoTab.Controls.Add(this.pbRecordSetting);
            this.pnlVideoTab.Controls.Add(this.lblRecordingTime);
            this.pnlVideoTab.Controls.Add(this.pbStartRecording);
            this.pnlVideoTab.Controls.Add(this.pbExit);
            this.pnlVideoTab.Controls.Add(this.pbMic);
            this.pnlVideoTab.Location = new System.Drawing.Point(332, 12);
            this.pnlVideoTab.Name = "pnlVideoTab";
            this.pnlVideoTab.Size = new System.Drawing.Size(470, 62);
            this.pnlVideoTab.TabIndex = 0;
            this.pnlVideoTab.UseTransparentBackground = true;
            this.pnlVideoTab.Click += new System.EventHandler(this.pnlVideoTab_Click);
            // 
            // pbRecordSetting
            // 
            this.pbRecordSetting.BackColor = System.Drawing.Color.Transparent;
            this.pbRecordSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbRecordSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRecordSetting.FillColor = System.Drawing.Color.Transparent;
            this.pbRecordSetting.Image = ((System.Drawing.Image)(resources.GetObject("pbRecordSetting.Image")));
            this.pbRecordSetting.ImageRotate = 0F;
            this.pbRecordSetting.Location = new System.Drawing.Point(334, 16);
            this.pbRecordSetting.Name = "pbRecordSetting";
            this.pbRecordSetting.Size = new System.Drawing.Size(30, 30);
            this.pbRecordSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRecordSetting.TabIndex = 5;
            this.pbRecordSetting.TabStop = false;
            this.pbRecordSetting.UseTransparentBackground = true;
            this.pbRecordSetting.Click += new System.EventHandler(this.pbResolutionSetting_Click);
            // 
            // lblRecordingTime
            // 
            this.lblRecordingTime.AutoSize = true;
            this.lblRecordingTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordingTime.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRecordingTime.Location = new System.Drawing.Point(134, 16);
            this.lblRecordingTime.Name = "lblRecordingTime";
            this.lblRecordingTime.Size = new System.Drawing.Size(89, 30);
            this.lblRecordingTime.TabIndex = 2;
            this.lblRecordingTime.Text = "00:00:00";
            // 
            // pbStartRecording
            // 
            this.pbStartRecording.BackColor = System.Drawing.Color.Transparent;
            this.pbStartRecording.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbStartRecording.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStartRecording.FillColor = System.Drawing.Color.Transparent;
            this.pbStartRecording.Image = ((System.Drawing.Image)(resources.GetObject("pbStartRecording.Image")));
            this.pbStartRecording.ImageRotate = 0F;
            this.pbStartRecording.Location = new System.Drawing.Point(38, 12);
            this.pbStartRecording.Name = "pbStartRecording";
            this.pbStartRecording.Size = new System.Drawing.Size(62, 39);
            this.pbStartRecording.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStartRecording.TabIndex = 1;
            this.pbStartRecording.TabStop = false;
            this.pbStartRecording.UseTransparentBackground = true;
            this.pbStartRecording.Click += new System.EventHandler(this.pbStartRecording_Click);
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.FillColor = System.Drawing.Color.Transparent;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.ImageRotate = 0F;
            this.pbExit.Location = new System.Drawing.Point(405, 16);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(30, 30);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 4;
            this.pbExit.TabStop = false;
            this.pbExit.UseTransparentBackground = true;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // pbMic
            // 
            this.pbMic.BackColor = System.Drawing.Color.Transparent;
            this.pbMic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMic.FillColor = System.Drawing.Color.Transparent;
            this.pbMic.Image = ((System.Drawing.Image)(resources.GetObject("pbMic.Image")));
            this.pbMic.ImageRotate = 0F;
            this.pbMic.Location = new System.Drawing.Point(269, 16);
            this.pbMic.Name = "pbMic";
            this.pbMic.Size = new System.Drawing.Size(30, 30);
            this.pbMic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMic.TabIndex = 0;
            this.pbMic.TabStop = false;
            this.pbMic.UseTransparentBackground = true;
            this.pbMic.Click += new System.EventHandler(this.pbMic_Click);
            // 
            // pbMoveButton
            // 
            this.pbMoveButton.BackColor = System.Drawing.Color.Transparent;
            this.pbMoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMoveButton.Image = global::Screenshot_X.Properties.Resources.Active_indicator;
            this.pbMoveButton.ImageRotate = 90F;
            this.pbMoveButton.Location = new System.Drawing.Point(-13, 11);
            this.pbMoveButton.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
            this.pbMoveButton.Name = "pbMoveButton";
            this.pbMoveButton.Size = new System.Drawing.Size(65, 41);
            this.pbMoveButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMoveButton.TabIndex = 14;
            this.pbMoveButton.TabStop = false;
            this.pbMoveButton.UseTransparentBackground = true;
            this.pbMoveButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMoveButton_MouseDown);
            // 
            // frmScreenVideoTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1134, 550);
            this.Controls.Add(this.pnlCountDownTimer);
            this.Controls.Add(this.pnlRecordSettingTab);
            this.Controls.Add(this.pnlVideoTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmScreenVideoTab";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmScreenVideo";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.frmScreenVideoTab_Deactivate);
            this.Load += new System.EventHandler(this.frmScreenVideoTab_Load);
            this.LocationChanged += new System.EventHandler(this.frmScreenVideoTab_LocationChanged);
            this.pnlCountDownTimer.ResumeLayout(false);
            this.pnlCountDownTimer.PerformLayout();
            this.pnlRecordSettingTab.ResumeLayout(false);
            this.pnlRecordSettingTab.PerformLayout();
            this.pnlVideoTab.ResumeLayout(false);
            this.pnlVideoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecordSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStartRecording)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoveButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlVideoTab;
        private Guna.UI2.WinForms.Guna2PictureBox pbMic;
        private Guna.UI2.WinForms.Guna2PictureBox pbStartRecording;
        private System.Windows.Forms.Label lblRecordingTime;
        private System.Windows.Forms.Timer RecordTime;
        private Guna.UI2.WinForms.Guna2ComboBox cmbResolution;
        private Guna.UI2.WinForms.Guna2PictureBox pbExit;
        private Guna.UI2.WinForms.Guna2PictureBox pbRecordSetting;
        private Guna.UI2.WinForms.Guna2Panel pnlRecordSettingTab;
        private System.Windows.Forms.CheckBox ckbHideTab;
        private Guna.UI2.WinForms.Guna2TextBox tbxCountdown_Sec;
        private System.Windows.Forms.Label lblSetCountdownInSec;
        private System.Windows.Forms.Timer CountDownTimer;
        private System.Windows.Forms.Label lblCountDownTimer;
        private Guna.UI2.WinForms.Guna2Panel pnlCountDownTimer;
        private System.Windows.Forms.Label lblDash2;
        private System.Windows.Forms.Label lblDash1;
        private Guna.UI2.WinForms.Guna2PictureBox pbMoveButton;
    }
}