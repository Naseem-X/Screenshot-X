namespace Screenshot_X.Forms
{
    partial class frmCameraOverlay
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
            this.pbCameraPrev = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbCircleCameraPrev = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCameraPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCircleCameraPrev)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCameraPrev
            // 
            this.pbCameraPrev.BackColor = System.Drawing.Color.Transparent;
            this.pbCameraPrev.BorderRadius = 30;
            this.pbCameraPrev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCameraPrev.ImageRotate = 0F;
            this.pbCameraPrev.Location = new System.Drawing.Point(0, 0);
            this.pbCameraPrev.Name = "pbCameraPrev";
            this.pbCameraPrev.Size = new System.Drawing.Size(320, 180);
            this.pbCameraPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCameraPrev.TabIndex = 17;
            this.pbCameraPrev.TabStop = false;
            this.pbCameraPrev.UseTransparentBackground = true;
            // 
            // pbCircleCameraPrev
            // 
            this.pbCircleCameraPrev.BackColor = System.Drawing.Color.Transparent;
            this.pbCircleCameraPrev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCircleCameraPrev.FillColor = System.Drawing.Color.Transparent;
            this.pbCircleCameraPrev.ImageRotate = 0F;
            this.pbCircleCameraPrev.Location = new System.Drawing.Point(0, 0);
            this.pbCircleCameraPrev.Name = "pbCircleCameraPrev";
            this.pbCircleCameraPrev.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbCircleCameraPrev.Size = new System.Drawing.Size(320, 180);
            this.pbCircleCameraPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCircleCameraPrev.TabIndex = 18;
            this.pbCircleCameraPrev.TabStop = false;
            this.pbCircleCameraPrev.UseTransparentBackground = true;
            this.pbCircleCameraPrev.Visible = false;
            // 
            // frmCameraOverlay
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(320, 180);
            this.ControlBox = false;
            this.Controls.Add(this.pbCameraPrev);
            this.Controls.Add(this.pbCircleCameraPrev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCameraOverlay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCameraOverlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCameraPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCircleCameraPrev)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2PictureBox pbCameraPrev;
        public Guna.UI2.WinForms.Guna2CirclePictureBox pbCircleCameraPrev;
    }
}