using AForge.Video;
using AForge.Video.DirectShow;
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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Diagnostics;

namespace Screenshot_X.Forms

{

    public partial class frmScreenVideoTab : Form

    {
         

        private NotifyIcon trayIcon;
        private frmMainApp _mainApp;


        public frmScreenVideoTab(frmMainApp mainApp)
        {
            InitializeComponent();
            _mainApp = mainApp;

            _mainApp.StopRecordingRequested += StopRecording;
            _mainApp.PauseRecordingRequested += PauseOrResumeRecording;
            _mainApp.ResumeRecordingRequested += PauseOrResumeRecording;

            _mainApp.ToggleRecordingWindowRequested += ToggleRecordingWindow;  
        }

        private void frmScreenVideoTab_Load(object sender, EventArgs e)
        {
            StartUpRecordTab();
        }

        private void StartUpRecordTab()
        {
            LoadTransperantKey();

            LoadAppLocation();


            LoadToolTip();

            LoadCameraDataToTab();

            ShowApp();

            this.KeyPreview = true;
            this.KeyDown += (s, ev) =>

            {

                if (ev.KeyCode == Keys.Escape)

                {

                    if (IsRecordingNow)

                        StopRecording();



                    HideAppAnimated();

                }

            };

            LoadFontColorSettingTab();

            this.LocationChanged += frmScreenVideoTab_LocationChanged;

            pbStartRecording.Location = new Point(60, 12);

            RegisterAllHotkeys();

            Properties.Settings.Default.Save();

            LoadCurrentCameraSizeToComboBox();
            InitCameraPreview();
            RestorUserSettings();
            LoadCameraStatus();
            LoadMicStatus();
            LoadSystemSoundStatus();
            ShowCurrentPathTotbxScreenVideoPath();

            tbxBorderRadius.Enabled = !cbxCricleCamera.Checked;

        }



        // ==================== Save And Restore Setting Record Tab ====================
        void RestorUserSettings()
        {
            Load_RecordTabIsHiddenWhenRecording_Setting();

            Load_Camera_Setting();

            Load_MicAndSound_Setting();

            Load_Countdown_Setting();

            Load_ScreenVideoPath_Setting();
        }
        void SaveUserSettings()
        {
            Properties.Settings.Default.Countdown = Countdown;
            Properties.Settings.Default.RecordTabIsHiddenWhenRecording = RecordTabIsHiddenWhenRecording;

            Properties.Settings.Default.ResolutionSelectedIndex = cmbResolution.SelectedIndex;

            Save_Camera_Setting();
            Save_MicAndSound_Setting();

            Save_ScreenVideoPath_Setting();

            Properties.Settings.Default.Save();
        }

        //Load
        private void Load_ScreenVideoPath_Setting()
        {
            string savedPath = Properties.Settings.Default.ScreenVideoSavePath;

            if (!string.IsNullOrWhiteSpace(savedPath) && Directory.Exists(savedPath))
            {
                CurrentScreenVideoPath = savedPath;
            }
            else
            {
                CurrentScreenVideoPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyVideos),
                    "Screenshot-X");

                Directory.CreateDirectory(CurrentScreenVideoPath);
            }
        }

        private void Load_RecordTabIsHiddenWhenRecording_Setting()
        {
            RecordTabIsHiddenWhenRecording = Properties.Settings.Default.RecordTabIsHiddenWhenRecording;
            ckbHideTab.Checked = RecordTabIsHiddenWhenRecording;

        }

        private void Load_IsCircleCamera_Setting()
        {
            _CameraOverlay.IsCircleCamera = Properties.Settings.Default.IsCircleCamera;
            cbxCricleCamera.Checked = _CameraOverlay.IsCircleCamera;

        }
        private void Load_cbxCricleCamera_Setting()
        {
            tbxBorderRadius.Enabled = !cbxCricleCamera.Checked;
            tbxBorderRadius.Cursor = tbxBorderRadius.Enabled ? Cursors.IBeam : Cursors.No;

        }
        private void Load_isCameraON_Setting()
        {
            isCameraON = Properties.Settings.Default.isCameraON;
        }
        private void Load_cmbCameraSizeSelectedIndex_Setting()
        {
            cmbCameraSizeSelectedIndex = Properties.Settings.Default.cmbCameraSizeSelectedIndex;
            cmbCameraSize.SelectedIndex = cmbCameraSizeSelectedIndex;

        }
        private void Load_CameraBorderRadius_Setting()
        {
            CameraBorderRadius = Properties.Settings.Default.CameraBorderRadius;
            tbxBorderRadius.Text = CameraBorderRadius.ToString();

        }
        private void Load_Camera_Setting()
        {
            

            Load_cbxCricleCamera_Setting();

            Load_IsCircleCamera_Setting();

            Load_isCameraON_Setting();

            Load_cmbCameraSizeSelectedIndex_Setting();

            Load_CameraBorderRadius_Setting();

            Load_CameraSize_Setting();


        } 
        private void Load_MicAndSound_Setting()
        {
            _micEnabled = Properties.Settings.Default._micEnabled;
            _systemSoundEnabled = Properties.Settings.Default.SystemSoundEnabled;
        }
        private void Load_Countdown_Setting()
        {

            Countdown = Properties.Settings.Default.Countdown;
            tbxCountdown_Sec.Text = Countdown.ToString();
        }
        private void Load_CameraSize_Setting()
        {
           
            CameraWidth = Properties.Settings.Default.CameraWidth;
            CameraHeight = Properties.Settings.Default.CameraHeight;

            
            tbxWidth.Text = CameraWidth.ToString();
            tbxHeight.Text = CameraHeight.ToString();
        }

        private void Load_Resolution_Setting()
        {
            int savedIndex = Properties.Settings.Default.ResolutionSelectedIndex;

            if (savedIndex >= 0 && savedIndex < cmbResolution.Items.Count)
            {
                cmbResolution.SelectedIndex = savedIndex;
            }
            else
            {
                cmbResolution.SelectedIndex = 0;  
            }
        }


        //Save
        private void Save_MicAndSound_Setting()
        {
            Properties.Settings.Default._micEnabled = _micEnabled;
            Properties.Settings.Default.SystemSoundEnabled = _systemSoundEnabled;
        }
        private void Save_Camera_Setting()
        {
            Properties.Settings.Default.isCameraON = isCameraON;

            Properties.Settings.Default.IsCircleCamera = cbxCricleCamera.Checked;
            
            Properties.Settings.Default.CameraBorderRadius = CameraBorderRadius; Properties.Settings.Default.cmbCameraSizeSelectedIndex = cmbCameraSizeSelectedIndex;
           
            Properties.Settings.Default.cmbCameraSizeSelectedIndex = cmbCameraSizeSelectedIndex;
            
            if (int.TryParse(tbxWidth.Text, out int w))
            {
                Properties.Settings.Default.CameraWidth = w;
            }

            if (int.TryParse(tbxHeight.Text, out int h))
            {
                Properties.Settings.Default.CameraHeight = h;
            }

        }



        // ==================== Main Setting Record Tab ====================

        public void LoadImageToPictureBox(PictureBox pb, string path)

        {

            string fullPath = Path.Combine(Application.StartupPath, path);

            if (!File.Exists(fullPath)) return;



            var old = pb.Image;

            pb.Image = (Bitmap)Image.FromStream(new MemoryStream(File.ReadAllBytes(fullPath)));

            old?.Dispose();

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

            Load_Resolution_Setting();
        }

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


        bool RecordTabIsHiddenWhenRecording = true;

        private void LoadFontColorSettingTab()
        {
            Color BackColor = ColorTranslator.FromHtml("#151515");
            Color ForeColor = ColorTranslator.FromHtml("#60CDFF");

            /*    tbxBorderRadius.ForeColor = ForeColor;
                tbxCountdown_Sec.ForeColor = ForeColor;
                tbxHeight.ForeColor = ForeColor;
                tbxWidth.ForeColor = ForeColor;
                ckbHideTab.BackColor = BackColor;
                ckbHideTab.ForeColor = ForeColor;
                cbxCricleCamera.BackColor = BackColor;
                cbxCricleCamera.ForeColor = ForeColor;*/


            lblDefaultScreenshotPath.BackColor = BackColor;
            lblDefaultScreenshotPath.ForeColor = ForeColor;

            lblResolution.BackColor = BackColor;
            lblResolution.ForeColor = ForeColor;

            lblRecordSetting.BackColor = BackColor;
            lblRecordSetting.ForeColor = ForeColor;


            lblCustomSize.BackColor = BackColor;
            lblCustomSize.ForeColor = ForeColor;


            lblSetCountdownInSec.BackColor = BackColor;
            lblSetCountdownInSec.ForeColor = ForeColor;

           
            lblCameraSize.BackColor = BackColor;
            lblCameraSize.ForeColor = ForeColor;

            lblMulti.BackColor = BackColor;
            lblMulti.ForeColor = ForeColor;

            lblResetSize.BackColor = BackColor;
            lblResetSize.ForeColor = ForeColor;

            lblResetBorderRadius.BackColor = BackColor;
            lblResetBorderRadius.ForeColor = ForeColor;

            lblCameraBorderRadius.BackColor = BackColor;
            lblCameraBorderRadius.ForeColor = ForeColor;



        }

        private void ckbHideTab_CheckedChanged(object sender, EventArgs e)
        {

            RecordTabIsHiddenWhenRecording = ckbHideTab.Checked;

        }

        private void HideThisTabToggle()
        {
            if (ckbHideTab.Checked)
                this.Opacity = RecordTabIsHiddenWhenRecording ? 0 : 1;
            else
            {
                pnlRecordSettingTab.Visible = false;

                pbRecordSetting.Visible = false;

                pbExit.Visible = false;


            }
        }



        // ==================== Tool Tip App ====================


        private Guna2HtmlToolTip ToolTipApp;

        void LoadToolTip()

        {

            ToolTipApp = new Guna2HtmlToolTip();

            ToolTipApp.SetToolTip(pbSystemSound, "Mute\\Unmute System Sound");

            ToolTipApp.BackColor = Color.Black;

            ToolTipApp.ForeColor = Color.White;




            ToolTipApp.SetToolTip(pbCameraPulseOn, "Camera On !");

            ToolTipApp.SetToolTip(pbRecordSetting, "Screen Video Setting (Alt+R)");

            ToolTipApp.SetToolTip(pbMoveButton, "Move");


            ToolTipApp.SetToolTip(pbStartRecording, "Start\\Stop Recording (Alt+V)");

            ToolTipApp.SetToolTip(pbPause, "Pause\\Resume (Alt+P)");

            ToolTipApp.SetToolTip(pbShowCameraPreview, "Show\\Hide Camera (Alt+K)");

            ToolTipApp.SetToolTip(pbMic, "Mute\\Unmute Mic (Alt+U)");

            ToolTipApp.SetToolTip(pbSystemSound, "Mute\\Unmute System Sound (Alt+Y)");

            ToolTipApp.SetToolTip(pbExit, "Exit (Alt+E)");

       

        }


        // ==================== Recording ====================



        private Recorder _recorder;
        public bool IsRecordingNow = false;
        public bool IsRecordingPasue = false;



        private string _outputPath = "";

        int RecordingTime = 0;


        private RecorderOptions _currentOptions;

        private string CurrentScreenVideoPath;

        private void MainNotification_BalloonTipClicked(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "/select,\"" + _outputPath + "\"");
        }

        private void StartRecording()
        {
            IsRecordingPasue = false;

            if (string.IsNullOrWhiteSpace(CurrentScreenVideoPath) || !Directory.Exists(CurrentScreenVideoPath))
            {
                CurrentScreenVideoPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyVideos),
                    "Screenshot-X");
                Directory.CreateDirectory(CurrentScreenVideoPath);
            }

            _outputPath = Path.Combine(CurrentScreenVideoPath, $"Recording_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.mp4"); ScreenSize outputSize = null;

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
                    IsOutputDeviceEnabled = _systemSoundEnabled    
                }
            };

            _recorder = Recorder.CreateRecorder(_currentOptions);
            _dynamicOptions = _recorder.GetDynamicOptionsBuilder();

            _recorder.OnRecordingComplete += (s, e) =>
            {
                _mainApp.Invoke((Action)(() =>
                {
                    _mainApp.ShowTrayBalloon(
                        "Recording Complete",
                        "Recoring Saved !.",
                        ToolTipIcon.Info);
                }));
            };

            _recorder.OnRecordingFailed += (s, args) =>
            {
                IsRecordingNow = false;

                if (_mainApp != null && !_mainApp.IsDisposed && _mainApp.IsHandleCreated)
                {
                    _mainApp.Invoke((Action)(() =>
                    {
                        _mainApp.SwitchToMainTray();
                        _mainApp.ShowTrayBalloon(
                            "Screenshot X",
                            "Recording failed",
                            ToolTipIcon.Warning);
                    }));
                }
            };


            _recorder.OnRecordingFailed += (s, args) =>
            {
                IsRecordingNow = false;

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
            IsRecordingNow = true;
        }
        public void StopRecording()
        {
            _recorder?.Stop();

            IsRecordingNow = false;

            RecordTime.Stop();
            RecordingTime = 0;
            lblRecordingTime.Text = "00:00:00";

            LoadImageToPictureBox(pbStartRecording,
                @"Data\Dark Mode\Controls\record tab\Record Video.png");

            pbRecordSetting.Visible = true;
            pbExit.Visible = true;
            cmbResolution.Enabled = true;

            StopCameraPreview();

            _mainApp.SwitchToMainTray();
            
            _mainApp.ExitVideoTabMode();    


        }
        public void PauseOrResumeRecording()
        {
            if (!IsRecordingNow) return;

            if (!IsRecordingPasue)
            {
                _recorder?.Pause();
                RecordTime.Stop();
                LoadImageToPictureBox(pbPause, @"Data\Dark Mode\Controls\record tab\Resume.png");
                IsRecordingPasue = true;
            }
            else
            {
                _recorder?.Resume();
                RecordTime.Start();
                LoadImageToPictureBox(pbPause, @"Data\Dark Mode\Controls\record tab\Pause.png");
                IsRecordingPasue = false;
            }

        }

        private void pbStartRecording_Click(object sender, EventArgs e)
        {
            lblRecordingTime_Click(sender, e);
            pnlRecordSettingTab.Visible = false;

            if (IsRecordingNow)
            {
                StopRecording();
                IsRecordingNow = false;
                pnlRecordingControl.Visible = false;
                pbStartRecording.Location = new Point(60, 12);
            }
            else
            {
                
                pbStartRecording.Location = new Point(90, 12);
                if (Countdown > 0)
                {
                    frmCounter CounDown = new frmCounter();
                    _activeCounter = CounDown;
                
                CounDown.Countdown = Countdown;
                CounDown.CountdownFinished += () =>
                {
                    pnlRecordingControl.Visible = true;
                    if (this.IsDisposed || !this.IsHandleCreated)
                        return;

                    this.Invoke((Action)(() =>
                    {
                        BeginActualRecording();
                        LoadImageToPictureBox(pbStartRecording, @"Data\\Dark Mode\\Controls\\record tab\\End Record.png");
                        IsRecordingNow = true;
                    }));
                };
                CounDown.Show();
                }
                else
                {
                    if (this.IsDisposed || !this.IsHandleCreated)
                        return;

                    this.Invoke((Action)(() =>
                    {
                        BeginActualRecording();
                        LoadImageToPictureBox(pbStartRecording, @"Data\\Dark Mode\\Controls\\record tab\\End Record.png");
                        IsRecordingNow = true;
                    }));
                }
            }
        }
        private void pbPause_Click(object sender, EventArgs e)
        {
            PauseOrResumeRecording();
        }



        public void BeginActualRecording()
        {
            StartRecording();
            RecordTime.Start();
           

           
            HideThisTabToggle();

            _mainApp.SwitchToRecordingTray();

          
            if (isCameraON)
            {
                
                _CameraOverlay.TopMost = true;
                _CameraOverlay.Show();
            }
            else
            {
                 
                _CameraOverlay?.StopCamera();
                _CameraOverlay?.Hide();
            }
        }
        private void RecordTime_Tick(object sender, EventArgs e)

        {

            RecordingTime++;

            TimeSpan time = TimeSpan.FromSeconds(RecordingTime);

            lblRecordingTime.Text = time.ToString(@"hh\:mm\:ss");

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _mainApp.StopRecordingRequested -= StopRecording;
            _mainApp.ToggleRecordingWindowRequested -= ToggleRecordingWindow;

            StopCameraPreview();

                

            if (IsRecordingNow)
                _recorder?.Stop();

            SaveUserSettings();

            UnregisterAllHotkeys();

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

            

            base.OnFormClosed(e);
        }



        private void ShowCurrentPathTotbxScreenVideoPath()
        {
            tbxScreenVideoPath.Text = CurrentScreenVideoPath;
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                CurrentScreenVideoPath = folderBrowserDialog1.SelectedPath;
                ShowCurrentPathTotbxScreenVideoPath();
            }
        }
        private void Save_ScreenVideoPath_Setting()
        {
            Properties.Settings.Default.ScreenVideoSavePath = CurrentScreenVideoPath;
        }
        // ==================== Mic And System Sound ====================

        private bool _micEnabled = false;
        private bool _systemSoundEnabled = true;
        private DynamicOptionsBuilder _dynamicOptions;

        private void LoadMicStatus()
        {
            string path = _micEnabled
                ? @"Data\Dark Mode\Controls\Mic\Unmuted.png"
                : @"Data\Dark Mode\Controls\Mic\Muted.png";

            LoadImageToPictureBox(pbMic, path);
        }

        private void SetMicMute(bool mute)
        {
            var enumerator = new MMDeviceEnumerator();
            var device = enumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia);
            device.AudioEndpointVolume.Mute = mute;
        }

        private void pbMic_Click(object sender, EventArgs e)
        {
            _micEnabled = !_micEnabled;
            LoadMicStatus();
            SetMicMute(!_micEnabled);
        }

        private void LoadSystemSoundStatus()
        {
            string path = _systemSoundEnabled
                ? @"Data\Dark Mode\Controls\record tab\VolumeOn.png"
                : @"Data\Dark Mode\Controls\record tab\VolumeOff.png";

            LoadImageToPictureBox(pbSystemSound, path);
        }

        private void MuteUnMuteSystemSound()
        {
            if (IsRecordingNow && _dynamicOptions != null)
            {
                _recorder.GetDynamicOptionsBuilder()
                    .SetDynamicAudioOptions(new DynamicAudioOptions
                    {
                        IsOutputDeviceEnabled = _systemSoundEnabled
                    })
                    .Apply();
            }
        }

        private void pbSystemSound_Click(object sender, EventArgs e)
        {
            _systemSoundEnabled = !_systemSoundEnabled;
            MuteUnMuteSystemSound();
            LoadSystemSoundStatus();
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


        private frmCounter _activeCounter;  

        private void pbExit_Click(object sender, EventArgs e)
        {
            _activeCounter?.Close();   
            StopCameraPreview();
            HideAppAnimated();
        }


        private void pbShowReCordnSettingTab_Click(object sender, EventArgs e)

        {
        
            pnlRecordSettingTab.Visible = !pnlRecordSettingTab.Visible;

        }


        private void pnlVideoTab_Click(object sender, EventArgs e)

        {

            cmbResolution.DropDownStyle = ComboBoxStyle.DropDownList; 
            cmbCameraSize.DropDownStyle = ComboBoxStyle.DropDownList; 
            pnlRecordSettingTab.Visible=false;
        }

        private void frmScreenVideoTab_Deactivate(object sender, EventArgs e)

        {

            pnlRecordSettingTab.Visible = false;

        }


     


        //======================= Countdown =====================

        public int Countdown = 3;
      
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
            pnlRecordSettingTab.Visible = false;
            DragForm(sender, e);
        }

        private void frmScreenVideoTab_LocationChanged(object sender, EventArgs e)
        {

            if (_animTimer == null || !_animTimer.Enabled)
            {
                _fixedLocation = this.Location;
            }
        }



        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int MOD_ALT = 0x0001;

        private enum RecordHotkeyId
        {
            ToggleRecording = 200,
            PauseResume = 201,
            ToggleCamera = 202,
            ToggleMic = 203,
            ToggleSystemSound = 204,
            ExitTab = 205,
         ShowSettings = 206
        }

        private void RegisterAllHotkeys()
        {
            RegisterHotKey(this.Handle, (int)RecordHotkeyId.ToggleRecording, MOD_ALT, (int)Keys.V);
            RegisterHotKey(this.Handle, (int)RecordHotkeyId.PauseResume, MOD_ALT, (int)Keys.P);
            RegisterHotKey(this.Handle, (int)RecordHotkeyId.ToggleCamera, MOD_ALT, (int)Keys.K);
            RegisterHotKey(this.Handle, (int)RecordHotkeyId.ToggleMic, MOD_ALT, (int)Keys.U);
            RegisterHotKey(this.Handle, (int)RecordHotkeyId.ToggleSystemSound, MOD_ALT, (int)Keys.Y);
            RegisterHotKey(this.Handle, (int)RecordHotkeyId.ExitTab, MOD_ALT, (int)Keys.E);
            RegisterHotKey(this.Handle, (int)RecordHotkeyId.ShowSettings, MOD_ALT, (int)Keys.R);   // ← جديد
        }

        private void UnregisterAllHotkeys()
        {
            foreach (RecordHotkeyId id in Enum.GetValues(typeof(RecordHotkeyId)))
                UnregisterHotKey(this.Handle, (int)id);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312) // WM_HOTKEY
            {
                RecordHotkeyId hotkey = (RecordHotkeyId)m.WParam.ToInt32();

                switch (hotkey)
                {
                    case RecordHotkeyId.ToggleRecording:
                        pbStartRecording_Click(this, EventArgs.Empty);
                        break;

                    case RecordHotkeyId.PauseResume:
                        PauseOrResumeRecording();
                        break;

                    case RecordHotkeyId.ToggleCamera:
                        pbShowCameraPreview_Click(this, EventArgs.Empty);
                        break;

                    case RecordHotkeyId.ToggleMic:
                        pbMic_Click(this, EventArgs.Empty);
                        break;

                    case RecordHotkeyId.ToggleSystemSound:
                        pbSystemSound_Click(this, EventArgs.Empty);
                        break;

                    case RecordHotkeyId.ExitTab:
                        pbExit_Click(this, EventArgs.Empty);
                        break;

                    case RecordHotkeyId.ShowSettings:
                        pbShowReCordnSettingTab_Click(this, EventArgs.Empty);
                        break;
                }
            }
            base.WndProc(ref m);
        }

        public void ForceShow()
        {
            this.Opacity = 1;
            this.Show();
            this.Activate();
            this.BringToFront();
        }



        // ====================  Camera Preview  ====================
        private frmCameraOverlay _CameraOverlay;
        bool isCameraON=false;
        bool IsCustomSizeMode=false;
        int CameraWidth= 192;
        int CameraHeight= 111;
        int  CameraBorderRadius = 30;
        int cmbCameraSizeSelectedIndex = 1;
         private void LoadCurrentCameraSizeToComboBox()
        {
            tbxWidth.Text = CameraWidth.ToString();
            tbxHeight.Text = CameraHeight.ToString();

        }
        private void   LoadCameraDataToTab()
        {
            LoadResolutionOptions();

            LoadCameraSizeOptions();

            LoadCurrentCameraSizeToComboBox();

        }
        private void InitCameraPreview()
        {
            _CameraOverlay = new frmCameraOverlay();
        
        }

        private void StopCameraPreview()
        {
            _CameraOverlay?.StopCamera();
            _CameraOverlay?.Close();
        }

        void LoadCameraStatus()
        {
            if (!isCameraON)
            {

                _CameraOverlay?.StopCamera();
                _CameraOverlay?.Hide();
                LoadImageToPictureBox(pbShowCameraPreview, "Data/Dark Mode/Controls/record tab/Camera Off.png");
                isCameraON = false;
                pbCameraPulseOn.Visible = false;

            }
            else
            {

                _CameraOverlay?.Show();
                _CameraOverlay?.StartCamera();
                LoadImageToPictureBox(pbShowCameraPreview, "Data/Dark Mode/Controls/record tab/Camera On.png");
                isCameraON = true;
                pbCameraPulseOn.Visible = true;
            }
        }
        private void pbShowCameraPreview_Click(object sender, EventArgs e)
        {
            isCameraON = !isCameraON;
            LoadCameraStatus();
        }

        private void tbxWidth_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbxWidth.Text, out int value) && value > 0)
            {
                CameraWidth = value;
                if (_CameraOverlay != null)
                    _CameraOverlay.Size = new Size(CameraWidth, CameraHeight);
            }
        }

        private void tbxHeight_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbxHeight.Text, out int value) && value > 0)
            {
                CameraHeight = value;
                if (_CameraOverlay != null)
                    _CameraOverlay.Size = new Size(CameraWidth, CameraHeight);
            }
        }

        private void lblRecordingTime_Click(object sender, EventArgs e)
        {
            pnlRecordSettingTab.Visible = false;
        }

        private void lblResetSize_Click(object sender, EventArgs e)
        {

            _CameraOverlay.Size = new Size(192, 111);

            LoadCurrentCameraSizeToComboBox();

            cmbCameraSize.SelectedIndex = cmbCameraSizeSelectedIndex;
        }

        private void SetBorderRadiusForCameraPrev(int Value)
        {
            _CameraOverlay.pbCameraPrev.BorderRadius = Value;
             
            tbxBorderRadius.Text = Value.ToString();
        }

        private void lblCameraSize_Click(object sender, EventArgs e)
        {

        }

        private void tbxBorderRadius_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbxBorderRadius.Text, out int value) && value >= 0)
            {
                CameraBorderRadius = value;
                if (_CameraOverlay != null)
                    SetBorderRadiusForCameraPrev(CameraBorderRadius);
            }
        }

        private void lblResetBorderRadius_Click(object sender, EventArgs e)
        {
            SetBorderRadiusForCameraPrev(30);
        }

        private void LoadCameraSizeOptions()

        {

            cmbCameraSize.Items.Clear();

            cmbCameraSize.Items.Add("Small");

            cmbCameraSize.Items.Add("Meduim");

            cmbCameraSize.Items.Add("Large");

            cmbCameraSize.Items.Add("Custom Mode !");

            

            cmbCameraSize.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbCameraSize.SelectedIndex = 1;


        }

        private void EnabledOrDisabletbxWidth_Height(bool Value)
        {
            tbxWidth.Enabled = Value;
            tbxHeight.Enabled = Value;
            LoadCurrentCameraSizeToComboBox();
            if (tbxWidth.Enabled)
            {
                tbxWidth.Cursor = Cursors.No;
                tbxHeight.Cursor = Cursors.No;
            }
            else
            {
                tbxWidth.Cursor = Cursors.IBeam;
                tbxHeight.Cursor = Cursors.IBeam;
            }

        }

        private void cmbCameraSize_SelectedIndexChanged(object sender, EventArgs e)
        {       IsCustomSizeMode = false;
            switch (cmbCameraSize.SelectedIndex)
            {  
                case 0:  
                    CameraWidth = 192;
                    CameraHeight = 111;
                    
                  
                    break;

                case 1: 
                    CameraWidth = 320;
                    CameraHeight = 180;
                    

                    break;

                case 2:  
                    CameraWidth = 480;
                    CameraHeight = 270;
                     

                    break;

                case 3:
                    IsCustomSizeMode = true;
                  
                    break;
            }
            EnabledOrDisabletbxWidth_Height(IsCustomSizeMode);

            LoadCurrentCameraSizeToComboBox();

            if (_CameraOverlay != null)
                _CameraOverlay.Size = new Size(CameraWidth, CameraHeight);

            cmbCameraSizeSelectedIndex = cmbCameraSize.SelectedIndex;

        }
       
        private void cbxCricleCamea_Click(object sender, EventArgs e)
        {
            
            _CameraOverlay.IsCircleCamera = cbxCricleCamera.Checked;

            tbxBorderRadius.Enabled= !cbxCricleCamera.Checked;

            if (  tbxBorderRadius.Enabled)
            {
                tbxBorderRadius.Cursor = Cursors.IBeam;

            }
            else
            {
                tbxBorderRadius.Cursor = Cursors.No;

            }

           
        }

      
    }
}