using Guna.UI2.WinForms;

using NAudio.CoreAudioApi;

using ScreenRecorderLib;

using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.IO;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

using System.Runtime.InteropServices;


namespace Screenshot_X.Forms

{

    public partial class frmScreenVideoTab : Form

    {
        //[DllImport("user32.dll")]
        //private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private NotifyIcon trayIcon;



        public frmScreenVideoTab(frmMainApp mainApp)
        {
            InitializeComponent();
            _mainApp = mainApp;

            _mainApp.StopRecordingRequested += StopRecording;
            _mainApp.ToggleRecordingWindowRequested += ToggleRecordingWindow; // بدل الاتنين
        }


        private Guna2HtmlToolTip ToolTipApp;

        void LoadToolTip()

        {

            ToolTipApp = new Guna2HtmlToolTip();



            ToolTipApp.BackColor = Color.Black;

            ToolTipApp.ForeColor = Color.White;



            ToolTipApp.SetToolTip(pbExit, "Exit");

            ToolTipApp.SetToolTip(pbMic, "Mute\\Unmute");

            ToolTipApp.SetToolTip(pbStartRecording, "Start\\Pause Recording");

            ToolTipApp.SetToolTip(pbRecordSetting, "Resolution Setting");
            ToolTipApp.SetToolTip(pbMoveButton, "Move");


            //Later In V1.2
            //ToolTipApp.SetToolTip(pbExit, "Exit (Alt+L)");

            //ToolTipApp.SetToolTip(pbMic, "Mute\\Unmute (Alt+M)");

            //ToolTipApp.SetToolTip(pbStartRecording, "Start\\Pause Recording (Ctrl+Alt+V)");

            //ToolTipApp.SetToolTip(pbRecordSetting, "Resolution Setting (Alt+R)");


        }


        private void frmScreenVideoTab_Load(object sender, EventArgs e)

        {

            LoadTransperantKey();

            LoadAppLocation();

            LoadMicStatus();

            LoadToolTip();

            LoadResolutionOptions();

            ShowApp();

            this.KeyPreview = true;

            this.KeyDown += (s, ev) =>

            {

                if (ev.KeyCode == Keys.Escape)

                {

                    if (_isRecording)

                        StopRecording();



                    HideAppAnimated();

                }

            };

            LoadSettingTab();
            this.LocationChanged += frmScreenVideoTab_LocationChanged;
            //RegisterAllHotkeys();

        }


        private void ToggleRecordingWindow()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(ToggleRecordingWindow));
                return;
            }

            bool isCurrentlyVisible = this.Opacity > 0 && this.Visible;

            if (isCurrentlyVisible)
            {
                this.Opacity = 0;
                this.Hide();
                _mainApp.UpdateToggleRecordingWindowLabel(false);
            }
            else
            {

                this.Opacity = 1;
                this.Show();
                this.Activate();
                this.BringToFront();

                pnlRecordSettingTab.Visible = false;
                pbRecordSetting.Visible = false;
                pbExit.Visible = false;

                _mainApp.UpdateToggleRecordingWindowLabel(true);
            }
        }
        private void LoadResolutionOptions()

        {

            cmbResolution.Items.Clear();

            cmbResolution.Items.Add("System Resolution");

            cmbResolution.Items.Add("1920 × 1080 (Full HD)");

            cmbResolution.Items.Add("1280 × 720 (HD)");

            cmbResolution.Items.Add("854 × 480 (SD)");

            cmbResolution.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbResolution.SelectedIndex = 0;


        }



        private Recorder _recorder;

        private bool _isRecording = false;

        private bool _micEnabled = true;

        private string _outputPath = "";

        int RecordingTime = 0;


        private RecorderOptions _currentOptions;


        void LoadAppLocation()

        {

            int x = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2 - 20;

            int y = this.Height - 550;

            _fixedLocation = new Point(x, y);

            this.Location = _fixedLocation;

        }



        void LoadTransperantKey()

        {

            this.BackColor = Color.Black;

            this.TransparencyKey = Color.Black;

        }



        private void StartRecording()

        {

            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), "Screenshot-X");

            Directory.CreateDirectory(folder);

            _outputPath = Path.Combine(folder, $"Recording_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.mp4");

            ScreenSize outputSize = null;



            switch (cmbResolution.SelectedIndex)

            {

                case 1:

                    outputSize = new ScreenSize(1920, 1080);

                    break;

                case 2:

                    outputSize = new ScreenSize(1280, 720);

                    break;

                case 3:

                    outputSize = new ScreenSize(854, 480);

                    break;

                default:

                    outputSize = null;

                    break;

            }

            _currentOptions = new RecorderOptions

            {

                SourceOptions = new SourceOptions { RecordingSources = { DisplayRecordingSource.MainMonitor } },

                OutputOptions = new OutputOptions

                {

                    RecorderMode = RecorderMode.Video,

                    OutputFrameSize = outputSize,

                    Stretch = StretchMode.Uniform

                },

                VideoEncoderOptions = new VideoEncoderOptions

                {

                    Bitrate = 8000 * 1000,

                    Framerate = 30,

                    IsFixedFramerate = true,

                    IsHardwareEncodingEnabled = false,

                    Encoder = new H264VideoEncoder { BitrateMode = H264BitrateControlMode.CBR, EncoderProfile = H264Profile.Main }

                },

                AudioOptions = new AudioOptions

                {

                    Bitrate = AudioBitrate.bitrate_128kbps,

                    Channels = AudioChannels.Stereo,

                    IsAudioEnabled = true,

                    IsInputDeviceEnabled = true,

                    IsOutputDeviceEnabled = true

                }

            };



            _recorder = Recorder.CreateRecorder(_currentOptions);


            _recorder.OnRecordingComplete += (s, args) =>
            {
                _isRecording = false;

                this.Invoke((Action)(() =>
                {
                    _mainApp.SwitchToMainTray();

                    _mainApp.ShowTrayBalloon(
                        "Screenshot X",
                        $"Saved to:\n{_outputPath}",
                        ToolTipIcon.Info);
                }));
            };



            _recorder.OnRecordingFailed += (s, args) =>
            {
                _isRecording = false;

                this.Invoke((Action)(() =>
                {
                    _mainApp.SwitchToMainTray();

                    _mainApp.ShowTrayBalloon(
                        "Screenshot X",
                        "Recording failed",
                        ToolTipIcon.Warning);
                }));
            };



            _recorder.Record(_outputPath);

            _isRecording = true;

        }



        public void StopRecording()
        {
            _recorder?.Stop();

            _isRecording = false;

            RecordTime.Stop();
            RecordingTime = 0;
            lblRecordingTime.Text = "00:00:00";

            LoadImageToPictureBox(pbStartRecording,
                @"Data\Dark Mode\Controls\record tab\Record Video.png");

            pbRecordSetting.Visible = true;
            pbExit.Visible = true;
            cmbResolution.Enabled = true;

            _mainApp.SwitchToMainTray();
        }



        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _mainApp.StopRecordingRequested -= StopRecording;
            _mainApp.ToggleRecordingWindowRequested -= ToggleRecordingWindow;

            if (_isRecording)
                _recorder?.Stop();

            base.OnFormClosing(e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            //In V1.2
            //UnregisterHotKey(this.Handle, (int)HotkeyId.Back);
            //UnregisterHotKey(this.Handle, (int)HotkeyId.TakeScreenVideo);
            //UnregisterHotKey(this.Handle, (int)HotkeyId.MicToggle);
            //UnregisterHotKey(this.Handle, (int)HotkeyId.RecordSetting);

            _animTimer?.Stop();
            _animTimer?.Dispose();
            _animTimer = null;

            RecordTime?.Stop();
            RecordTime?.Dispose();

            CountDownTimer?.Stop();
            CountDownTimer?.Dispose();

            base.OnFormClosed(e);
        }

        private void LoadMicStatus()

        {


            string path = _micEnabled ? @"Data\Dark Mode\Controls\Mic\Unmuted.png" : @"Data\Dark Mode\Controls\Mic\Muted.png";

            LoadImageToPictureBox(pbMic, path);




        }



        public void LoadImageToPictureBox(PictureBox pb, string path)

        {

            string fullPath = Path.Combine(Application.StartupPath, path);

            if (!File.Exists(fullPath)) return;



            var old = pb.Image;

            pb.Image = (Bitmap)Image.FromStream(new MemoryStream(File.ReadAllBytes(fullPath)));

            old?.Dispose();

        }



        private void pbStartRecording_Click(object sender, EventArgs e)
        {
            if (_isRecording)
            {
                StopRecording();

            }
            else
            {


                if (Countdown > 0)
                {
                    lblCountDownTimer.Text = Countdown.ToString();
                    pnlCountDownTimer.Visible = true;
                    lblCountDownTimer.Visible = true;
                    CountDownTimer.Start();
                }
                else
                {

                    BeginActualRecording();
                }
                LoadImageToPictureBox(pbStartRecording, @"Data\\Dark Mode\\Controls\\record tab\\End Record.png");

            }
        }


        private void BeginActualRecording()
        {
            StartRecording();
            RecordTime.Start();
            lblCountDownTimer.Visible = false;
            HideThisTabToggle();
            _mainApp.SwitchToRecordingTray();
        }

        private void pbMic_Click(object sender, EventArgs e)

        {

            _micEnabled = !_micEnabled;

            LoadMicStatus();

            SetMicMute(!_micEnabled); // لو _micEnabled = false، يعني كتم

        }

        private void SetMicMute(bool mute)

        {

            var enumerator = new MMDeviceEnumerator();

            var device = enumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia);

            device.AudioEndpointVolume.Mute = mute;

        }

        private void RecordTime_Tick(object sender, EventArgs e)

        {

            RecordingTime++;

            TimeSpan time = TimeSpan.FromSeconds(RecordingTime);

            lblRecordingTime.Text = time.ToString(@"hh\:mm\:ss");

        }



        // ==================== App Animation ====================

        private Point _fixedLocation;

        private System.Windows.Forms.Timer _animTimer;

        private int _animStep;

        private const int AnimDuration = 300; //ms

        private int _targetY;

        private int _startY;


        private void ShowApp()

        {

            this.Opacity = 0;

            this.WindowState = FormWindowState.Normal;

            this.Show();

            this.BringToFront();



            _targetY = _fixedLocation.Y;

            _startY = _targetY - 80;

            this.Location = new Point(_fixedLocation.X, _startY);



            _animStep = 0;

            _animTimer?.Stop();

            _animTimer = new System.Windows.Forms.Timer { Interval = 15 };

            _animTimer.Tick += AnimTimer_Tick;

            _animTimer.Start();

        }


        private void AnimTimer_Tick(object sender, EventArgs e)

        {

            _animStep += 15;

            double t = Math.Min(1.0, (double)_animStep / AnimDuration);



            double eased = EaseOutBack(t);



            int newY = (int)(_startY + (_targetY - _startY) * eased);

            this.Location = new Point(this.Location.X, newY);

            this.Opacity = Math.Min(1.0, t * 1.5);



            if (t >= 1.0)

            {

                _animTimer.Stop();

                this.Location = new Point(this.Location.X, _targetY);

                this.Opacity = 1;

            }

        }


        private double EaseOutBack(double t)

        {

            const double c1 = 1.70158;

            const double c3 = c1 + 1;

            return 1 + c3 * Math.Pow(t - 1, 3) + c1 * Math.Pow(t - 1, 2);

        }


        private void HideAppAnimated()

        {

            _animStep = 0;

            _targetY = this.Location.Y + 40; // ينزل 40px لتحت وهو يصغر

            _startY = this.Location.Y;



            _animTimer?.Stop();

            _animTimer = new System.Windows.Forms.Timer { Interval = 10 };

            _animTimer.Tick += HideTimer_Tick;

            _animTimer.Start();

        }


        private void HideTimer_Tick(object sender, EventArgs e)

        {

            _animStep += 10;

            double t = Math.Min(1.0, (double)_animStep / 150); // 150ms، أسرع من الدخول



            double eased = t * t; // ease-in بسيط



            int newY = (int)(_startY + (_targetY - _startY) * eased);

            this.Location = new Point(this.Location.X, newY);

            this.Opacity = 1 - eased;

            if (t >= 1.0)

            {

                _animTimer.Stop();

                this.Close(); // بدل this.Visible = false

            }

        }


        private void pbExit_Click(object sender, EventArgs e)

        {

            HideAppAnimated();

        }



        private void pbResolutionSetting_Click(object sender, EventArgs e)

        {

            pnlRecordSettingTab.Visible = !pnlRecordSettingTab.Visible;

        }


        private void pnlVideoTab_Click(object sender, EventArgs e)

        {

            cmbResolution.DropDownStyle = ComboBoxStyle.DropDownList; ;

        }

        private void frmScreenVideoTab_Deactivate(object sender, EventArgs e)

        {

            pnlRecordSettingTab.Visible = false;

        }


        bool IsHidden = true;
        private void LoadSettingTab()
        {
            Color BackColor = ColorTranslator.FromHtml("#151515");
            Color ForeColor = ColorTranslator.FromHtml("#60CDFF");

            ckbHideTab.BackColor = BackColor;

            ckbHideTab.BackColor = BackColor;

            lblDash1.BackColor = BackColor;
            lblDash2.BackColor = BackColor;

            ckbHideTab.ForeColor = ForeColor;

            lblSetCountdownInSec.BackColor = BackColor;

            lblSetCountdownInSec.ForeColor = ForeColor;

            lblDash1.ForeColor = ForeColor;
            lblDash2.ForeColor = ForeColor;

        }

        private void ckbHideTab_CheckedChanged(object sender, EventArgs e)
        {

            IsHidden = ckbHideTab.Checked;
        }

        private void HideThisTabToggle()
        {
            if (ckbHideTab.Checked)
                this.Opacity = IsHidden ? 0 : 1;
            else
            {
                pnlRecordSettingTab.Visible = false;

                pbRecordSetting.Visible = false;

                pbExit.Visible = false;


            }
        }


        //======================= Countdown =====================

        private int Countdown = 3;

        private void tbxCountdown_Sec_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbxCountdown_Sec.Text, out int value))
            {
                Countdown = value;
            }
            else
            {
                Countdown = 3;
            }
            tbxCountdown_Sec.Text = Countdown.ToString();
        }

        private void CountDownTimer_Tick(object sender, EventArgs e)
        {
            pnlCountDownTimer.Visible = true;
            Countdown--;
            lblCountDownTimer.Text = Countdown.ToString();

            if (Countdown <= 0)
            {
                CountDownTimer.Stop();

                pnlCountDownTimer.Visible = false;

                BeginActualRecording();

            }


        }



        private frmMainApp _mainApp;



        // ====================  Move Button  ====================


        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;


        private void DragForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            }
        }

        private void pbMoveButton_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm(sender, e);
        }

        private void frmScreenVideoTab_LocationChanged(object sender, EventArgs e)
        {

            if (_animTimer == null || !_animTimer.Enabled)
            {
                _fixedLocation = this.Location;
            }
        }



        // ====================   Hotkey   ====================
        //[DllImport("user32.dll")]

        //private static extern bool RegisterHotKey(
        //    IntPtr hWnd,
        //    int id,
        //    int fsModifiers,
        //    int vk);

        //private const int HOTKEY_ID = 1;

        //private enum HotkeyId
        //{
        //    Back = 100,
        //    TakeScreenVideo = 101,
        //    MicToggle = 102,
        //    RecordSetting = 103
        //}

        //private const int MOD_CONTROL = 0x0002;
        //private const int MOD_SHIFT = 0x0004;
        //private const int MOD_WIN = 0x0008;
        //private const int MOD_ALT = 0x0001;
        //private const int WH_KEYBOARD_LL = 13;
        //private const int WM_KEYDOWN = 0x0100;
        //private const int VK_ESCAPE = 0x1B;
        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == 0x0312) // WM_HOTKEY
        //    {
        //        switch ((HotkeyId)m.WParam.ToInt32())
        //        {
        //            case HotkeyId.Back:
        //                pbExit_Click(this, EventArgs.Empty);
        //                break;
        //            case HotkeyId.TakeScreenVideo:
        //                pbStartRecording_Click(this, EventArgs.Empty);
        //                break;
        //            case HotkeyId.MicToggle:
        //                pbMic_Click(this, EventArgs.Empty);
        //                break;
        //            case HotkeyId.RecordSetting:
        //                pbResolutionSetting_Click(this, EventArgs.Empty);
        //                break;

        //        }
        //        base.WndProc(ref m);
        //    }


        //}

        //private void RegisterAllHotkeys()
        //{
        //    RegisterHotKey(this.Handle, (int)HotkeyId.Back, MOD_ALT, (int)Keys.L);
        //    RegisterHotKey(this.Handle, (int)HotkeyId.TakeScreenVideo, MOD_CONTROL | MOD_ALT, (int)Keys.V); 
        //    RegisterHotKey(this.Handle, (int)HotkeyId.MicToggle, MOD_ALT, (int)Keys.M);
        //    RegisterHotKey(this.Handle, (int)HotkeyId.RecordSetting, MOD_ALT, (int)Keys.R);
        //}



    }
}