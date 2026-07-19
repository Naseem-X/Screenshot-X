using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screenshot_X.Forms
{
    public partial class frmWhatIsNew : Form
    {
        public bool ShowfrmWhatIsNewTab = true;
        private frmMainApp _MainAppForm ;

        public frmWhatIsNew(frmMainApp mainApp)
        {
            InitializeComponent();
            _MainAppForm = mainApp;
        }

        private void frmWhatIsNew_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;

            ShowfrmWhatIsNewTab = Properties.Settings.Default.ShowfrmWhatIsNewTab;
            LoadFontColorSettingTab();
            FadeIn();
        }
        private void LoadFontColorSettingTab()
        {
            Color BackColor = ColorTranslator.FromHtml("#151515");
            Color ForeColor = ColorTranslator.FromHtml("#60CDFF");

            _MainAppForm.ChangeForeColor(lblVersion, ForeColor);
            _MainAppForm.ChangeForeColor(lblWhatIsNew, ForeColor);
            _MainAppForm.ChangeForeColor(lblChange, ForeColor);
            _MainAppForm.ChangeForeColor(lblWhatIsNewData, ForeColor);


            _MainAppForm.ChangeBackColor(lblVersion, BackColor);
            _MainAppForm.ChangeBackColor(lblWhatIsNew, BackColor);
            _MainAppForm.ChangeBackColor(lblSupportedIdea, BackColor);
            _MainAppForm.ChangeBackColor(lblChange, BackColor);
            _MainAppForm.ChangeBackColor(lblWhatIsNewData, BackColor);


        }
        private void btnEnjoy_Click(object sender, EventArgs e)
        {
            ShowfrmWhatIsNewTab = false;
            FadeOutAndClose();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Properties.Settings.Default.ShowfrmWhatIsNewTab = ShowfrmWhatIsNewTab;
            Properties.Settings.Default.Save();

            _fadeTimer?.Stop();
            _fadeTimer?.Dispose();

            base.OnFormClosed(e);
        }

        // ==================== Fade Animation ====================

        private System.Windows.Forms.Timer _fadeTimer;
        private int _fadeStep;
        private const int FadeDuration = 250; // ms
        private bool _isClosing = false;

        private void FadeIn()
        {
            this.Opacity = 0;

            _fadeStep = 0;
            _fadeTimer?.Stop();
            _fadeTimer = new System.Windows.Forms.Timer { Interval = 15 };
            _fadeTimer.Tick += FadeInTimer_Tick;
            _fadeTimer.Start();
        }

        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            _fadeStep += 15;
            double t = Math.Min(1.0, (double)_fadeStep / FadeDuration);

            this.Opacity = t;

            if (t >= 1.0)
            {
                _fadeTimer.Stop();
                this.Opacity = 1;
            }
        }

        private void FadeOutAndClose()
        {
            if (_isClosing) return;
            _isClosing = true;

            _fadeStep = 0;
            _fadeTimer?.Stop();
            _fadeTimer = new System.Windows.Forms.Timer { Interval = 15 };
            _fadeTimer.Tick += FadeOutTimer_Tick;
            _fadeTimer.Start();
        }

        private void FadeOutTimer_Tick(object sender, EventArgs e)
        {
            _fadeStep += 15;
            double t = Math.Min(1.0, (double)_fadeStep / FadeDuration);

            this.Opacity = 1 - t;

            if (t >= 1.0)
            {
                _fadeTimer.Stop();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FadeOutAndClose();
        }

        private void LogoApp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Naseem-X/Screenshot-X");
        }

        private void GitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Naseem-X");

        }
    }
}