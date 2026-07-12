using Guna.UI2.WinForms;
using Screenshot_X.Forms;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Tesseract;



namespace Screenshot_X
{
    public partial class frmMainApp : Form
    {

        private frmScreenVideoTab _recordForm;

        public frmMainApp()
        {
            InitializeComponent();
            LoadTransperantKey();


        }

        private void frmMainApp_Load(object sender, EventArgs e)
        {
            LoadMainTrayIcon();
            LoadRecordingTrayIcon();
            LoadToolTip();
            LoadContextectMenueForIconTray();
           
            LoadAppLocation();

            LoadScreenshotModeOptions();

            MainNotification.MouseClick += (s, args) =>
            {
                if (args.Button == MouseButtons.Left)
                {
                    if (_isInVideoTab) return; 

                    if (this.Visible)
                        HideAppAnimated();
                    else
                        ShowApp();
                }
            };

            this.Hide();
            this.ShowInTaskbar = false;
            ShowApp();

            RegisterAllHotkeys();


            this.KeyPreview = true;
            this.KeyDown += frmMainApp_KeyDown;

            this.TopMost  = true;

            this.Activate();

            this.LocationChanged += frmMainApp_LocationChanged;

        }
       
       
       
        void LoadTransperantKey()
        {
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;

        }



        private Point _fixedLocation;
        void LoadAppLocation()
        {
            int x = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2 - 20;
            int y = this.Height - 230;
            _fixedLocation = new Point(x, y);
            this.Location = _fixedLocation;
        }



        [DllImport("user32.dll")]private static extern bool SetForegroundWindow(IntPtr hWnd);
        private void pnlMainApp_Enter(object sender, EventArgs e)
        {
            SetForegroundWindow(this.Handle);
        }


        public void LoadImageToPictureBox(PictureBox pb, string path)
        {
            string fullPath = Path.Combine(Application.StartupPath, path);
            if (!File.Exists(fullPath)) return;

            var old = pb.Image;
            pb.Image = (Bitmap)Image.FromStream(new MemoryStream(File.ReadAllBytes(fullPath)));
            old?.Dispose();
        }

        public void LoadImageToPictureBox(Guna2PictureBox pb, string path)
        {
            string fullPath = Path.Combine(Application.StartupPath, path);
            if (!File.Exists(fullPath)) return;

            var old = pb.Image;
            pb.Image = (Bitmap)Image.FromStream(new MemoryStream(File.ReadAllBytes(fullPath)));
            old?.Dispose();
        }

        // ====================   Hotkey   ====================

        private bool _isProcessingHotkey = false;
        [DllImport("user32.dll")] private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll")]private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        private const int HOTKEY_ID = 1;
        private const int HOTKEY_ID_2 = 2;

       
        private const int MOD_CONTROL = 0x0002;
        private const int MOD_SHIFT = 0x0004;
         private const int MOD_WIN = 0x0008;
        private const int MOD_ALT = 0x0001;
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int VK_ESCAPE = 0x1B;

        private enum HotkeyId
        {
            ToggleApp = 1,
         
            OCR,

            ColorPicker,

            ShowScreenshotModeTab,
            
            TakeScreenshot,
            
            TakeScreenVideoTab,
            QuitApp
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312) // WM_HOTKEY
            {
                // إذا كان البرنامج يقوم بمعالجة اختصار حالياً، تجاهل الضغطة الجديدة فوراً
                if (_isProcessingHotkey)
                {
                    base.WndProc(ref m);
                    return;
                }

                HotkeyId hotkey = (HotkeyId)m.WParam.ToInt32();

                // قفل المعالجة لمنع الدخول المتكرر
                _isProcessingHotkey = true;

                try
                {
                    switch (hotkey)
                    {
                        case HotkeyId.ToggleApp:
                            if (_isInVideoTab) break;
                            if (this.Visible) HideAppAnimated(); else ShowApp();
                            break;

                        case HotkeyId.TakeScreenVideoTab:
                            // فحص إضافي للتأكد أن نافذة الفيديو ليست مفتوحة بالفعل
                            if (!_isInVideoTab && _recordForm == null)
                            {
                                LoadScreenVideoTab();
                            }
                            break;

                        case HotkeyId.ShowScreenshotModeTab:
                            cmbScreenshotMode.Visible = !cmbScreenshotMode.Visible;
                            cmbScreenshotMode.DropDownStyle = ComboBoxStyle.DropDownList;
                            break;

                        case HotkeyId.QuitApp:
                            this.Close();
                            break;

                        case HotkeyId.OCR:
                            pbExtractText_Click(this, EventArgs.Empty);
                            break;

                        case HotkeyId.ColorPicker:
                            pbColorPicker_Click(this, EventArgs.Empty);
                            break;

                        case HotkeyId.TakeScreenshot:
                            pbScreenshotMode_Click(this, EventArgs.Empty);
                            break;
                    }
                }
                finally
                {
                    
                    _isProcessingHotkey = false;
                }
            }
            base.WndProc(ref m);
        }

        private void RegisterAllHotkeys()
        {
           
            RegisterHotKey(this.Handle, (int)HotkeyId.ToggleApp, MOD_ALT, (int)Keys.L);

        
            RegisterHotKey(this.Handle, (int)HotkeyId.OCR, MOD_ALT, (int)Keys.O);

           
            RegisterHotKey(this.Handle, (int)HotkeyId.ColorPicker, MOD_ALT, (int)Keys.C);

            
            RegisterHotKey(this.Handle, (int)HotkeyId.TakeScreenshot, MOD_ALT, (int)Keys.S);


            RegisterHotKey(this.Handle, (int)HotkeyId.ShowScreenshotModeTab, MOD_ALT, (int)Keys.M);

         
            RegisterHotKey(this.Handle, (int)HotkeyId.TakeScreenVideoTab, MOD_CONTROL| MOD_ALT, (int)Keys.S);


            RegisterHotKey(this.Handle, (int)HotkeyId.QuitApp, MOD_ALT , (int)Keys.Q);
        }



        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (MainNotification != null)
            {
                MainNotification.Visible = false;
                MainNotification.Dispose();
            }

            if (RecordingNotification != null)
            {
                RecordingNotification.Visible = false;
                RecordingNotification.Dispose();
            }

          
            foreach (HotkeyId id in Enum.GetValues(typeof(HotkeyId)))
                UnregisterHotKey(this.Handle, (int)id);

            base.OnFormClosed(e);
        }

        // ====================  Tray Icon  ====================


        //========  For Main App  ==========

        private NotifyIcon MainNotification;
        void LoadMainTrayIcon()
        {
            MainNotification = new NotifyIcon();
            string iconPath = Path.Combine(Application.StartupPath, "Data", "Icon Tray.ico");
            MainNotification.Icon = new Icon(iconPath);
            MainNotification.Text = "Screenshot X";
            MainNotification.Visible = true;


        }





        //========  For Record  ==========
        private NotifyIcon RecordingNotification;
        private ToolStripMenuItem toggleRecordingWindowItem;
        public event Action StopRecordingRequested;
        public event Action ToggleRecordingWindowRequested;



        void LoadRecordingTrayIcon()
        {
            RecordingNotification = new NotifyIcon();
            string iconPath = Path.Combine(Application.StartupPath, "Data", "RecordTray", "Record.ico");
            RecordingNotification.Icon = new Icon(iconPath);
            RecordingNotification.Text = "Screenshot X - Recording";
            RecordingNotification.Visible = false;

            ContextMenuStrip recMenu = new ContextMenuStrip();
            recMenu.Renderer = new RoundedMenuRenderer();
            recMenu.BackColor = ColorTranslator.FromHtml("#151515");
            recMenu.ForeColor = Color.White;
            recMenu.Font = new Font("Segoe UI", 9F);
            recMenu.ShowImageMargin = false;
            recMenu.Padding = new Padding(6);

            recMenu.Items.Add("Stop Recording", null, (s, e) => StopRecordingRequested?.Invoke());

            toggleRecordingWindowItem = new ToolStripMenuItem("Show Recording Window");
            toggleRecordingWindowItem.Click += (s, e) => ToggleRecordingWindowRequested?.Invoke();
            recMenu.Items.Add(toggleRecordingWindowItem);

            recMenu.Opening += (s, e) => SetRoundedRegion(recMenu, 8);

            RecordingNotification.ContextMenuStrip = recMenu;
        }


        public void UpdateToggleRecordingWindowLabel(bool isCurrentlyVisible)
        {
            toggleRecordingWindowItem.Text = isCurrentlyVisible ? "Hide Recording Window" : "Show Recording Window";
        }

        public void SwitchToRecordingTray()
        {
            MainNotification.Visible = false;
            RecordingNotification.Visible = true;
        }

        public void SwitchToMainTray()
        {
            RecordingNotification.Visible = false;
            MainNotification.Visible = true;
        }

        public void ShowTrayBalloon(string title, string text, ToolTipIcon icon, int timeout = 1500)
        {
            var active = RecordingNotification.Visible ? RecordingNotification : MainNotification;
            active.ShowBalloonTip(timeout, title, text, icon);
        }


        
        // ====================  Too Tip====================

        private Guna2HtmlToolTip ToolTipApp;
        void LoadToolTip()
        {
            ToolTipApp = new Guna2HtmlToolTip();

            ToolTipApp.BackColor = ColorTranslator.FromHtml("#151515");
            ToolTipApp.ForeColor = Color.White;


            ToolTipApp.SetToolTip(pbMinimize, "Hide\\Show App (Alt + L)");
            ToolTipApp.SetToolTip(pbOCR, "OCR (Alt+O) - [Beta]");
            ToolTipApp.SetToolTip(pbColorPicker, "Color Picker (Alt+C)");
            ToolTipApp.SetToolTip(pbDrawing, "Drawing (Soon..)");



            LoadScreenshotToolTip();


            ToolTipApp.SetToolTip(pbTakeScreenVideo, "Screenshot Video Tab (Ctrl+Alt+S) - [Beta]");

            ToolTipApp.SetToolTip(pbClose, "Close And Quit App (Alt + Q)");


            ToolTipApp.SetToolTip(pbMoveButton, "Move");

        
        }

        private void LoadScreenshotToolTip()
        {
            ToolTipApp.SetToolTip(pbTakeScreenshot, "Take Screenshot (Alt + S), Current Mode: (" + CurrentMode.ToString() + ")");

            ToolTipApp.SetToolTip(pbChangeModeOptions, "ChangeMode (Alt + M), Current Mode: (" + CurrentMode.ToString() + ")");
        }

        private void frmMainApp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && pnlScreenshotModeTab.Visible)
            {
                pnlScreenshotModeTab.Visible = false;
            }
        }

        // ==================== ContextectMenue  ====================

        void LoadContextectMenueForIconTray()
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Renderer = new RoundedMenuRenderer();
            menu.BackColor = ColorTranslator.FromHtml("#151515");
            menu.ForeColor = Color.White;
            menu.Font = new Font("Segoe UI", 9F);
            menu.ShowImageMargin = false;
            menu.Padding = new Padding(6);

            menu.Items.Add("Open", null, (s, e) => ShowApp());
            menu.Items.Add("About LQNS-X\\Find Update", null, (s, e) => System.Diagnostics.Process.Start("https://github.com/Naseem-X"));
            menu.Items.Add("Exit", null, (s, e) => { MainNotification.Visible = false; Application.Exit(); });

            menu.Opening += (s, e) =>
            {
                SetRoundedRegion(menu, 8);
            };

            MainNotification.ContextMenuStrip = menu;
        }

        private void SetRoundedRegion(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, control.Width, control.Height);
            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }

        public class RoundedMenuRenderer : ToolStripProfessionalRenderer
        {
            public RoundedMenuRenderer() : base(new RoundedColorTable()) { }

            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                Rectangle rect = new Rectangle(Point.Empty, e.Item.Size);

                if (e.Item.Selected)
                {
                    using (var brush = new SolidBrush(Color.FromArgb(88, 101, 242))) // بنفسجي Discord
                    using (var path = RoundedRect(rect, 4))
                    {
                        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        e.Graphics.FillPath(brush, path);
                    }
                }
            }

            private GraphicsPath RoundedRect(Rectangle rect, int radius)
            {
                var path = new GraphicsPath();
                int d = radius * 2;
                path.AddArc(rect.X, rect.Y, d, d, 180, 90);
                path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
                path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
                path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
                path.CloseFigure();
                return path;
            }
        }

        public class RoundedColorTable : ProfessionalColorTable
        {
            public override Color MenuItemSelected => Color.FromArgb(88, 101, 242);
            public override Color MenuBorder => Color.FromArgb(20, 20, 22);
            public override Color MenuItemBorder => Color.Transparent;
            public override Color ToolStripDropDownBackground => Color.FromArgb(30, 30, 33);
            public override Color ImageMarginGradientBegin => Color.FromArgb(30, 30, 33);
            public override Color ImageMarginGradientMiddle => Color.FromArgb(30, 30, 33);
            public override Color ImageMarginGradientEnd => Color.FromArgb(30, 30, 33);
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

        

        //====================Save Screenshot in ur pc====================

        private void SaveScreenshotToDisk(Bitmap bitmap)
        {
            try
            {
               
                string picturesFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "Screenshot-X");

              
                if (!Directory.Exists(picturesFolder))
                {
                    Directory.CreateDirectory(picturesFolder);
                }

            
                string fileName = $"Screenshot_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.png";
                string fullPath = Path.Combine(picturesFolder, fileName);

             
                bitmap.Save(fullPath, System.Drawing.Imaging.ImageFormat.Png);
            }
            catch (Exception ex)
            {
               
                MainNotification.ShowBalloonTip(2000, "Screenshot X - Save Error", ex.Message, ToolTipIcon.Warning);
            }
        }

        // ==================== Full Screenshot ====================
        void FullScreenshotProcess()
        {
            this.Hide();
            this.ShowInTaskbar = false;
            Thread.Sleep(200);

            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            Bitmap screenshot = new Bitmap(bounds.Width, bounds.Height);

            using (Graphics g = Graphics.FromImage(screenshot))
            {
                g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
            }

            Clipboard.SetImage(screenshot);  
            SaveScreenshotToDisk(screenshot);  

            MainNotification.ShowBalloonTip(1500, "Screenshot X", "Screenshot saved to Pictures and clipboard!", ToolTipIcon.Info);
            this.Show();

            pnlScreenshotModeTab.Visible = false;
        }
        private void pbFullScreenshot_Click(object sender, EventArgs e)
        {
            FullScreenshotProcess();
        }

        // ==================== Custom Region Screenshot ====================
        void RegionScreenshotProcess()
        {
            this.Hide();
            this.ShowInTaskbar = false;
            Thread.Sleep(500);

            using (SnippingForm snip = new SnippingForm())
            {
                snip.ShowDialog();

                if (snip.CapturedImage != null)
                {
                    Clipboard.SetImage(snip.CapturedImage);  
                    SaveScreenshotToDisk(snip.CapturedImage);  

                    MainNotification.ShowBalloonTip(1500, "Screenshot X", "Region screenshot saved to Pictures and clipboard!", ToolTipIcon.Info);
                }
            }

            this.Show();
            pnlScreenshotModeTab.Visible = false;
        }
        private void pbRegionScreenshot_Click(object sender, EventArgs e)
        {
            RegionScreenshotProcess();
        }


        // ==================== Freeform Screenshot ====================
        void FreeformProcess()
        {
            this.Hide();
            this.ShowInTaskbar = false;
            Thread.Sleep(300);

            using (FreeformSnippingForm freeform = new FreeformSnippingForm())
            {
                freeform.ShowDialog();

                if (freeform.CapturedImage != null)
                {
                    Clipboard.SetImage(freeform.CapturedImage);  
                    SaveScreenshotToDisk(freeform.CapturedImage);  

                    MainNotification.ShowBalloonTip(1500, "Screenshot X", "Freeform screenshot saved to Pictures and clipboard!", ToolTipIcon.Info);
                }
            }

            this.Show();
            pnlScreenshotModeTab.Visible = false;
        }
        private void pbFreeform_Click(object sender, EventArgs e)
        {
            FreeformProcess();
        }

        // ==================== Close Button ====================
        private void pbMinimize_Click(object sender, EventArgs e)
        {
            MainNotification.Visible = true;
            HideAppAnimated();
        }


        // ==================== Rectangle Options Toggle ====================

        private bool _isInVideoTab = false;

      

        // ==================== Mode Options Toggle ====================
        enum enScreenshotMode { Window,FullScreen ,Freeform };
        enScreenshotMode CurrentMode = enScreenshotMode.Window;

        private void cmbScreenshotMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbScreenshotMode.SelectedIndex)
            {
                case 0:
                    CurrentMode = enScreenshotMode.Window;
                    break;
                case 1:
                    CurrentMode = enScreenshotMode.FullScreen;
                    break;
                case 2:
                    CurrentMode = enScreenshotMode.Freeform;
                    break;
            }
            LoadScreenshotToolTip();
        }
        private void LoadScreenshotModeOptions()

        {

            cmbScreenshotMode.Items.Clear();


            cmbScreenshotMode.Items.Add("Window");

            cmbScreenshotMode.Items.Add("Full Screen");

            cmbScreenshotMode.Items.Add("Freeform");

            cmbScreenshotMode.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbScreenshotMode.SelectedIndex = 0;


        }

        private void LoadScreenVideoTab()
        {
            _isInVideoTab = true;
            HideAppAnimated();

            _recordForm = new frmScreenVideoTab(this);
            _recordForm.FormClosed += (s, args) =>
            {
                _recordForm.Dispose();  
                _recordForm = null;
                _isInVideoTab = false;
                ShowApp();
            };
            _recordForm.Show();
        }
        private void pbScreenVideo_Click(object sender, EventArgs e)
        {
            LoadScreenVideoTab();
        }
        private void pbScreenshotMode_Click(object sender, EventArgs e)
        {
           switch(CurrentMode)
            {
                case enScreenshotMode.Window:
                    {
                       RegionScreenshotProcess(); 
                    }
                    break;
                case enScreenshotMode.Freeform:
                    {
                        FreeformProcess();
                    }
                    break;
                case enScreenshotMode.FullScreen:
                    {
                        FullScreenshotProcess();
                    }
                    break;
            }
        }

        // ====================  OCR  ====================

        public static class OcrHelper
        {
            public static string ExtractText(Bitmap bitmap)
            {
                string tessdataPath = Path.Combine(Application.StartupPath, "tessdata");

               
                if (Directory.Exists(tessdataPath))
                {
                    string[] deployFiles = Directory.GetFiles(tessdataPath, "*.deploy");
                    foreach (string deployFile in deployFiles)
                    {
                        
                        string originalFile = deployFile.Substring(0, deployFile.Length - 7);
                        if (!File.Exists(originalFile))
                        {
                            File.Copy(deployFile, originalFile, true);
                        }
                    }
                }
                // --------------------------------------------------------

                using (var engine = new TesseractEngine(tessdataPath, "eng+ara", EngineMode.Default))
                using (var img = PixConverter.ToPix(bitmap))
                using (var page = engine.Process(img, PageSegMode.SingleBlock))
                {
                    return page.GetText();
                }
            }
        }

        private void pbExtractText_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ShowInTaskbar = false;
            Thread.Sleep(500);

            using (SnippingForm snip = new SnippingForm())
            {
                snip.ShowDialog();

                if (snip.CapturedImage != null)
                {
                    try
                    {
                        string extractedText = OcrHelper.ExtractText(snip.CapturedImage);

                        if (string.IsNullOrWhiteSpace(extractedText))
                        {
                            MainNotification.ShowBalloonTip(1500, "Screenshot X", "No Text Here Try Again!", ToolTipIcon.Info);
                        }
                        else
                        {
                            Clipboard.SetText(extractedText.Trim());
                            MainNotification.ShowBalloonTip(1500, "Screenshot X", "Text copied to clipboard!", ToolTipIcon.Info);
                        }
                    }
                    catch (Exception ex)
                    {
                       
                        string errorMsg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                        MainNotification.ShowBalloonTip(3000, "Screenshot X - OCR Error", errorMsg, ToolTipIcon.Error);
                    }
                }
            }

            this.Show();
            pnlScreenshotModeTab.Visible = false;
        }

        // ====================  Color Picker  ====================

        [DllImport("gdi32.dll")]
        private static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(out POINT lpPoint);

        private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        [StructLayout(LayoutKind.Sequential)] private struct POINT { public int X; public int Y; }

        private const int WH_MOUSE_LL = 14;
        private const int WM_MOUSEMOVE = 0x0200;
        private const int WM_LBUTTONDOWN = 0x0201;

        private IntPtr _mouseHookId = IntPtr.Zero;
        private LowLevelMouseProc _mouseProc;

        private Form _colorPreviewForm;
        private Panel _colorSwatch;
        private Label _colorHexLabel;

        private IntPtr _keyboardHookId = IntPtr.Zero;
        private LowLevelKeyboardProc _keyboardProc;
        private void InitColorPreviewForm()
        {
            _colorPreviewForm = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.Manual,
                Size = new Size(110, 40),
                TopMost = true,
                ShowInTaskbar = false
            };

            _colorSwatch = new Panel
            {
                Location = new Point(5, 5),
                Size = new Size(30, 30),
                BorderStyle = BorderStyle.FixedSingle
            };

            _colorHexLabel = new Label
            {
                Location = new Point(40, 12),
                AutoSize = true,
                Font = new Font("Consolas", 9, FontStyle.Bold)
            };

            _colorPreviewForm.Controls.Add(_colorSwatch);
            _colorPreviewForm.Controls.Add(_colorHexLabel);
        }

        private Color GetColorAt(Point location)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, location.X, location.Y);
            ReleaseDC(IntPtr.Zero, hdc);

            int r = (int)(pixel & 0x000000FF);
            int g = (int)(pixel & 0x0000FF00) >> 8;
            int b = (int)(pixel & 0x00FF0000) >> 16;

            return Color.FromArgb(r, g, b);
        }

        private void StopColorPicking()
        {
            _colorPreviewForm.Hide();

            if (_mouseHookId != IntPtr.Zero)
            {
                UnhookWindowsHookEx(_mouseHookId);
                _mouseHookId = IntPtr.Zero;
            }
            if (_keyboardHookId != IntPtr.Zero)
            {
                UnhookWindowsHookEx(_keyboardHookId);
                _keyboardHookId = IntPtr.Zero;
            }
        }

        private IntPtr KeyboardHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                if (vkCode == VK_ESCAPE)
                {
                    this.Invoke((Action)(() => StopColorPicking()));
                    return (IntPtr)1;
                }
            }
            return CallNextHookEx(_keyboardHookId, nCode, wParam, lParam);
        }

        private void pbColorPicker_Click(object sender, EventArgs e)
        {
            if (_colorPreviewForm == null)
                InitColorPreviewForm();

            _colorPreviewForm.Show();
            _mouseProc = MouseHookCallback;
            _mouseHookId = SetWindowsHookEx(WH_MOUSE_LL, _mouseProc, IntPtr.Zero, 0);

            _keyboardProc = KeyboardHookCallback;
            _keyboardHookId = SetWindowsHookEx(WH_KEYBOARD_LL, _keyboardProc, IntPtr.Zero, 0);
        }

        private IntPtr MouseHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                GetCursorPos(out POINT pt);

                if (wParam == (IntPtr)WM_MOUSEMOVE)
                {
                    this.Invoke((Action)(() =>
                    {
                        Color hover = GetColorAt(new Point(pt.X, pt.Y));
                        _colorSwatch.BackColor = hover;
                        _colorHexLabel.Text = $"#{hover.R:X2}{hover.G:X2}{hover.B:X2}";
                        _colorPreviewForm.Location = new Point(pt.X + 20, pt.Y + 20);
                    }));
                }
                else if (wParam == (IntPtr)WM_LBUTTONDOWN)
                {
                    this.Invoke((Action)(() =>
                    {
                        Color picked = GetColorAt(new Point(pt.X, pt.Y));
                        string hex = $"#{picked.R:X2}{picked.G:X2}{picked.B:X2}";
                        Clipboard.SetText(hex);
                        MainNotification.ShowBalloonTip(1500, "Screenshot X", $"Hexcolor copied to clipboard  \nColor= {hex}", ToolTipIcon.Info);
                        StopColorPicking();
                    }));
                    return (IntPtr)1;
                }
            }

            return CallNextHookEx(_mouseHookId, nCode, wParam, lParam);
        }

        private void pbDrawing_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //using (DrawingForm draw = new DrawingForm())
            //{
            //    draw.ShowDialog();
            //}
            //this.Show();
        }

        // ====================  App  Animation  ====================
        private System.Windows.Forms.Timer _animTimer;
        private int _animStep;
        private const int AnimDuration = 300; 
        private int _targetY;
        private int _startY;
        private void ShowApp()
        {
            this.Opacity = 0;
            this.WindowState = FormWindowState.Normal;
            this.Show();
            this.BringToFront();
            SetForegroundWindow(this.Handle);

            _targetY = _fixedLocation.Y;
            _startY = _targetY -80;
            this.Location = new Point(_fixedLocation.X, _startY);

            _animStep = 0;
            _animTimer?.Stop();
            _animTimer = new System.Windows.Forms.Timer { Interval = 15 };
            _animTimer.Tick += AnimTimer_Tick;
            _animTimer.Start();
          
        }

        private void HideAppAnimated()
        {
            _animStep = 0;
            _targetY = this.Location.Y + 40; 
            _startY = this.Location.Y;

            _animTimer?.Stop();
            _animTimer = new System.Windows.Forms.Timer { Interval = 10 };
            _animTimer.Tick += HideTimer_Tick;
            _animTimer.Start();
        }

        private void HideTimer_Tick(object sender, EventArgs e)
        {
            _animStep += 10;
            double t = Math.Min(1.0, (double)_animStep / 150);

            double eased = t * t; 

            int newY = (int)(_startY + (_targetY - _startY) * eased);
            this.Location = new Point(this.Location.X, newY);
            this.Opacity = 1 - eased;

            if (t >= 1.0)
            {
                _animTimer.Stop();
                this.Visible = false;
                this.Location = new Point(this.Location.X, _startY); 
                this.Opacity = 1;
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbChangeMode_Click(object sender, EventArgs e)
        {
            cmbScreenshotMode.Visible = !cmbScreenshotMode.Visible;
        }

        private void frmMainApp_Deactivate(object sender, EventArgs e)
        {
            cmbScreenshotMode.Visible=false;
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
        private void pbMoveButton_Click(object sender, EventArgs e)
        {

        }

        private void pbMoveButton_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm(sender, e);
        }


        private void frmMainApp_LocationChanged(object sender, EventArgs e)
        {
            
            if (_animTimer == null || !_animTimer.Enabled)
            {
                _fixedLocation = this.Location;
            }
        }
    }

}