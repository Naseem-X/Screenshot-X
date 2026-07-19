namespace Screenshot_X
{
    partial class frmMainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainApp));
            this.pblScreenshotMode = new Guna.UI2.WinForms.Guna2Panel();
            this.pbChangeModeOptions = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbTakeScreenshot = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbMoveButton = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlVideoRecorder = new Guna.UI2.WinForms.Guna2Panel();
            this.pbTakeScreenVideo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pbClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pbDrawing = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlScreenshot = new Guna.UI2.WinForms.Guna2Panel();
            this.pbColorPicker = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbOCR = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlMainAppSetting = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSupportThisProject = new System.Windows.Forms.Label();
            this.lblMadeBy = new System.Windows.Forms.Label();
            this.pnlScreenshotMode = new Guna.UI2.WinForms.Guna2Panel();
            this.lblScreenshotMode = new System.Windows.Forms.Label();
            this.cmbScreenshotMode = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlDefaultScreenshotPath = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.tbxScreenshotPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDefaultScreenshotPath = new System.Windows.Forms.Label();
            this.pbInfo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblMainSetting = new System.Windows.Forms.Label();
            this.object_85fdd779_37fb_4672_81b8_377a23874e28 = new System.Windows.Forms.Panel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlMainApp = new Guna.UI2.WinForms.Guna2Panel();
            this.lblWhatIsNew = new System.Windows.Forms.Label();
            this.pblScreenshotMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangeModeOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTakeScreenshot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoveButton)).BeginInit();
            this.pnlVideoRecorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTakeScreenVideo)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawing)).BeginInit();
            this.pnlScreenshot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOCR)).BeginInit();
            this.pnlMainAppSetting.SuspendLayout();
            this.pnlScreenshotMode.SuspendLayout();
            this.pnlDefaultScreenshotPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
            this.pnlMainApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pblScreenshotMode
            // 
            this.pblScreenshotMode.BackColor = System.Drawing.Color.Transparent;
            this.pblScreenshotMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pblScreenshotMode.BorderColor = System.Drawing.Color.Transparent;
            this.pblScreenshotMode.BorderThickness = 3;
            this.pblScreenshotMode.Controls.Add(this.pbChangeModeOptions);
            this.pblScreenshotMode.Controls.Add(this.pbTakeScreenshot);
            this.pblScreenshotMode.Location = new System.Drawing.Point(30, 16);
            this.pblScreenshotMode.Margin = new System.Windows.Forms.Padding(2);
            this.pblScreenshotMode.Name = "pblScreenshotMode";
            this.pblScreenshotMode.Size = new System.Drawing.Size(85, 41);
            this.pblScreenshotMode.TabIndex = 14;
            // 
            // pbChangeModeOptions
            // 
            this.pbChangeModeOptions.BackColor = System.Drawing.Color.Transparent;
            this.pbChangeModeOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbChangeModeOptions.Image = global::Screenshot_X.Properties.Resources.Setting;
            this.pbChangeModeOptions.ImageRotate = 0F;
            this.pbChangeModeOptions.Location = new System.Drawing.Point(49, 5);
            this.pbChangeModeOptions.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
            this.pbChangeModeOptions.Name = "pbChangeModeOptions";
            this.pbChangeModeOptions.Size = new System.Drawing.Size(31, 30);
            this.pbChangeModeOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbChangeModeOptions.TabIndex = 2;
            this.pbChangeModeOptions.TabStop = false;
            this.pbChangeModeOptions.UseTransparentBackground = true;
            this.pbChangeModeOptions.Click += new System.EventHandler(this.pbChangeMode_Click);
            // 
            // pbTakeScreenshot
            // 
            this.pbTakeScreenshot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTakeScreenshot.Image = global::Screenshot_X.Properties.Resources.Screenshot;
            this.pbTakeScreenshot.ImageRotate = 0F;
            this.pbTakeScreenshot.Location = new System.Drawing.Point(2, 5);
            this.pbTakeScreenshot.Margin = new System.Windows.Forms.Padding(2);
            this.pbTakeScreenshot.Name = "pbTakeScreenshot";
            this.pbTakeScreenshot.Size = new System.Drawing.Size(30, 30);
            this.pbTakeScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTakeScreenshot.TabIndex = 10;
            this.pbTakeScreenshot.TabStop = false;
            this.pbTakeScreenshot.Click += new System.EventHandler(this.pbScreenshotMode_Click);
            // 
            // pbMoveButton
            // 
            this.pbMoveButton.BackColor = System.Drawing.Color.Transparent;
            this.pbMoveButton.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pbMoveButton.Image = global::Screenshot_X.Properties.Resources.Active_indicator;
            this.pbMoveButton.ImageRotate = 0F;
            this.pbMoveButton.Location = new System.Drawing.Point(16, 16);
            this.pbMoveButton.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
            this.pbMoveButton.Name = "pbMoveButton";
            this.pbMoveButton.Size = new System.Drawing.Size(10, 41);
            this.pbMoveButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMoveButton.TabIndex = 13;
            this.pbMoveButton.TabStop = false;
            this.pbMoveButton.UseTransparentBackground = true;
            this.pbMoveButton.Click += new System.EventHandler(this.pbMoveButton_Click);
            this.pbMoveButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMoveButton_MouseDown);
            // 
            // pnlVideoRecorder
            // 
            this.pnlVideoRecorder.BackColor = System.Drawing.Color.Transparent;
            this.pnlVideoRecorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlVideoRecorder.BorderColor = System.Drawing.Color.Transparent;
            this.pnlVideoRecorder.BorderThickness = 3;
            this.pnlVideoRecorder.Controls.Add(this.pbTakeScreenVideo);
            this.pnlVideoRecorder.Location = new System.Drawing.Point(119, 16);
            this.pnlVideoRecorder.Margin = new System.Windows.Forms.Padding(2);
            this.pnlVideoRecorder.Name = "pnlVideoRecorder";
            this.pnlVideoRecorder.Size = new System.Drawing.Size(52, 41);
            this.pnlVideoRecorder.TabIndex = 1;
            // 
            // pbTakeScreenVideo
            // 
            this.pbTakeScreenVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTakeScreenVideo.Image = global::Screenshot_X.Properties.Resources.Screen_Video;
            this.pbTakeScreenVideo.ImageRotate = 0F;
            this.pbTakeScreenVideo.Location = new System.Drawing.Point(6, 8);
            this.pbTakeScreenVideo.Margin = new System.Windows.Forms.Padding(2);
            this.pbTakeScreenVideo.Name = "pbTakeScreenVideo";
            this.pbTakeScreenVideo.Size = new System.Drawing.Size(41, 27);
            this.pbTakeScreenVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTakeScreenVideo.TabIndex = 9;
            this.pbTakeScreenVideo.TabStop = false;
            this.pbTakeScreenVideo.Click += new System.EventHandler(this.pbScreenVideo_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderThickness = 3;
            this.guna2Panel2.Controls.Add(this.pbClose);
            this.guna2Panel2.Controls.Add(this.pbMinimize);
            this.guna2Panel2.Location = new System.Drawing.Point(314, 16);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(97, 41);
            this.guna2Panel2.TabIndex = 12;
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::Screenshot_X.Properties.Resources.CLose;
            this.pbClose.ImageRotate = 0F;
            this.pbClose.Location = new System.Drawing.Point(54, 5);
            this.pbClose.Margin = new System.Windows.Forms.Padding(2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(30, 30);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 11;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbMinimize
            // 
            this.pbMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMinimize.BorderRadius = 10;
            this.pbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimize.FillColor = System.Drawing.Color.Transparent;
            this.pbMinimize.Image = global::Screenshot_X.Properties.Resources.Minimize;
            this.pbMinimize.ImageRotate = 0F;
            this.pbMinimize.Location = new System.Drawing.Point(11, 5);
            this.pbMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(30, 32);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimize.TabIndex = 10;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.pbDrawing);
            this.guna2Panel1.Location = new System.Drawing.Point(175, 16);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(50, 41);
            this.guna2Panel1.TabIndex = 11;
            // 
            // pbDrawing
            // 
            this.pbDrawing.Cursor = System.Windows.Forms.Cursors.No;
            this.pbDrawing.Image = global::Screenshot_X.Properties.Resources.Draw;
            this.pbDrawing.ImageRotate = 0F;
            this.pbDrawing.Location = new System.Drawing.Point(10, 6);
            this.pbDrawing.Margin = new System.Windows.Forms.Padding(2);
            this.pbDrawing.Name = "pbDrawing";
            this.pbDrawing.Size = new System.Drawing.Size(30, 30);
            this.pbDrawing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDrawing.TabIndex = 11;
            this.pbDrawing.TabStop = false;
            this.pbDrawing.Click += new System.EventHandler(this.pbDrawing_Click);
            // 
            // pnlScreenshot
            // 
            this.pnlScreenshot.BackColor = System.Drawing.Color.Transparent;
            this.pnlScreenshot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlScreenshot.BorderColor = System.Drawing.Color.Transparent;
            this.pnlScreenshot.BorderThickness = 3;
            this.pnlScreenshot.Controls.Add(this.pbColorPicker);
            this.pnlScreenshot.Controls.Add(this.pbOCR);
            this.pnlScreenshot.Location = new System.Drawing.Point(227, 16);
            this.pnlScreenshot.Margin = new System.Windows.Forms.Padding(2);
            this.pnlScreenshot.Name = "pnlScreenshot";
            this.pnlScreenshot.Size = new System.Drawing.Size(83, 41);
            this.pnlScreenshot.TabIndex = 0;
            // 
            // pbColorPicker
            // 
            this.pbColorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbColorPicker.Image = global::Screenshot_X.Properties.Resources.color_picker;
            this.pbColorPicker.ImageRotate = 0F;
            this.pbColorPicker.Location = new System.Drawing.Point(2, 5);
            this.pbColorPicker.Margin = new System.Windows.Forms.Padding(2);
            this.pbColorPicker.Name = "pbColorPicker";
            this.pbColorPicker.Size = new System.Drawing.Size(34, 34);
            this.pbColorPicker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbColorPicker.TabIndex = 12;
            this.pbColorPicker.TabStop = false;
            this.pbColorPicker.Click += new System.EventHandler(this.pbColorPicker_Click);
            // 
            // pbOCR
            // 
            this.pbOCR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbOCR.Image = global::Screenshot_X.Properties.Resources.OCR;
            this.pbOCR.ImageRotate = 0F;
            this.pbOCR.Location = new System.Drawing.Point(44, 5);
            this.pbOCR.Margin = new System.Windows.Forms.Padding(2);
            this.pbOCR.Name = "pbOCR";
            this.pbOCR.Size = new System.Drawing.Size(30, 30);
            this.pbOCR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOCR.TabIndex = 11;
            this.pbOCR.TabStop = false;
            this.pbOCR.Click += new System.EventHandler(this.pbExtractText_Click);
            // 
            // pnlMainAppSetting
            // 
            this.pnlMainAppSetting.BackgroundImage = global::Screenshot_X.Properties.Resources.BackGround_Setting_Gray;
            this.pnlMainAppSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlMainAppSetting.Controls.Add(this.lblWhatIsNew);
            this.pnlMainAppSetting.Controls.Add(this.lblSupportThisProject);
            this.pnlMainAppSetting.Controls.Add(this.lblMadeBy);
            this.pnlMainAppSetting.Controls.Add(this.pnlScreenshotMode);
            this.pnlMainAppSetting.Controls.Add(this.pnlDefaultScreenshotPath);
            this.pnlMainAppSetting.Controls.Add(this.pbInfo);
            this.pnlMainAppSetting.Controls.Add(this.lblMainSetting);
            this.pnlMainAppSetting.Location = new System.Drawing.Point(93, 82);
            this.pnlMainAppSetting.Name = "pnlMainAppSetting";
            this.pnlMainAppSetting.Size = new System.Drawing.Size(406, 221);
            this.pnlMainAppSetting.TabIndex = 13;
            this.pnlMainAppSetting.Visible = false;
            // 
            // lblSupportThisProject
            // 
            this.lblSupportThisProject.AutoSize = true;
            this.lblSupportThisProject.BackColor = System.Drawing.Color.Transparent;
            this.lblSupportThisProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSupportThisProject.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupportThisProject.ForeColor = System.Drawing.Color.White;
            this.lblSupportThisProject.Location = new System.Drawing.Point(119, 188);
            this.lblSupportThisProject.Name = "lblSupportThisProject";
            this.lblSupportThisProject.Size = new System.Drawing.Size(171, 20);
            this.lblSupportThisProject.TabIndex = 34;
            this.lblSupportThisProject.Text = "💖 Support This Project";
            this.lblSupportThisProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSupportThisProject.Click += new System.EventHandler(this.lblSupportThisProject_Click);
            // 
            // lblMadeBy
            // 
            this.lblMadeBy.AutoSize = true;
            this.lblMadeBy.BackColor = System.Drawing.Color.Transparent;
            this.lblMadeBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMadeBy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMadeBy.ForeColor = System.Drawing.Color.White;
            this.lblMadeBy.Location = new System.Drawing.Point(119, 168);
            this.lblMadeBy.Name = "lblMadeBy";
            this.lblMadeBy.Size = new System.Drawing.Size(237, 20);
            this.lblMadeBy.TabIndex = 33;
            this.lblMadeBy.Text = "Made By : Naseem Abu AlShaikh";
            this.lblMadeBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMadeBy.Click += new System.EventHandler(this.lblMadeBy_Click);
            // 
            // pnlScreenshotMode
            // 
            this.pnlScreenshotMode.BackColor = System.Drawing.Color.Transparent;
            this.pnlScreenshotMode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlScreenshotMode.BorderRadius = 5;
            this.pnlScreenshotMode.BorderThickness = 2;
            this.pnlScreenshotMode.Controls.Add(this.lblScreenshotMode);
            this.pnlScreenshotMode.Controls.Add(this.cmbScreenshotMode);
            this.pnlScreenshotMode.Location = new System.Drawing.Point(7, 58);
            this.pnlScreenshotMode.Name = "pnlScreenshotMode";
            this.pnlScreenshotMode.Size = new System.Drawing.Size(393, 41);
            this.pnlScreenshotMode.TabIndex = 32;
            // 
            // lblScreenshotMode
            // 
            this.lblScreenshotMode.AutoSize = true;
            this.lblScreenshotMode.BackColor = System.Drawing.Color.Transparent;
            this.lblScreenshotMode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreenshotMode.ForeColor = System.Drawing.Color.White;
            this.lblScreenshotMode.Location = new System.Drawing.Point(13, 10);
            this.lblScreenshotMode.Name = "lblScreenshotMode";
            this.lblScreenshotMode.Size = new System.Drawing.Size(184, 20);
            this.lblScreenshotMode.TabIndex = 30;
            this.lblScreenshotMode.Text = "Default Screenshot Mode :";
            this.lblScreenshotMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbScreenshotMode
            // 
            this.cmbScreenshotMode.AutoRoundedCorners = true;
            this.cmbScreenshotMode.BackColor = System.Drawing.Color.Transparent;
            this.cmbScreenshotMode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbScreenshotMode.BorderRadius = 17;
            this.cmbScreenshotMode.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.cmbScreenshotMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbScreenshotMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbScreenshotMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScreenshotMode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cmbScreenshotMode.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbScreenshotMode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbScreenshotMode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbScreenshotMode.ForeColor = System.Drawing.Color.White;
            this.cmbScreenshotMode.ItemHeight = 30;
            this.cmbScreenshotMode.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.cmbScreenshotMode.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.cmbScreenshotMode.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbScreenshotMode.Location = new System.Drawing.Point(203, 3);
            this.cmbScreenshotMode.Name = "cmbScreenshotMode";
            this.cmbScreenshotMode.Size = new System.Drawing.Size(188, 36);
            this.cmbScreenshotMode.TabIndex = 29;
            this.cmbScreenshotMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlDefaultScreenshotPath
            // 
            this.pnlDefaultScreenshotPath.BackColor = System.Drawing.Color.Transparent;
            this.pnlDefaultScreenshotPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlDefaultScreenshotPath.BorderRadius = 5;
            this.pnlDefaultScreenshotPath.BorderThickness = 2;
            this.pnlDefaultScreenshotPath.Controls.Add(this.btnBrowseFolder);
            this.pnlDefaultScreenshotPath.Controls.Add(this.tbxScreenshotPath);
            this.pnlDefaultScreenshotPath.Controls.Add(this.lblDefaultScreenshotPath);
            this.pnlDefaultScreenshotPath.Location = new System.Drawing.Point(7, 114);
            this.pnlDefaultScreenshotPath.Name = "pnlDefaultScreenshotPath";
            this.pnlDefaultScreenshotPath.Size = new System.Drawing.Size(393, 41);
            this.pnlDefaultScreenshotPath.TabIndex = 15;
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseFolder.Location = new System.Drawing.Point(359, 9);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(31, 23);
            this.btnBrowseFolder.TabIndex = 31;
            this.btnBrowseFolder.Text = "...";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // tbxScreenshotPath
            // 
            this.tbxScreenshotPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbxScreenshotPath.DefaultText = "Pictures";
            this.tbxScreenshotPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxScreenshotPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxScreenshotPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxScreenshotPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxScreenshotPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxScreenshotPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxScreenshotPath.ForeColor = System.Drawing.Color.Black;
            this.tbxScreenshotPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxScreenshotPath.Location = new System.Drawing.Point(211, 8);
            this.tbxScreenshotPath.Name = "tbxScreenshotPath";
            this.tbxScreenshotPath.PlaceholderText = "";
            this.tbxScreenshotPath.ReadOnly = true;
            this.tbxScreenshotPath.SelectedText = "";
            this.tbxScreenshotPath.Size = new System.Drawing.Size(141, 24);
            this.tbxScreenshotPath.TabIndex = 14;
            this.tbxScreenshotPath.TextChanged += new System.EventHandler(this.tbxScreenshotPath_TextChanged);
            // 
            // lblDefaultScreenshotPath
            // 
            this.lblDefaultScreenshotPath.AutoSize = true;
            this.lblDefaultScreenshotPath.BackColor = System.Drawing.Color.Transparent;
            this.lblDefaultScreenshotPath.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultScreenshotPath.ForeColor = System.Drawing.Color.White;
            this.lblDefaultScreenshotPath.Location = new System.Drawing.Point(11, 10);
            this.lblDefaultScreenshotPath.Name = "lblDefaultScreenshotPath";
            this.lblDefaultScreenshotPath.Size = new System.Drawing.Size(173, 20);
            this.lblDefaultScreenshotPath.TabIndex = 30;
            this.lblDefaultScreenshotPath.Text = "Default Screenshot Path :";
            this.lblDefaultScreenshotPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbInfo
            // 
            this.pbInfo.BackColor = System.Drawing.Color.Transparent;
            this.pbInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInfo.Image = global::Screenshot_X.Properties.Resources.Info;
            this.pbInfo.ImageRotate = 0F;
            this.pbInfo.Location = new System.Drawing.Point(93, 168);
            this.pbInfo.Margin = new System.Windows.Forms.Padding(2);
            this.pbInfo.Name = "pbInfo";
            this.pbInfo.Size = new System.Drawing.Size(21, 20);
            this.pbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInfo.TabIndex = 28;
            this.pbInfo.TabStop = false;
            this.pbInfo.Click += new System.EventHandler(this.pbInfo_Click);
            // 
            // lblMainSetting
            // 
            this.lblMainSetting.AutoSize = true;
            this.lblMainSetting.BackColor = System.Drawing.Color.Transparent;
            this.lblMainSetting.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblMainSetting.Location = new System.Drawing.Point(154, 11);
            this.lblMainSetting.Name = "lblMainSetting";
            this.lblMainSetting.Size = new System.Drawing.Size(98, 20);
            this.lblMainSetting.TabIndex = 27;
            this.lblMainSetting.Text = "Main Setting";
            this.lblMainSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // object_85fdd779_37fb_4672_81b8_377a23874e28
            // 
            this.object_85fdd779_37fb_4672_81b8_377a23874e28.BackColor = System.Drawing.Color.Transparent;
            this.object_85fdd779_37fb_4672_81b8_377a23874e28.BackgroundImage = global::Screenshot_X.Properties.Resources.BackGround_Gray2;
            this.object_85fdd779_37fb_4672_81b8_377a23874e28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.object_85fdd779_37fb_4672_81b8_377a23874e28.Location = new System.Drawing.Point(0, 3);
            this.object_85fdd779_37fb_4672_81b8_377a23874e28.Name = "object_85fdd779_37fb_4672_81b8_377a23874e28";
            this.object_85fdd779_37fb_4672_81b8_377a23874e28.Size = new System.Drawing.Size(378, 73);
            this.object_85fdd779_37fb_4672_81b8_377a23874e28.TabIndex = 2;
            // 
            // pnlMainApp
            // 
            this.pnlMainApp.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainApp.BackgroundImage = global::Screenshot_X.Properties.Resources.BackGround_Gray2;
            this.pnlMainApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlMainApp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlMainApp.Controls.Add(this.pbMoveButton);
            this.pnlMainApp.Controls.Add(this.pblScreenshotMode);
            this.pnlMainApp.Controls.Add(this.guna2Panel2);
            this.pnlMainApp.Controls.Add(this.pnlScreenshot);
            this.pnlMainApp.Controls.Add(this.pnlVideoRecorder);
            this.pnlMainApp.Controls.Add(this.guna2Panel1);
            this.pnlMainApp.Location = new System.Drawing.Point(83, 3);
            this.pnlMainApp.Name = "pnlMainApp";
            this.pnlMainApp.Size = new System.Drawing.Size(426, 73);
            this.pnlMainApp.TabIndex = 33;
            this.pnlMainApp.Click += new System.EventHandler(this.pnlMainApp_Enter);
            // 
            // lblWhatIsNew
            // 
            this.lblWhatIsNew.AutoSize = true;
            this.lblWhatIsNew.BackColor = System.Drawing.Color.Transparent;
            this.lblWhatIsNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWhatIsNew.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhatIsNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblWhatIsNew.Location = new System.Drawing.Point(309, 16);
            this.lblWhatIsNew.Name = "lblWhatIsNew";
            this.lblWhatIsNew.Size = new System.Drawing.Size(79, 15);
            this.lblWhatIsNew.TabIndex = 35;
            this.lblWhatIsNew.Text = "What Is New ?";
            this.lblWhatIsNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWhatIsNew.Click += new System.EventHandler(this.lblWhatIsNew_Click);
            // 
            // frmMainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(592, 325);
            this.Controls.Add(this.pnlMainApp);
            this.Controls.Add(this.pnlMainAppSetting);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.frmMainApp_Deactivate);
            this.Load += new System.EventHandler(this.frmMainApp_Load);
            this.pblScreenshotMode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbChangeModeOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTakeScreenshot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoveButton)).EndInit();
            this.pnlVideoRecorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTakeScreenVideo)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawing)).EndInit();
            this.pnlScreenshot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbColorPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOCR)).EndInit();
            this.pnlMainAppSetting.ResumeLayout(false);
            this.pnlMainAppSetting.PerformLayout();
            this.pnlScreenshotMode.ResumeLayout(false);
            this.pnlScreenshotMode.PerformLayout();
            this.pnlDefaultScreenshotPath.ResumeLayout(false);
            this.pnlDefaultScreenshotPath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
            this.pnlMainApp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox pbDrawing;
        private Guna.UI2.WinForms.Guna2PictureBox pbMinimize;
        private Guna.UI2.WinForms.Guna2Panel pnlScreenshot;
        private Guna.UI2.WinForms.Guna2PictureBox pbColorPicker;
        private Guna.UI2.WinForms.Guna2PictureBox pbOCR;
        private Guna.UI2.WinForms.Guna2Panel pnlVideoRecorder;
        private Guna.UI2.WinForms.Guna2PictureBox pbTakeScreenshot;
        private Guna.UI2.WinForms.Guna2PictureBox pbTakeScreenVideo;
        private Guna.UI2.WinForms.Guna2PictureBox pbChangeModeOptions;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox pbClose;
        private Guna.UI2.WinForms.Guna2PictureBox pbMoveButton;
        private Guna.UI2.WinForms.Guna2Panel pnlMainAppSetting;
        private Guna.UI2.WinForms.Guna2ComboBox cmbScreenshotMode;
        private Guna.UI2.WinForms.Guna2PictureBox pbInfo;
        private System.Windows.Forms.Label lblMainSetting;
        private System.Windows.Forms.Panel object_85fdd779_37fb_4672_81b8_377a23874e28;
        private Guna.UI2.WinForms.Guna2Panel pblScreenshotMode;
        private System.Windows.Forms.Label lblScreenshotMode;
        private System.Windows.Forms.Label lblDefaultScreenshotPath;
        private System.Windows.Forms.Button btnBrowseFolder;
        private Guna.UI2.WinForms.Guna2TextBox tbxScreenshotPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Guna.UI2.WinForms.Guna2Panel pnlScreenshotMode;
        private Guna.UI2.WinForms.Guna2Panel pnlDefaultScreenshotPath;
        private System.Windows.Forms.Label lblMadeBy;
        private System.Windows.Forms.Label lblSupportThisProject;
        private Guna.UI2.WinForms.Guna2Panel pnlMainApp;
        private System.Windows.Forms.Label lblWhatIsNew;
    }
}

