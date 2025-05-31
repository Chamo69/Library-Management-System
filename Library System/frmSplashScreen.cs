using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Initialize and start the timer
            timer1.Interval = 20; // Set the interval to 100 milliseconds (adjust as needed)
            timer1.Tick += timer1_Tick; // Subscribe to the Tick event
            timer1.Start(); // Start the timer

        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
        );

        private void timer1_Tick(object sender, EventArgs e)
        {
            aloneProgressBar1.Value += 1;

            if (aloneProgressBar1.Value >= 100)
            {
                timer1.Stop();
                frmLogin frm = new frmLogin();
                frm.Show();
                this.Hide();
            }
        }

        private void timerFade_Tick(object sender, EventArgs e)
        {
            Opacity += .2;
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            timerFade.Start();
        }
    }
}
