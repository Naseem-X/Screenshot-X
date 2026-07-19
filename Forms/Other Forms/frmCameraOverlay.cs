using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Screenshot_X.Forms
{
    public partial class frmCameraOverlay : Form
    {
        private FilterInfoCollection _videoDevices;
        private VideoCaptureDevice _videoSource;

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        public bool IsCircleCamera = false;

        public frmCameraOverlay()
        {
            InitializeComponent();
        }

        private void frmCameraOverlay_Load(object sender, EventArgs e)
        {
          
            this.MouseDown += frmCameraOverlay_MouseDown;
            pbCameraPrev.MouseDown += frmCameraOverlay_MouseDown;
            if (pbCircleCameraPrev != null) pbCircleCameraPrev.MouseDown += frmCameraOverlay_MouseDown;

            LoadTransparentKey();
        }

        void LoadTransparentKey()
        {
          
            this.BackColor = ColorTranslator.FromHtml("#60CDFF");
            this.TransparencyKey = ColorTranslator.FromHtml("#60CDFF");
        }

        private void frmCameraOverlay_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            }
        }

        public void StartCamera()
        {
            if (_videoSource != null && _videoSource.IsRunning) return;

            _videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (_videoDevices.Count == 0)
            {
                MessageBox.Show("No Camera Found !");
                return;
            }

            _videoSource = new VideoCaptureDevice(_videoDevices[0].MonikerString);
            _videoSource.NewFrame += VideoSource_NewFrame;
            _videoSource.Start();
        }

        public void StopCamera()
        {
            if (_videoSource != null && _videoSource.IsRunning)
            {
                _videoSource.NewFrame -= VideoSource_NewFrame;
                _videoSource.SignalToStop();
                _videoSource = null;
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
           
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

            
            if (pbCameraPrev.IsHandleCreated)
            {
                this.Invoke((Action)(() =>
                {
                    if (IsCircleCamera)
                    {
                        pbCameraPrev.Visible = false;
                        pbCircleCameraPrev.Visible = true;

                        var old = pbCircleCameraPrev.Image;
                        pbCircleCameraPrev.Image = frame;
                        old?.Dispose(); 
                    }
                    else
                    {
                        pbCameraPrev.Visible = true;
                        pbCircleCameraPrev.Visible = false;

                        var old = pbCameraPrev.Image;
                        pbCameraPrev.Image = frame;
                        old?.Dispose();
                    }
                }));
            }
            else
            {
                frame.Dispose();
            }
        }

        //Later

        //private Bitmap CropToCircle(Bitmap srcImage)
        //{
           
        //    int targetSize = Math.Min(srcImage.Width, srcImage.Height);

          
        //    int x = (srcImage.Width - targetSize) / 2;
        //    int y = (srcImage.Height - targetSize) / 2;
 
        //    Bitmap dstImage = new Bitmap(targetSize, targetSize);

        //    using (Graphics g = Graphics.FromImage(dstImage))
        //    {
          
        //        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        //        g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                
        //        g.Clear(Color.Transparent);

                
        //        using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
        //        {
        //            path.AddEllipse(0, 0, targetSize, targetSize);
        //            g.SetClip(path); 

                     
        //            g.DrawImage(srcImage, new Rectangle(0, 0, targetSize, targetSize), new Rectangle(x, y, targetSize, targetSize), GraphicsUnit.Pixel);
        //        }
        //    }

        //    return dstImage;
        //}
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            StopCamera();
            base.OnFormClosing(e);
        }
    }
}