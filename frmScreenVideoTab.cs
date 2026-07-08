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

namespace Screenshot_X.Forms
{
    public partial class frmScreenVideoTab : Form
    {
        private NotifyIcon trayIcon;

        public frmScreenVideoTab(NotifyIcon icon)
        {
            InitializeComponent();
            trayIcon = icon;
        }

        private Guna2HtmlToolTip ToolTipApp;
        void LoadToolTip()
        {
            ToolTipApp = new Guna2HtmlToolTip();

            ToolTipApp.BackColor= Color.Black;
            ToolTipApp.ForeColor= Color.White;

            ToolTipApp.SetToolTip(lblExit, "Exit");
            ToolTipApp.SetToolTip(pbMic, "Mute\\Unmute");
            ToolTipApp.SetToolTip(pbStartRecording, "Start\\Pause Recording");


        }
        private void frmScreenVideoTab_Load(object sender, EventArgs e)
        {   
            LoadTransperantKey();
            LoadAppLocation();
            LoadMicStatus();
            LoadToolTip();
            ShowApp();
            //lblCounter.ForeColor = ColorTranslator.FromHtml("#151515"); ;
            //lblExit.ForeColor = ColorTranslator.FromHtml("#151515"); 
        } 

        private Recorder _recorder;
        private bool _isRecording = false;
        private bool _micEnabled = true;
        private string _outputPath = "";
        int _elapsedSeconds = 0;
        private RecorderOptions _currentOptions;


        void LoadAppLocation()
        {
            int x = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2 - 20;
            int y = this.Height - 230;
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

            _currentOptions = new RecorderOptions
            {
                SourceOptions = new SourceOptions { RecordingSources = { DisplayRecordingSource.MainMonitor } },
                OutputOptions = new OutputOptions { RecorderMode = RecorderMode.Video },
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
                this.Invoke((Action)(() => trayIcon.ShowBalloonTip(1500, "Screenshot X", $"Saved to:\n{_outputPath}", ToolTipIcon.Info)));
            };

            _recorder.OnRecordingFailed += (s, args) =>
            {
                _isRecording = false;
                this.Invoke((Action)(() => trayIcon.ShowBalloonTip(1500, "Screenshot X", "Recording failed", ToolTipIcon.Warning)));
            };

            _recorder.Record(_outputPath);
            _isRecording = true;
           
        }

        private void StopRecording()
        {
            _recorder?.Stop();
            _isRecording = false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_isRecording) _recorder?.Stop();
            base.OnFormClosing(e);
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
                LoadImageToPictureBox(pbStartRecording, @"Data\\Dark Mode\\Controls\\record tab\\Record Video.png");
                RecordTime.Stop();
                lblCounter.Text = "00:00:00";
            }
            else
            {

                StartRecording();
                LoadImageToPictureBox(pbStartRecording, @"Data\\Dark Mode\\Controls\\record tab\\End Record.png");
                RecordTime.Start();

            }


        }
      
        private void lblExit_Click(object sender, EventArgs e)
        {
            HideAppAnimated();
          
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
            _elapsedSeconds++;
            TimeSpan time = TimeSpan.FromSeconds(_elapsedSeconds);
            lblCounter.Text = time.ToString(@"hh\:mm\:ss");
        }

        // ====================  App  Animation  ====================
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
            this.Opacity = Math.Min(1.0, t * 1.5); // fade in أسرع من الحركة

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
    }
}
