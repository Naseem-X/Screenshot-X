using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Screenshot_X
{
    public partial class DrawingForm : Form
    {
        private Bitmap _canvas;
        private Point _lastPoint;
        private bool _isDrawing = false;
        private Color _penColor = Color.Red;
        private int _penWidth = 3;

        public DrawingForm()
        {
            InitializeComponent();

            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Bounds = bounds;
            this.TopMost = true;
            this.BackColor = Color.Magenta;
            this.TransparencyKey = Color.Magenta;
            this.DoubleBuffered = true;

            _canvas = new Bitmap(bounds.Width, bounds.Height);
            using (Graphics g = Graphics.FromImage(_canvas))
            {
                g.Clear(Color.Transparent);
            }

            this.MouseDown += OnMouseDown;
            this.MouseMove += OnMouseMove;
            this.MouseUp += OnMouseUp;
            this.KeyDown += OnKeyDown;
        }

        private void DrawingForm_Load(object sender, EventArgs e)
        {

        }
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDrawing = true;
                _lastPoint = e.Location;
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (!_isDrawing) return;

            using (Graphics g = Graphics.FromImage(_canvas))
            using (Pen pen = new Pen(_penColor, _penWidth) { StartCap = LineCap.Round, EndCap = LineCap.Round })
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawLine(pen, _lastPoint, e.Location);
            }

            _lastPoint = e.Location;
            this.Invalidate();
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            _isDrawing = false;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.C: // مسح كل شي
                    ClearCanvas();
                    break;

                case Keys.R:
                    _penColor = Color.Red;
                    break;
                case Keys.G:
                    _penColor = Color.Lime;
                    break;
                case Keys.B:
                    _penColor = Color.DeepSkyBlue;
                    break;
                case Keys.Y:
                    _penColor = Color.Yellow;
                    break;

                case Keys.Oemplus: // +
                    _penWidth = Math.Min(_penWidth + 1, 30);
                    break;
                case Keys.OemMinus: // -
                    _penWidth = Math.Max(_penWidth - 1, 1);
                    break;
            }
        }

        private void ClearCanvas()
        {
            using (Graphics g = Graphics.FromImage(_canvas))
            {
                g.Clear(Color.Transparent);
            }
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(_canvas, Point.Empty);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _canvas?.Dispose();
            base.OnFormClosed(e);
        }
    }
}
