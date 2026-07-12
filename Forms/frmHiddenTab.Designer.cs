namespace Screenshot_X.Forms
{
    partial class frmHiddenTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHiddenTab));
            this.pbHiddenTab = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHiddenTab)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHiddenTab
            // 
            this.pbHiddenTab.BackColor = System.Drawing.Color.Transparent;
            this.pbHiddenTab.Image = global::Screenshot_X.Properties.Resources.HiddenTab;
            this.pbHiddenTab.ImageRotate = 0F;
            this.pbHiddenTab.Location = new System.Drawing.Point(157, -181);
            this.pbHiddenTab.Name = "pbHiddenTab";
            this.pbHiddenTab.Size = new System.Drawing.Size(605, 378);
            this.pbHiddenTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHiddenTab.TabIndex = 6;
            this.pbHiddenTab.TabStop = false;
            this.pbHiddenTab.UseTransparentBackground = true;
            this.pbHiddenTab.Visible = false;
            this.pbHiddenTab.Click += new System.EventHandler(this.pbHiddenTab_Click);
            // 
            // frmHiddenTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 545);
            this.Controls.Add(this.pbHiddenTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmHiddenTab";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmHiddenTab";
            this.Load += new System.EventHandler(this.frmHiddenTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHiddenTab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pbHiddenTab;
    }
}