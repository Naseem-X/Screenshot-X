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
            this.pnlRecordSettingTab = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlCameraBorderRadius = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCameraBorderRadius = new System.Windows.Forms.Label();
            this.tbxBorderRadius = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxCricleCamera = new System.Windows.Forms.CheckBox();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.tbxScreenVideoPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDefaultScreenshotPath = new System.Windows.Forms.Label();
            this.pnlResolution = new Guna.UI2.WinForms.Guna2Panel();
            this.lblResolution = new System.Windows.Forms.Label();
            this.cmbResolution = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlCamera = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.cmbCameraSize = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCameraSize = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMulti = new System.Windows.Forms.Label();
            this.lblCustomSize = new System.Windows.Forms.Label();
            this.tbxWidth = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxHeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblResetBorderRadius = new System.Windows.Forms.Label();
            this.lblResetSize = new System.Windows.Forms.Label();
            this.pnlCounter = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSetCountdownInSec = new System.Windows.Forms.Label();
            this.tbxCountdown_Sec = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlHideAndShowTab = new Guna.UI2.WinForms.Guna2Panel();
            this.ckbHideTab = new System.Windows.Forms.CheckBox();
            this.lblRecordSetting = new System.Windows.Forms.Label();
            this.pnlVideoTab = new Guna.UI2.WinForms.Guna2Panel();
            this.pbSystemSound = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbStartRecording = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlRecordingControl = new Guna.UI2.WinForms.Guna2Panel();
            this.pbPause = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbShowCameraPreview = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbMoveButton = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbRecordSetting = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblRecordingTime = new System.Windows.Forms.Label();
            this.pbExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbMic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbCameraPulseOn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlRecordSettingTab.SuspendLayout();
            this.pnlCameraBorderRadius.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.pnlResolution.SuspendLayout();
            this.pnlCamera.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.pnlCounter.SuspendLayout();
            this.pnlHideAndShowTab.SuspendLayout();
            this.pnlVideoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSystemSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStartRecording)).BeginInit();
            this.pnlRecordingControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowCameraPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecordSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCameraPulseOn)).BeginInit();
            this.SuspendLayout();
            // 
            // RecordTime
            // 
            this.RecordTime.Interval = 1000;
            this.RecordTime.Tick += new System.EventHandler(this.RecordTime_Tick);
            // 
            // pnlRecordSettingTab
            // 
            this.pnlRecordSettingTab.BackgroundImage = global::Screenshot_X.Properties.Resources.Rexord_Setting_Tab;
            this.pnlRecordSettingTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlRecordSettingTab.Controls.Add(this.pnlCameraBorderRadius);
            this.pnlRecordSettingTab.Controls.Add(this.guna2Panel4);
            this.pnlRecordSettingTab.Controls.Add(this.pnlResolution);
            this.pnlRecordSettingTab.Controls.Add(this.pnlCamera);
            this.pnlRecordSettingTab.Controls.Add(this.pnlCounter);
            this.pnlRecordSettingTab.Controls.Add(this.pnlHideAndShowTab);
            this.pnlRecordSettingTab.Controls.Add(this.lblRecordSetting);
            this.pnlRecordSettingTab.Location = new System.Drawing.Point(328, 80);
            this.pnlRecordSettingTab.Name = "pnlRecordSettingTab";
            this.pnlRecordSettingTab.Size = new System.Drawing.Size(478, 458);
            this.pnlRecordSettingTab.TabIndex = 7;
            this.pnlRecordSettingTab.Visible = false;
            // 
            // pnlCameraBorderRadius
            // 
            this.pnlCameraBorderRadius.BackColor = System.Drawing.Color.Transparent;
            this.pnlCameraBorderRadius.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlCameraBorderRadius.BorderThickness = 2;
            this.pnlCameraBorderRadius.Controls.Add(this.lblCameraBorderRadius);
            this.pnlCameraBorderRadius.Controls.Add(this.tbxBorderRadius);
            this.pnlCameraBorderRadius.Controls.Add(this.cbxCricleCamera);
            this.pnlCameraBorderRadius.Location = new System.Drawing.Point(24, 167);
            this.pnlCameraBorderRadius.Name = "pnlCameraBorderRadius";
            this.pnlCameraBorderRadius.Size = new System.Drawing.Size(431, 45);
            this.pnlCameraBorderRadius.TabIndex = 13;
            // 
            // lblCameraBorderRadius
            // 
            this.lblCameraBorderRadius.AutoSize = true;
            this.lblCameraBorderRadius.BackColor = System.Drawing.Color.Transparent;
            this.lblCameraBorderRadius.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCameraBorderRadius.ForeColor = System.Drawing.Color.White;
            this.lblCameraBorderRadius.Location = new System.Drawing.Point(12, 11);
            this.lblCameraBorderRadius.Name = "lblCameraBorderRadius";
            this.lblCameraBorderRadius.Size = new System.Drawing.Size(164, 20);
            this.lblCameraBorderRadius.TabIndex = 19;
            this.lblCameraBorderRadius.Text = "Camera Border Radius :";
            this.lblCameraBorderRadius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxBorderRadius
            // 
            this.tbxBorderRadius.Animated = true;
            this.tbxBorderRadius.BorderRadius = 6;
            this.tbxBorderRadius.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxBorderRadius.DefaultText = "30";
            this.tbxBorderRadius.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxBorderRadius.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxBorderRadius.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxBorderRadius.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxBorderRadius.FillColor = System.Drawing.Color.Gainsboro;
            this.tbxBorderRadius.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxBorderRadius.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBorderRadius.ForeColor = System.Drawing.Color.Black;
            this.tbxBorderRadius.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxBorderRadius.Location = new System.Drawing.Point(181, 9);
            this.tbxBorderRadius.Name = "tbxBorderRadius";
            this.tbxBorderRadius.PlaceholderText = "";
            this.tbxBorderRadius.SelectedText = "";
            this.tbxBorderRadius.Size = new System.Drawing.Size(119, 27);
            this.tbxBorderRadius.TabIndex = 17;
            this.tbxBorderRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxBorderRadius.TextChanged += new System.EventHandler(this.tbxBorderRadius_TextChanged);
            // 
            // cbxCricleCamera
            // 
            this.cbxCricleCamera.AutoSize = true;
            this.cbxCricleCamera.BackColor = System.Drawing.Color.Transparent;
            this.cbxCricleCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxCricleCamera.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCricleCamera.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbxCricleCamera.Location = new System.Drawing.Point(315, 12);
            this.cbxCricleCamera.Name = "cbxCricleCamera";
            this.cbxCricleCamera.Size = new System.Drawing.Size(108, 21);
            this.cbxCricleCamera.TabIndex = 25;
            this.cbxCricleCamera.Text = "Circle Camera";
            this.cbxCricleCamera.UseVisualStyleBackColor = false;
            this.cbxCricleCamera.Click += new System.EventHandler(this.cbxCricleCamea_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Panel4.BorderRadius = 5;
            this.guna2Panel4.BorderThickness = 2;
            this.guna2Panel4.Controls.Add(this.btnBrowseFolder);
            this.guna2Panel4.Controls.Add(this.tbxScreenVideoPath);
            this.guna2Panel4.Controls.Add(this.lblDefaultScreenshotPath);
            this.guna2Panel4.Location = new System.Drawing.Point(24, 387);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(431, 41);
            this.guna2Panel4.TabIndex = 12;
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseFolder.Location = new System.Drawing.Point(384, 11);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(31, 23);
            this.btnBrowseFolder.TabIndex = 33;
            this.btnBrowseFolder.Text = "...";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // tbxScreenVideoPath
            // 
            this.tbxScreenVideoPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbxScreenVideoPath.DefaultText = "Videos";
            this.tbxScreenVideoPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxScreenVideoPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxScreenVideoPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxScreenVideoPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxScreenVideoPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxScreenVideoPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxScreenVideoPath.ForeColor = System.Drawing.Color.Black;
            this.tbxScreenVideoPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxScreenVideoPath.Location = new System.Drawing.Point(227, 10);
            this.tbxScreenVideoPath.Name = "tbxScreenVideoPath";
            this.tbxScreenVideoPath.PlaceholderText = "";
            this.tbxScreenVideoPath.ReadOnly = true;
            this.tbxScreenVideoPath.SelectedText = "";
            this.tbxScreenVideoPath.Size = new System.Drawing.Size(150, 24);
            this.tbxScreenVideoPath.TabIndex = 32;
            // 
            // lblDefaultScreenshotPath
            // 
            this.lblDefaultScreenshotPath.AutoSize = true;
            this.lblDefaultScreenshotPath.BackColor = System.Drawing.Color.Transparent;
            this.lblDefaultScreenshotPath.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultScreenshotPath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDefaultScreenshotPath.Location = new System.Drawing.Point(9, 10);
            this.lblDefaultScreenshotPath.Name = "lblDefaultScreenshotPath";
            this.lblDefaultScreenshotPath.Size = new System.Drawing.Size(188, 20);
            this.lblDefaultScreenshotPath.TabIndex = 31;
            this.lblDefaultScreenshotPath.Text = "Default Screen Video Path :";
            this.lblDefaultScreenshotPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlResolution
            // 
            this.pnlResolution.BackColor = System.Drawing.Color.Transparent;
            this.pnlResolution.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlResolution.BorderRadius = 5;
            this.pnlResolution.BorderThickness = 2;
            this.pnlResolution.Controls.Add(this.lblResolution);
            this.pnlResolution.Controls.Add(this.cmbResolution);
            this.pnlResolution.Location = new System.Drawing.Point(24, 331);
            this.pnlResolution.Name = "pnlResolution";
            this.pnlResolution.Size = new System.Drawing.Size(431, 50);
            this.pnlResolution.TabIndex = 13;
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.BackColor = System.Drawing.Color.Transparent;
            this.lblResolution.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResolution.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResolution.Location = new System.Drawing.Point(9, 15);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(86, 20);
            this.lblResolution.TabIndex = 28;
            this.lblResolution.Text = "Resolution :";
            this.lblResolution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbResolution
            // 
            this.cmbResolution.AutoRoundedCorners = true;
            this.cmbResolution.BackColor = System.Drawing.Color.Transparent;
            this.cmbResolution.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbResolution.BorderRadius = 17;
            this.cmbResolution.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.cmbResolution.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.cmbResolution.Location = new System.Drawing.Point(127, 7);
            this.cmbResolution.Name = "cmbResolution";
            this.cmbResolution.Size = new System.Drawing.Size(301, 36);
            this.cmbResolution.TabIndex = 4;
            this.cmbResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlCamera
            // 
            this.pnlCamera.BackColor = System.Drawing.Color.Transparent;
            this.pnlCamera.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlCamera.BorderRadius = 5;
            this.pnlCamera.BorderThickness = 2;
            this.pnlCamera.Controls.Add(this.guna2Panel2);
            this.pnlCamera.Controls.Add(this.guna2Panel3);
            this.pnlCamera.Controls.Add(this.lblResetBorderRadius);
            this.pnlCamera.Controls.Add(this.lblResetSize);
            this.pnlCamera.Location = new System.Drawing.Point(24, 45);
            this.pnlCamera.Name = "pnlCamera";
            this.pnlCamera.Size = new System.Drawing.Size(431, 170);
            this.pnlCamera.TabIndex = 11;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.cmbCameraSize);
            this.guna2Panel2.Controls.Add(this.lblCameraSize);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(431, 60);
            this.guna2Panel2.TabIndex = 14;
            // 
            // cmbCameraSize
            // 
            this.cmbCameraSize.AutoRoundedCorners = true;
            this.cmbCameraSize.BackColor = System.Drawing.Color.Transparent;
            this.cmbCameraSize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbCameraSize.BorderRadius = 17;
            this.cmbCameraSize.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.cmbCameraSize.CausesValidation = false;
            this.cmbCameraSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCameraSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCameraSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCameraSize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cmbCameraSize.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCameraSize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCameraSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCameraSize.ForeColor = System.Drawing.Color.White;
            this.cmbCameraSize.ItemHeight = 30;
            this.cmbCameraSize.Items.AddRange(new object[] {
            "Small (Default)",
            "Meduim",
            "Large",
            "Custom"});
            this.cmbCameraSize.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.cmbCameraSize.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.cmbCameraSize.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbCameraSize.Location = new System.Drawing.Point(124, 12);
            this.cmbCameraSize.Name = "cmbCameraSize";
            this.cmbCameraSize.Size = new System.Drawing.Size(299, 36);
            this.cmbCameraSize.TabIndex = 20;
            this.cmbCameraSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbCameraSize.SelectedIndexChanged += new System.EventHandler(this.cmbCameraSize_SelectedIndexChanged);
            // 
            // lblCameraSize
            // 
            this.lblCameraSize.AutoSize = true;
            this.lblCameraSize.BackColor = System.Drawing.Color.Transparent;
            this.lblCameraSize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCameraSize.ForeColor = System.Drawing.Color.White;
            this.lblCameraSize.Location = new System.Drawing.Point(20, 20);
            this.lblCameraSize.Name = "lblCameraSize";
            this.lblCameraSize.Size = new System.Drawing.Size(98, 20);
            this.lblCameraSize.TabIndex = 11;
            this.lblCameraSize.Text = "Camera Size :";
            this.lblCameraSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCameraSize.Click += new System.EventHandler(this.lblCameraSize_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.lblMulti);
            this.guna2Panel3.Controls.Add(this.lblCustomSize);
            this.guna2Panel3.Controls.Add(this.tbxWidth);
            this.guna2Panel3.Controls.Add(this.tbxHeight);
            this.guna2Panel3.Location = new System.Drawing.Point(0, 54);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(431, 71);
            this.guna2Panel3.TabIndex = 13;
            // 
            // lblMulti
            // 
            this.lblMulti.AutoSize = true;
            this.lblMulti.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMulti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMulti.Location = new System.Drawing.Point(260, 17);
            this.lblMulti.Name = "lblMulti";
            this.lblMulti.Size = new System.Drawing.Size(35, 37);
            this.lblMulti.TabIndex = 23;
            this.lblMulti.Text = "X";
            this.lblMulti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomSize
            // 
            this.lblCustomSize.AutoSize = true;
            this.lblCustomSize.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomSize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomSize.ForeColor = System.Drawing.Color.White;
            this.lblCustomSize.Location = new System.Drawing.Point(12, 25);
            this.lblCustomSize.Name = "lblCustomSize";
            this.lblCustomSize.Size = new System.Drawing.Size(93, 20);
            this.lblCustomSize.TabIndex = 27;
            this.lblCustomSize.Text = "Custom Size:";
            this.lblCustomSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxWidth
            // 
            this.tbxWidth.BorderRadius = 6;
            this.tbxWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxWidth.DefaultText = "192";
            this.tbxWidth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxWidth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxWidth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxWidth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxWidth.Enabled = false;
            this.tbxWidth.FillColor = System.Drawing.Color.Gainsboro;
            this.tbxWidth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxWidth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbxWidth.ForeColor = System.Drawing.Color.Black;
            this.tbxWidth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxWidth.Location = new System.Drawing.Point(127, 14);
            this.tbxWidth.Name = "tbxWidth";
            this.tbxWidth.PlaceholderText = "";
            this.tbxWidth.SelectedText = "";
            this.tbxWidth.Size = new System.Drawing.Size(99, 42);
            this.tbxWidth.TabIndex = 21;
            this.tbxWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxWidth.TextChanged += new System.EventHandler(this.tbxWidth_TextChanged);
            // 
            // tbxHeight
            // 
            this.tbxHeight.BorderRadius = 6;
            this.tbxHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxHeight.DefaultText = "111";
            this.tbxHeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxHeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxHeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxHeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxHeight.Enabled = false;
            this.tbxHeight.FillColor = System.Drawing.Color.Gainsboro;
            this.tbxHeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxHeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbxHeight.ForeColor = System.Drawing.Color.Black;
            this.tbxHeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxHeight.Location = new System.Drawing.Point(324, 14);
            this.tbxHeight.Name = "tbxHeight";
            this.tbxHeight.PlaceholderText = "";
            this.tbxHeight.SelectedText = "";
            this.tbxHeight.Size = new System.Drawing.Size(99, 42);
            this.tbxHeight.TabIndex = 22;
            this.tbxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxHeight.TextChanged += new System.EventHandler(this.tbxHeight_TextChanged);
            // 
            // lblResetBorderRadius
            // 
            this.lblResetBorderRadius.AutoSize = true;
            this.lblResetBorderRadius.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblResetBorderRadius.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetBorderRadius.Location = new System.Drawing.Point(269, 138);
            this.lblResetBorderRadius.Name = "lblResetBorderRadius";
            this.lblResetBorderRadius.Size = new System.Drawing.Size(45, 20);
            this.lblResetBorderRadius.TabIndex = 18;
            this.lblResetBorderRadius.Text = "Reset";
            this.lblResetBorderRadius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResetBorderRadius.Click += new System.EventHandler(this.lblResetBorderRadius_Click);
            // 
            // lblResetSize
            // 
            this.lblResetSize.AutoSize = true;
            this.lblResetSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblResetSize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetSize.Location = new System.Drawing.Point(301, 63);
            this.lblResetSize.Name = "lblResetSize";
            this.lblResetSize.Size = new System.Drawing.Size(45, 20);
            this.lblResetSize.TabIndex = 24;
            this.lblResetSize.Text = "Reset";
            this.lblResetSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResetSize.Click += new System.EventHandler(this.lblResetSize_Click);
            // 
            // pnlCounter
            // 
            this.pnlCounter.BackColor = System.Drawing.Color.Transparent;
            this.pnlCounter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlCounter.BorderRadius = 5;
            this.pnlCounter.BorderThickness = 2;
            this.pnlCounter.Controls.Add(this.lblSetCountdownInSec);
            this.pnlCounter.Controls.Add(this.tbxCountdown_Sec);
            this.pnlCounter.Location = new System.Drawing.Point(24, 268);
            this.pnlCounter.Name = "pnlCounter";
            this.pnlCounter.Size = new System.Drawing.Size(431, 57);
            this.pnlCounter.TabIndex = 13;
            // 
            // lblSetCountdownInSec
            // 
            this.lblSetCountdownInSec.AutoSize = true;
            this.lblSetCountdownInSec.BackColor = System.Drawing.Color.Transparent;
            this.lblSetCountdownInSec.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetCountdownInSec.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSetCountdownInSec.Location = new System.Drawing.Point(12, 18);
            this.lblSetCountdownInSec.Name = "lblSetCountdownInSec";
            this.lblSetCountdownInSec.Size = new System.Drawing.Size(178, 20);
            this.lblSetCountdownInSec.TabIndex = 7;
            this.lblSetCountdownInSec.Text = "Set Counter ( In Seconds):";
            this.lblSetCountdownInSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxCountdown_Sec
            // 
            this.tbxCountdown_Sec.Animated = true;
            this.tbxCountdown_Sec.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbxCountdown_Sec.BorderRadius = 7;
            this.tbxCountdown_Sec.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.tbxCountdown_Sec.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxCountdown_Sec.DefaultText = "3";
            this.tbxCountdown_Sec.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxCountdown_Sec.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxCountdown_Sec.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxCountdown_Sec.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxCountdown_Sec.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tbxCountdown_Sec.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxCountdown_Sec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCountdown_Sec.ForeColor = System.Drawing.Color.Silver;
            this.tbxCountdown_Sec.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxCountdown_Sec.Location = new System.Drawing.Point(216, 11);
            this.tbxCountdown_Sec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxCountdown_Sec.Name = "tbxCountdown_Sec";
            this.tbxCountdown_Sec.PlaceholderText = "";
            this.tbxCountdown_Sec.SelectedText = "";
            this.tbxCountdown_Sec.Size = new System.Drawing.Size(184, 35);
            this.tbxCountdown_Sec.TabIndex = 6;
            this.tbxCountdown_Sec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxCountdown_Sec.TextChanged += new System.EventHandler(this.tbxCountdown_Sec_TextChanged);
            // 
            // pnlHideAndShowTab
            // 
            this.pnlHideAndShowTab.BackColor = System.Drawing.Color.Transparent;
            this.pnlHideAndShowTab.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlHideAndShowTab.BorderRadius = 5;
            this.pnlHideAndShowTab.BorderThickness = 2;
            this.pnlHideAndShowTab.Controls.Add(this.ckbHideTab);
            this.pnlHideAndShowTab.Location = new System.Drawing.Point(24, 221);
            this.pnlHideAndShowTab.Name = "pnlHideAndShowTab";
            this.pnlHideAndShowTab.Size = new System.Drawing.Size(431, 41);
            this.pnlHideAndShowTab.TabIndex = 9;
            // 
            // ckbHideTab
            // 
            this.ckbHideTab.AutoSize = true;
            this.ckbHideTab.BackColor = System.Drawing.Color.Transparent;
            this.ckbHideTab.Checked = true;
            this.ckbHideTab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbHideTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbHideTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHideTab.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ckbHideTab.Location = new System.Drawing.Point(115, 10);
            this.ckbHideTab.Name = "ckbHideTab";
            this.ckbHideTab.Size = new System.Drawing.Size(200, 21);
            this.ckbHideTab.TabIndex = 5;
            this.ckbHideTab.Text = "Hide This Tab With Recording";
            this.ckbHideTab.UseVisualStyleBackColor = false;
            this.ckbHideTab.CheckedChanged += new System.EventHandler(this.ckbHideTab_CheckedChanged);
            // 
            // lblRecordSetting
            // 
            this.lblRecordSetting.AutoSize = true;
            this.lblRecordSetting.BackColor = System.Drawing.Color.Transparent;
            this.lblRecordSetting.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordSetting.ForeColor = System.Drawing.Color.White;
            this.lblRecordSetting.Location = new System.Drawing.Point(183, 10);
            this.lblRecordSetting.Name = "lblRecordSetting";
            this.lblRecordSetting.Size = new System.Drawing.Size(112, 20);
            this.lblRecordSetting.TabIndex = 26;
            this.lblRecordSetting.Text = "Record Setting";
            this.lblRecordSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlVideoTab
            // 
            this.pnlVideoTab.BackColor = System.Drawing.Color.Transparent;
            this.pnlVideoTab.BackgroundImage = global::Screenshot_X.Properties.Resources.BackGround_Gray1;
            this.pnlVideoTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlVideoTab.Controls.Add(this.pbSystemSound);
            this.pnlVideoTab.Controls.Add(this.pbStartRecording);
            this.pnlVideoTab.Controls.Add(this.pnlRecordingControl);
            this.pnlVideoTab.Controls.Add(this.pbShowCameraPreview);
            this.pnlVideoTab.Controls.Add(this.pbMoveButton);
            this.pnlVideoTab.Controls.Add(this.pbRecordSetting);
            this.pnlVideoTab.Controls.Add(this.lblRecordingTime);
            this.pnlVideoTab.Controls.Add(this.pbExit);
            this.pnlVideoTab.Controls.Add(this.pbMic);
            this.pnlVideoTab.Controls.Add(this.pbCameraPulseOn);
            this.pnlVideoTab.Location = new System.Drawing.Point(292, 12);
            this.pnlVideoTab.Name = "pnlVideoTab";
            this.pnlVideoTab.Size = new System.Drawing.Size(550, 62);
            this.pnlVideoTab.TabIndex = 0;
            this.pnlVideoTab.UseTransparentBackground = true;
            this.pnlVideoTab.Click += new System.EventHandler(this.pnlVideoTab_Click);
            // 
            // pbSystemSound
            // 
            this.pbSystemSound.BackColor = System.Drawing.Color.Transparent;
            this.pbSystemSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSystemSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSystemSound.FillColor = System.Drawing.Color.Transparent;
            this.pbSystemSound.Image = global::Screenshot_X.Properties.Resources.VolumeOn;
            this.pbSystemSound.ImageRotate = 0F;
            this.pbSystemSound.Location = new System.Drawing.Point(342, 16);
            this.pbSystemSound.Name = "pbSystemSound";
            this.pbSystemSound.Size = new System.Drawing.Size(39, 30);
            this.pbSystemSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSystemSound.TabIndex = 17;
            this.pbSystemSound.TabStop = false;
            this.pbSystemSound.UseTransparentBackground = true;
            this.pbSystemSound.Click += new System.EventHandler(this.pbSystemSound_Click);
            // 
            // pbStartRecording
            // 
            this.pbStartRecording.BackColor = System.Drawing.Color.Transparent;
            this.pbStartRecording.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbStartRecording.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStartRecording.FillColor = System.Drawing.Color.Transparent;
            this.pbStartRecording.Image = ((System.Drawing.Image)(resources.GetObject("pbStartRecording.Image")));
            this.pbStartRecording.ImageRotate = 0F;
            this.pbStartRecording.Location = new System.Drawing.Point(90, 12);
            this.pbStartRecording.Name = "pbStartRecording";
            this.pbStartRecording.Size = new System.Drawing.Size(62, 39);
            this.pbStartRecording.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStartRecording.TabIndex = 1;
            this.pbStartRecording.TabStop = false;
            this.pbStartRecording.UseTransparentBackground = true;
            this.pbStartRecording.Click += new System.EventHandler(this.pbStartRecording_Click);
            // 
            // pnlRecordingControl
            // 
            this.pnlRecordingControl.BackColor = System.Drawing.Color.Transparent;
            this.pnlRecordingControl.BackgroundImage = global::Screenshot_X.Properties.Resources.RecordingControlTab;
            this.pnlRecordingControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlRecordingControl.Controls.Add(this.pbPause);
            this.pnlRecordingControl.Location = new System.Drawing.Point(31, 12);
            this.pnlRecordingControl.Name = "pnlRecordingControl";
            this.pnlRecordingControl.Size = new System.Drawing.Size(123, 39);
            this.pnlRecordingControl.TabIndex = 11;
            this.pnlRecordingControl.Visible = false;
            // 
            // pbPause
            // 
            this.pbPause.BackColor = System.Drawing.Color.Transparent;
            this.pbPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPause.FillColor = System.Drawing.Color.Transparent;
            this.pbPause.Image = global::Screenshot_X.Properties.Resources.Pause;
            this.pbPause.ImageRotate = 0F;
            this.pbPause.Location = new System.Drawing.Point(28, 4);
            this.pbPause.Name = "pbPause";
            this.pbPause.Size = new System.Drawing.Size(30, 30);
            this.pbPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPause.TabIndex = 10;
            this.pbPause.TabStop = false;
            this.pbPause.UseTransparentBackground = true;
            this.pbPause.Click += new System.EventHandler(this.pbPause_Click);
            // 
            // pbShowCameraPreview
            // 
            this.pbShowCameraPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbShowCameraPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbShowCameraPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShowCameraPreview.FillColor = System.Drawing.Color.Transparent;
            this.pbShowCameraPreview.Image = global::Screenshot_X.Properties.Resources.Camera_Off;
            this.pbShowCameraPreview.ImageRotate = 0F;
            this.pbShowCameraPreview.Location = new System.Drawing.Point(396, 16);
            this.pbShowCameraPreview.Name = "pbShowCameraPreview";
            this.pbShowCameraPreview.Size = new System.Drawing.Size(30, 30);
            this.pbShowCameraPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShowCameraPreview.TabIndex = 15;
            this.pbShowCameraPreview.TabStop = false;
            this.pbShowCameraPreview.UseTransparentBackground = true;
            this.pbShowCameraPreview.Click += new System.EventHandler(this.pbShowCameraPreview_Click);
            // 
            // pbMoveButton
            // 
            this.pbMoveButton.BackColor = System.Drawing.Color.Transparent;
            this.pbMoveButton.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pbMoveButton.Image = global::Screenshot_X.Properties.Resources.Active_indicator;
            this.pbMoveButton.ImageRotate = 0F;
            this.pbMoveButton.Location = new System.Drawing.Point(10, 12);
            this.pbMoveButton.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
            this.pbMoveButton.Name = "pbMoveButton";
            this.pbMoveButton.Size = new System.Drawing.Size(10, 41);
            this.pbMoveButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMoveButton.TabIndex = 14;
            this.pbMoveButton.TabStop = false;
            this.pbMoveButton.UseTransparentBackground = true;
            this.pbMoveButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMoveButton_MouseDown);
            // 
            // pbRecordSetting
            // 
            this.pbRecordSetting.BackColor = System.Drawing.Color.Transparent;
            this.pbRecordSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbRecordSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRecordSetting.FillColor = System.Drawing.Color.Transparent;
            this.pbRecordSetting.Image = ((System.Drawing.Image)(resources.GetObject("pbRecordSetting.Image")));
            this.pbRecordSetting.ImageRotate = 0F;
            this.pbRecordSetting.Location = new System.Drawing.Point(444, 16);
            this.pbRecordSetting.Name = "pbRecordSetting";
            this.pbRecordSetting.Size = new System.Drawing.Size(30, 30);
            this.pbRecordSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRecordSetting.TabIndex = 5;
            this.pbRecordSetting.TabStop = false;
            this.pbRecordSetting.UseTransparentBackground = true;
            this.pbRecordSetting.Click += new System.EventHandler(this.pbShowReCordnSettingTab_Click);
            // 
            // lblRecordingTime
            // 
            this.lblRecordingTime.AutoSize = true;
            this.lblRecordingTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordingTime.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRecordingTime.Location = new System.Drawing.Point(160, 16);
            this.lblRecordingTime.Name = "lblRecordingTime";
            this.lblRecordingTime.Size = new System.Drawing.Size(89, 30);
            this.lblRecordingTime.TabIndex = 2;
            this.lblRecordingTime.Text = "00:00:00";
            this.lblRecordingTime.Click += new System.EventHandler(this.lblRecordingTime_Click);
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.FillColor = System.Drawing.Color.Transparent;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.ImageRotate = 0F;
            this.pbExit.Location = new System.Drawing.Point(498, 16);
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
            this.pbMic.Location = new System.Drawing.Point(299, 16);
            this.pbMic.Name = "pbMic";
            this.pbMic.Size = new System.Drawing.Size(30, 30);
            this.pbMic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMic.TabIndex = 0;
            this.pbMic.TabStop = false;
            this.pbMic.UseTransparentBackground = true;
            this.pbMic.Click += new System.EventHandler(this.pbMic_Click);
            // 
            // pbCameraPulseOn
            // 
            this.pbCameraPulseOn.BackColor = System.Drawing.Color.Transparent;
            this.pbCameraPulseOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCameraPulseOn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbCameraPulseOn.FillColor = System.Drawing.Color.Transparent;
            this.pbCameraPulseOn.Image = global::Screenshot_X.Properties.Resources.Red_Pulsing_Dot;
            this.pbCameraPulseOn.ImageRotate = 0F;
            this.pbCameraPulseOn.Location = new System.Drawing.Point(207, -24);
            this.pbCameraPulseOn.Name = "pbCameraPulseOn";
            this.pbCameraPulseOn.Size = new System.Drawing.Size(131, 111);
            this.pbCameraPulseOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCameraPulseOn.TabIndex = 16;
            this.pbCameraPulseOn.TabStop = false;
            this.pbCameraPulseOn.UseTransparentBackground = true;
            this.pbCameraPulseOn.Visible = false;
            this.pbCameraPulseOn.Click += new System.EventHandler(this.lblRecordingTime_Click);
            // 
            // frmScreenVideoTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1134, 550);
            this.Controls.Add(this.pnlRecordSettingTab);
            this.Controls.Add(this.pnlVideoTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmScreenVideoTab";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "-";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.frmScreenVideoTab_Deactivate);
            this.Load += new System.EventHandler(this.frmScreenVideoTab_Load);
            this.LocationChanged += new System.EventHandler(this.frmScreenVideoTab_LocationChanged);
            this.pnlRecordSettingTab.ResumeLayout(false);
            this.pnlRecordSettingTab.PerformLayout();
            this.pnlCameraBorderRadius.ResumeLayout(false);
            this.pnlCameraBorderRadius.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.pnlResolution.ResumeLayout(false);
            this.pnlResolution.PerformLayout();
            this.pnlCamera.ResumeLayout(false);
            this.pnlCamera.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.pnlCounter.ResumeLayout(false);
            this.pnlCounter.PerformLayout();
            this.pnlHideAndShowTab.ResumeLayout(false);
            this.pnlHideAndShowTab.PerformLayout();
            this.pnlVideoTab.ResumeLayout(false);
            this.pnlVideoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSystemSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStartRecording)).EndInit();
            this.pnlRecordingControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowCameraPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecordSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCameraPulseOn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlVideoTab;
        private Guna.UI2.WinForms.Guna2PictureBox pbMic;
        public Guna.UI2.WinForms.Guna2PictureBox pbStartRecording;
        private System.Windows.Forms.Label lblRecordingTime;
        private System.Windows.Forms.Timer RecordTime;
        public Guna.UI2.WinForms.Guna2ComboBox cmbResolution;
        public Guna.UI2.WinForms.Guna2PictureBox pbExit;
        public Guna.UI2.WinForms.Guna2PictureBox pbRecordSetting;
        private Guna.UI2.WinForms.Guna2Panel pnlRecordSettingTab;
        private System.Windows.Forms.CheckBox ckbHideTab;
        private Guna.UI2.WinForms.Guna2TextBox tbxCountdown_Sec;
        private System.Windows.Forms.Label lblSetCountdownInSec;
        private Guna.UI2.WinForms.Guna2PictureBox pbMoveButton;
        public Guna.UI2.WinForms.Guna2PictureBox pbShowCameraPreview;
        private System.Windows.Forms.Label lblCameraSize;
        private System.Windows.Forms.Label lblResetBorderRadius;
        private Guna.UI2.WinForms.Guna2TextBox tbxBorderRadius;
        private System.Windows.Forms.Label lblCameraBorderRadius;
        private System.Windows.Forms.Label lblMulti;
        private Guna.UI2.WinForms.Guna2TextBox tbxWidth;
        private System.Windows.Forms.Label lblResetSize;
        private Guna.UI2.WinForms.Guna2TextBox tbxHeight;
        public Guna.UI2.WinForms.Guna2ComboBox cmbCameraSize;
        private System.Windows.Forms.CheckBox cbxCricleCamera;
        private System.Windows.Forms.Label lblCustomSize;
        private System.Windows.Forms.Label lblRecordSetting;
        public Guna.UI2.WinForms.Guna2PictureBox pbPause;
        private Guna.UI2.WinForms.Guna2Panel pnlRecordingControl;
        private Guna.UI2.WinForms.Guna2PictureBox pbCameraPulseOn;
        private Guna.UI2.WinForms.Guna2PictureBox pbSystemSound;
        private System.Windows.Forms.Label lblResolution;
        private Guna.UI2.WinForms.Guna2Panel pnlHideAndShowTab;
        private Guna.UI2.WinForms.Guna2Panel pnlResolution;
        private Guna.UI2.WinForms.Guna2Panel pnlCounter;
        private Guna.UI2.WinForms.Guna2Panel pnlCamera;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel pnlCameraBorderRadius;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lblDefaultScreenshotPath;
        private System.Windows.Forms.Button btnBrowseFolder;
        private Guna.UI2.WinForms.Guna2TextBox tbxScreenVideoPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}