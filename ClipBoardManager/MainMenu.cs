using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipBoardManager
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private IconButton currentBtn;

        private Form currentChildForm;

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        void Home()
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                //Left border button              
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            lblTitleChildForm.Text = "Home";
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.ClipboardForm());
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.ClipboardForm());
        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.ClipboardForm());
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon.");
        }

        private void backupClipboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.ClipboardForm());
        }

        private void contactButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.Contact());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            trayIcon.Dispose();
            Environment.Exit(0);
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {

        }

        private void lblClipboardTxt_Click(object sender, EventArgs e)
        {
            Home();

        }

        private void lblManagerTxt_Click(object sender, EventArgs e)
        {
            Home();
        }

        private void ResizeEvent(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                trayIcon.Visible = true;
            }
        }

        private void TrayIconDoubleClickEvent(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            trayIcon.Visible = false;
        }

        private void btnSendFeedback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.Feedback feedback = new Forms.Feedback();
            feedback.Show();
            this.Hide();
        }
        private void PanelTimer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblHour.Text = "Hour: " + dateTime.ToString("HH:mm");
            lblDate.Text = "Date: " + dateTime.ToString("dd/MM/yyyy");
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            PanelTimer.Enabled = true;
            PanelTimer.Start();
        }

        private void panelIcon_Paint(object sender, PaintEventArgs e)
        {
            Home();
        }
    }
}
