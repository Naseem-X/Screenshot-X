using System;
using System.Drawing;
using System.Windows.Forms;
namespace Screenshot_X.Forms
{

    public partial class frmHiddenTab : Form

    {


        private void frmHiddenTab_Load(object sender, EventArgs e)

        {

            FormBorderStyle = FormBorderStyle.None;

            TopMost = true;

            ShowInTaskbar = false;

            BackColor = Color.Black;

            TransparencyKey = Color.Black;

        }



        private void pbHiddenTab_Click(object sender, EventArgs e)

        {

            Close();

        }

    }

}
