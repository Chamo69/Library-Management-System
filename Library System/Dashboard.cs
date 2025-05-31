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
    public partial class Dashboard: Form
    {
        private Form currentChildFrom;
        private Panel lastChangedPanel; 
        private Button lastClickedButton; 
        private Color previousPanelColor; 
        private Color previousButtonColor;
        public Dashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width < 60)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width > 219)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnUserRegister_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUserRegister());
            ChangePanelAndButtonColor(pnlUser, btnUserRegister, Color.LightGreen, Color.FromArgb(153, 180, 209));
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildFrom != null)
            {
                currentChildFrom.Close();
            }

            ChangePanelAndButtonColor(pnlHome, btnHome, Color.LightGreen, Color.FromArgb(153, 180, 209));
        }

        private void btnBookRegister_Click(object sender, EventArgs e)
        {
            ChangePanelAndButtonColor(pnlBook, btnBookRegister, Color.LightGreen, Color.FromArgb(153, 180, 209));
            openChildForm(new frmBookRegister());
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            ChangePanelAndButtonColor(pnlLoan, btnLoan, Color.LightGreen, Color.FromArgb(153, 180, 209));
            openChildForm(new frmLoanManage());
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ChangePanelAndButtonColor(pnlReturn, btnReturn, Color.LightGreen, Color.FromArgb(153, 180, 209));
            openChildForm(new frmReturn());
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            ChangePanelAndButtonColor(pnlReserver, btnReservation, Color.LightGreen, Color.FromArgb(153, 180, 209));
            openChildForm(new frmReservation());
        }

        private void btnInquiries_Click(object sender, EventArgs e)
        {
            ChangePanelAndButtonColor(pnlInqury, btnInquiries, Color.LightGreen, Color.FromArgb(153, 180, 209));
            openChildForm(new frmInquiries());
        }

        //Drag Form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlDrag_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Open Child Form
        private void openChildForm(Form childForm)
        {
            if (currentChildFrom != null)
            {
                currentChildFrom.Close();
            }
            currentChildFrom = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlPages.Controls.Add(childForm);
            pnlPages.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //button color change
        private void ChangePanelAndButtonColor(Panel pnl, Button btn, Color panelColor, Color buttonColor)
        {
            
            if (lastChangedPanel != null)
            {
                lastChangedPanel.BackColor = previousPanelColor;
            }

            
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = previousButtonColor;
            }

            
            previousPanelColor = pnl.BackColor;
            previousButtonColor = btn.BackColor;

            
            pnl.BackColor = panelColor;
            btn.BackColor = buttonColor;

           
            lastChangedPanel = pnl;
            lastClickedButton = btn;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timerFade.Start();
        }

        private void timerFade_Tick(object sender, EventArgs e)
        {
            Opacity += .2;
        }
    }
}
