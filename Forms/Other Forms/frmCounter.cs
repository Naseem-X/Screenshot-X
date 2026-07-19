using System;
using System.Drawing;
using System.Windows.Forms;

namespace Screenshot_X.Forms
{
    public partial class frmCounter : Form
    {
        public event Action CountdownFinished;

        public frmCounter()
        {
            InitializeComponent();
        }

       
        private void frmCounter_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
             this.BackColor = Color.FromArgb(0, 0, 0);   
             this.TransparencyKey = Color.FromArgb(0, 0, 0);

            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = true;

          
            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );
         lblCountDownTimer.Text = Countdown.ToString();
            CountDownTimer.Start();
        }
        public int Countdown ;

        private void CountDownTimer_Tick(object sender, EventArgs e)
        {
            Countdown--;
         lblCountDownTimer.Text = Countdown.ToString();


            if (Countdown <= 0)
            {
                CountDownTimer.Stop();
                pnlCountDownTimer.Visible = false;

                CountdownFinished?.Invoke();   
                this.Close();
            }
        }
    }
}