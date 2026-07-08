using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Screenshot_X
{
    public partial class FreeformSnippingForm : Form
    {
        public Bitmap CapturedImage { get; private set; }

        private Bitmap _screenBitmap;
        private List<Point> _points = new List<Point>();
        private bool _drawing = false;

        public FreeformSnippingForm()
        {
            Rectangle bounds = Screen.PrimaryScreen.Bounds;

            _screenBitmap = new Bitmap(bounds.Width, bounds.Height);
            using (Graphics g = Graphics.FromImage(_screenBitmap))
            {
                g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
            }

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Bounds = bounds;
            this.TopMost = true;
            this.Cursor = Cursors.Cross;
            this.DoubleBuffered = true;
            this.BackgroundImage = _screenBitmap;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.MouseDown += OnMouseDown;
            this.MouseMove += OnMouseMove;
            this.MouseUp += OnMouseUp;
            this.KeyDown += (s, e) => { if (e.KeyCode == Keys.Escape) this.Close(); };
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            _drawing = true;
            _points.Clear();
            _points.Add(e.Location);
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (!_drawing) return;
            _points.Add(e.Location);
            this.Invalidate();
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            _drawing = false;
            if (_points.Count < 3)
            {
                this.Close();
                return;
            }

            CapturedImage = ExtractFreeformArea();
            this.Close();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // تعتيم خارج المنطقة المختارة
            using (var overlayPath = new GraphicsPath())
            {
                overlayPath.AddRectangle(this.ClientRectangle);
                if (_points.Count > 2)
                {
                    using (var selectionPath = new GraphicsPath())
                    {
                        selectionPath.AddPolygon(_points.ToArray());
                        overlayPath.AddPath(selectionPath, false);
                    }
                }

                using (var brush = new SolidBrush(Color.FromArgb(120, 0, 0, 0)))
                {
                    e.Graphics.FillPath(brush, overlayPath);
                }
            }

            // خط حدود المنطقة المرسومة
            if (_points.Count > 1)
            {
                using (var pen = new Pen(Color.DeepSkyBlue, 2))
                {
                    e.Graphics.DrawLines(pen, _points.ToArray());
                }
            }
        }

        private Bitmap ExtractFreeformArea()
        {
            // نحسب المستطيل المحيط بالشكل
            int minX = int.MaxValue, minY = int.MaxValue;
            int maxX = int.MinValue, maxY = int.MinValue;

            foreach (var p in _points)
            {
                if (p.X < minX) minX = p.X;
                if (p.Y < minY) minY = p.Y;
                if (p.X > maxX) maxX = p.X;
                if (p.Y > maxY) maxY = p.Y;
            }

            int width = Math.Max(1, maxX - minX);
            int height = Math.Max(1, maxY - minY);

            Bitmap result = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics g = Graphics.FromImage(result))
            {
                using (var path = new GraphicsPath())
                {
                    Point[] localPoints = _points.ConvertAll(p => new Point(p.X - minX, p.Y - minY)).ToArray();
                    path.AddPolygon(localPoints);

                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.SetClip(path);

                    g.DrawImage(_screenBitmap,
                        new Rectangle(0, 0, width, height),
                        new Rectangle(minX, minY, width, height),
                        GraphicsUnit.Pixel);
                }
            }

            return result;
        }
    }
}