using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Screenshot_X
{
    public partial class SnippingForm : Form
    {
        private Point startPoint;
        private Rectangle selectionRect;
        private bool isSelecting = false;
        public Bitmap CapturedImage { get; private set; }

        public SnippingForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            this.Opacity = 0.4;
            this.BackColor = Color.Black;
            this.Cursor = Cursors.Cross;
            this.DoubleBuffered = true;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                isSelecting = true;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (isSelecting)
            {
                int x = Math.Min(e.X, startPoint.X);
                int y = Math.Min(e.Y, startPoint.Y);
                int w = Math.Abs(e.X - startPoint.X);
                int h = Math.Abs(e.Y - startPoint.Y);
                selectionRect = new Rectangle(x, y, w, h);
                this.Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isSelecting)
            {
                isSelecting = false;
                CaptureSelection();
                this.Close();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (selectionRect.Width > 0 && selectionRect.Height > 0)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(120, Color.White)), selectionRect);
                e.Graphics.DrawRectangle(new Pen(Color.White, 2), selectionRect);
            }
        }

        private void CaptureSelection()
        {
            if (selectionRect.Width <= 0 || selectionRect.Height <= 0) return;

            this.Opacity = 0;
            Thread.Sleep(100);

            Bitmap bmp = new Bitmap(selectionRect.Width, selectionRect.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(selectionRect.Location, Point.Empty, selectionRect.Size);
            }

            CapturedImage = bmp;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}