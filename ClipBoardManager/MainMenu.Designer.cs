namespace ClipBoardManager
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.elipseForm = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelVersion = new System.Windows.Forms.Panel();
            this.btnSendFeedback = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelIcon = new System.Windows.Forms.Panel();
            this.lblManagerTxt = new System.Windows.Forms.Label();
            this.lblClipboardTxt = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaGradient2Panel5 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gunaGradient2Panel4 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gunaGradient2Panel3 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gunaGradient2Panel2 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.lblBackupDate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.PanelTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.aboutButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.contactButton = new FontAwesome.Sharp.IconButton();
            this.backupClipboard = new FontAwesome.Sharp.IconButton();
            this.updateButton = new FontAwesome.Sharp.IconButton();
            this.categoriesButton = new FontAwesome.Sharp.IconButton();
            this.settingsButton = new FontAwesome.Sharp.IconButton();
            this.dashboardButton = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.panelVersion.SuspendLayout();
            this.panelIcon.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.gunaGradient2Panel5.SuspendLayout();
            this.gunaGradient2Panel4.SuspendLayout();
            this.gunaGradient2Panel3.SuspendLayout();
            this.gunaGradient2Panel2.SuspendLayout();
            this.gunaGradient2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseForm
            // 
            this.elipseForm.Radius = 15;
            this.elipseForm.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.contactButton);
            this.panel2.Controls.Add(this.panelVersion);
            this.panel2.Controls.Add(this.backupClipboard);
            this.panel2.Controls.Add(this.updateButton);
            this.panel2.Controls.Add(this.categoriesButton);
            this.panel2.Controls.Add(this.settingsButton);
            this.panel2.Controls.Add(this.dashboardButton);
            this.panel2.Controls.Add(this.panelIcon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 519);
            this.panel2.TabIndex = 1;
            // 
            // panelVersion
            // 
            this.panelVersion.Controls.Add(this.btnSendFeedback);
            this.panelVersion.Controls.Add(this.label5);
            this.panelVersion.Controls.Add(this.label4);
            this.panelVersion.Controls.Add(this.label3);
            this.panelVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelVersion.Location = new System.Drawing.Point(0, 470);
            this.panelVersion.Name = "panelVersion";
            this.panelVersion.Size = new System.Drawing.Size(162, 49);
            this.panelVersion.TabIndex = 6;
            // 
            // btnSendFeedback
            // 
            this.btnSendFeedback.AutoSize = true;
            this.btnSendFeedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendFeedback.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSendFeedback.LinkColor = System.Drawing.Color.Transparent;
            this.btnSendFeedback.Location = new System.Drawing.Point(33, 26);
            this.btnSendFeedback.Name = "btnSendFeedback";
            this.btnSendFeedback.Size = new System.Drawing.Size(93, 16);
            this.btnSendFeedback.TabIndex = 3;
            this.btnSendFeedback.TabStop = true;
            this.btnSendFeedback.Text = "Send Feedback";
            this.btnSendFeedback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnSendFeedback_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(108, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(122, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "v1.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "All Rights Are Free";
            // 
            // panelIcon
            // 
            this.panelIcon.Controls.Add(this.lblManagerTxt);
            this.panelIcon.Controls.Add(this.lblClipboardTxt);
            this.panelIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIcon.Location = new System.Drawing.Point(0, 0);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(162, 74);
            this.panelIcon.TabIndex = 0;
            this.panelIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIcon_Paint);
            // 
            // lblManagerTxt
            // 
            this.lblManagerTxt.AutoSize = true;
            this.lblManagerTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblManagerTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblManagerTxt.Location = new System.Drawing.Point(57, 33);
            this.lblManagerTxt.Name = "lblManagerTxt";
            this.lblManagerTxt.Size = new System.Drawing.Size(95, 23);
            this.lblManagerTxt.TabIndex = 1;
            this.lblManagerTxt.Text = "Manager";
            this.lblManagerTxt.Click += new System.EventHandler(this.lblManagerTxt_Click);
            // 
            // lblClipboardTxt
            // 
            this.lblClipboardTxt.AutoSize = true;
            this.lblClipboardTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClipboardTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblClipboardTxt.Location = new System.Drawing.Point(12, 13);
            this.lblClipboardTxt.Name = "lblClipboardTxt";
            this.lblClipboardTxt.Size = new System.Drawing.Size(105, 23);
            this.lblClipboardTxt.TabIndex = 0;
            this.lblClipboardTxt.Text = "Clipboard";
            this.lblClipboardTxt.Click += new System.EventHandler(this.lblClipboardTxt_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblTitleChildForm);
            this.panelHeader.Controls.Add(this.aboutButton);
            this.panelHeader.Controls.Add(this.exitButton);
            this.panelHeader.Controls.Add(this.minimizeButton);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(162, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(771, 33);
            this.panelHeader.TabIndex = 2;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(9, 9);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(67, 15);
            this.lblTitleChildForm.TabIndex = 24;
            this.lblTitleChildForm.Text = "FormName";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.label9);
            this.panelDesktop.Controls.Add(this.gunaSeparator1);
            this.panelDesktop.Controls.Add(this.gunaGradient2Panel5);
            this.panelDesktop.Controls.Add(this.gunaGradient2Panel4);
            this.panelDesktop.Controls.Add(this.gunaGradient2Panel3);
            this.panelDesktop.Controls.Add(this.gunaGradient2Panel2);
            this.panelDesktop.Controls.Add(this.gunaGradient2Panel1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(162, 33);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(771, 486);
            this.panelDesktop.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(72, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "My Panel";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(76, 64);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(125, 13);
            this.gunaSeparator1.TabIndex = 6;
            // 
            // gunaGradient2Panel5
            // 
            this.gunaGradient2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel5.Controls.Add(this.label15);
            this.gunaGradient2Panel5.Controls.Add(this.label11);
            this.gunaGradient2Panel5.Controls.Add(this.pictureBox5);
            this.gunaGradient2Panel5.GradientColor1 = System.Drawing.Color.DarkRed;
            this.gunaGradient2Panel5.GradientColor2 = System.Drawing.Color.Red;
            this.gunaGradient2Panel5.Location = new System.Drawing.Point(536, 239);
            this.gunaGradient2Panel5.Name = "gunaGradient2Panel5";
            this.gunaGradient2Panel5.Radius = 15;
            this.gunaGradient2Panel5.Size = new System.Drawing.Size(144, 117);
            this.gunaGradient2Panel5.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(16, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 22);
            this.label15.TabIndex = 12;
            this.label15.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(17, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Data";
            // 
            // gunaGradient2Panel4
            // 
            this.gunaGradient2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel4.Controls.Add(this.label13);
            this.gunaGradient2Panel4.Controls.Add(this.label8);
            this.gunaGradient2Panel4.Controls.Add(this.pictureBox4);
            this.gunaGradient2Panel4.GradientColor1 = System.Drawing.Color.Indigo;
            this.gunaGradient2Panel4.GradientColor2 = System.Drawing.Color.Purple;
            this.gunaGradient2Panel4.Location = new System.Drawing.Point(303, 239);
            this.gunaGradient2Panel4.Name = "gunaGradient2Panel4";
            this.gunaGradient2Panel4.Radius = 15;
            this.gunaGradient2Panel4.Size = new System.Drawing.Size(188, 117);
            this.gunaGradient2Panel4.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(19, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 22);
            this.label13.TabIndex = 10;
            this.label13.Text = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(20, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Feedbacks";
            // 
            // gunaGradient2Panel3
            // 
            this.gunaGradient2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel3.Controls.Add(this.label12);
            this.gunaGradient2Panel3.Controls.Add(this.label7);
            this.gunaGradient2Panel3.Controls.Add(this.pictureBox3);
            this.gunaGradient2Panel3.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaGradient2Panel3.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaGradient2Panel3.Location = new System.Drawing.Point(73, 239);
            this.gunaGradient2Panel3.Name = "gunaGradient2Panel3";
            this.gunaGradient2Panel3.Radius = 15;
            this.gunaGradient2Panel3.Size = new System.Drawing.Size(188, 117);
            this.gunaGradient2Panel3.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(19, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 22);
            this.label12.TabIndex = 9;
            this.label12.Text = "6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(16, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Categories";
            // 
            // gunaGradient2Panel2
            // 
            this.gunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel2.Controls.Add(this.label14);
            this.gunaGradient2Panel2.Controls.Add(this.label10);
            this.gunaGradient2Panel2.Controls.Add(this.pictureBox6);
            this.gunaGradient2Panel2.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaGradient2Panel2.GradientColor2 = System.Drawing.Color.Goldenrod;
            this.gunaGradient2Panel2.Location = new System.Drawing.Point(536, 97);
            this.gunaGradient2Panel2.Name = "gunaGradient2Panel2";
            this.gunaGradient2Panel2.Radius = 15;
            this.gunaGradient2Panel2.Size = new System.Drawing.Size(144, 117);
            this.gunaGradient2Panel2.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(16, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 22);
            this.label14.TabIndex = 11;
            this.label14.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(17, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Backup";
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.lblBackupDate);
            this.gunaGradient2Panel1.Controls.Add(this.pictureBox2);
            this.gunaGradient2Panel1.Controls.Add(this.lblDate);
            this.gunaGradient2Panel1.Controls.Add(this.lblHour);
            this.gunaGradient2Panel1.Controls.Add(this.label1);
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.Blue;
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(73, 97);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Radius = 15;
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(418, 117);
            this.gunaGradient2Panel1.TabIndex = 1;
            // 
            // lblBackupDate
            // 
            this.lblBackupDate.AutoSize = true;
            this.lblBackupDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBackupDate.Location = new System.Drawing.Point(18, 82);
            this.lblBackupDate.Name = "lblBackupDate";
            this.lblBackupDate.Size = new System.Drawing.Size(200, 16);
            this.lblBackupDate.TabIndex = 8;
            this.lblBackupDate.Text = "Last Backup Date : 30/05/2022";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(18, 61);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(113, 16);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date: 30/05/2022";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHour.Location = new System.Drawing.Point(18, 40);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(77, 16);
            this.lblHour.TabIndex = 5;
            this.lblHour.Text = "Hour: 00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome, User";
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Services is Running!";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIconDoubleClickEvent);
            // 
            // PanelTimer
            // 
            this.PanelTimer.Enabled = true;
            this.PanelTimer.Interval = 1;
            this.PanelTimer.Tick += new System.EventHandler(this.PanelTimer_Tick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::ClipBoardManager.Properties.Resources.data;
            this.pictureBox5.Location = new System.Drawing.Point(108, 82);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(29, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::ClipBoardManager.Properties.Resources.feedback1;
            this.pictureBox4.Location = new System.Drawing.Point(152, 81);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::ClipBoardManager.Properties.Resources.category;
            this.pictureBox3.Location = new System.Drawing.Point(151, 80);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::ClipBoardManager.Properties.Resources.backup;
            this.pictureBox6.Location = new System.Drawing.Point(105, 79);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ClipBoardManager.Properties.Resources.dayico;
            this.pictureBox2.Location = new System.Drawing.Point(376, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // aboutButton
            // 
            this.aboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutButton.Image = global::ClipBoardManager.Properties.Resources.minimized;
            this.aboutButton.Location = new System.Drawing.Point(713, 10);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(15, 15);
            this.aboutButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aboutButton.TabIndex = 23;
            this.aboutButton.TabStop = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Image = global::ClipBoardManager.Properties.Resources.close;
            this.exitButton.Location = new System.Drawing.Point(743, 10);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(15, 15);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 21;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Image = global::ClipBoardManager.Properties.Resources.about;
            this.minimizeButton.Location = new System.Drawing.Point(728, 10);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(15, 15);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeButton.TabIndex = 22;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // contactButton
            // 
            this.contactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contactButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.contactButton.FlatAppearance.BorderSize = 0;
            this.contactButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.contactButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.contactButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.contactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactButton.ForeColor = System.Drawing.Color.Transparent;
            this.contactButton.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.contactButton.IconColor = System.Drawing.Color.White;
            this.contactButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.contactButton.IconSize = 36;
            this.contactButton.Location = new System.Drawing.Point(0, 399);
            this.contactButton.Name = "contactButton";
            this.contactButton.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.contactButton.Size = new System.Drawing.Size(162, 65);
            this.contactButton.TabIndex = 7;
            this.contactButton.UseVisualStyleBackColor = true;
            this.contactButton.Click += new System.EventHandler(this.contactButton_Click);
            // 
            // backupClipboard
            // 
            this.backupClipboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backupClipboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.backupClipboard.FlatAppearance.BorderSize = 0;
            this.backupClipboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.backupClipboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.backupClipboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.backupClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupClipboard.ForeColor = System.Drawing.Color.Transparent;
            this.backupClipboard.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.backupClipboard.IconColor = System.Drawing.Color.White;
            this.backupClipboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.backupClipboard.IconSize = 36;
            this.backupClipboard.Location = new System.Drawing.Point(0, 334);
            this.backupClipboard.Name = "backupClipboard";
            this.backupClipboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.backupClipboard.Size = new System.Drawing.Size(162, 65);
            this.backupClipboard.TabIndex = 5;
            this.backupClipboard.UseVisualStyleBackColor = true;
            this.backupClipboard.Click += new System.EventHandler(this.backupClipboard_Click);
            // 
            // updateButton
            // 
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.updateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.updateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.ForeColor = System.Drawing.Color.Transparent;
            this.updateButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleDown;
            this.updateButton.IconColor = System.Drawing.Color.White;
            this.updateButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updateButton.IconSize = 36;
            this.updateButton.Location = new System.Drawing.Point(0, 269);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(162, 65);
            this.updateButton.TabIndex = 4;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // categoriesButton
            // 
            this.categoriesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoriesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoriesButton.FlatAppearance.BorderSize = 0;
            this.categoriesButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.categoriesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.categoriesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.categoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesButton.ForeColor = System.Drawing.Color.Transparent;
            this.categoriesButton.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.categoriesButton.IconColor = System.Drawing.Color.White;
            this.categoriesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.categoriesButton.IconSize = 36;
            this.categoriesButton.Location = new System.Drawing.Point(0, 204);
            this.categoriesButton.Name = "categoriesButton";
            this.categoriesButton.Size = new System.Drawing.Size(162, 65);
            this.categoriesButton.TabIndex = 3;
            this.categoriesButton.UseVisualStyleBackColor = true;
            this.categoriesButton.Click += new System.EventHandler(this.categoriesButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.Color.Transparent;
            this.settingsButton.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.settingsButton.IconColor = System.Drawing.Color.White;
            this.settingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingsButton.IconSize = 36;
            this.settingsButton.Location = new System.Drawing.Point(0, 139);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(162, 65);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.dashboardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.dashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.ForeColor = System.Drawing.Color.Transparent;
            this.dashboardButton.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            this.dashboardButton.IconColor = System.Drawing.Color.White;
            this.dashboardButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboardButton.IconSize = 36;
            this.dashboardButton.Location = new System.Drawing.Point(0, 74);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(162, 65);
            this.dashboardButton.TabIndex = 1;
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Resize += new System.EventHandler(this.ResizeEvent);
            this.panel2.ResumeLayout(false);
            this.panelVersion.ResumeLayout(false);
            this.panelVersion.PerformLayout();
            this.panelIcon.ResumeLayout(false);
            this.panelIcon.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.gunaGradient2Panel5.ResumeLayout(false);
            this.gunaGradient2Panel5.PerformLayout();
            this.gunaGradient2Panel4.ResumeLayout(false);
            this.gunaGradient2Panel4.PerformLayout();
            this.gunaGradient2Panel3.ResumeLayout(false);
            this.gunaGradient2Panel3.PerformLayout();
            this.gunaGradient2Panel2.ResumeLayout(false);
            this.gunaGradient2Panel2.PerformLayout();
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse elipseForm;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelIcon;
        private System.Windows.Forms.Label lblClipboardTxt;
        private System.Windows.Forms.Label lblManagerTxt;
        private FontAwesome.Sharp.IconButton dashboardButton;
        private FontAwesome.Sharp.IconButton updateButton;
        private FontAwesome.Sharp.IconButton categoriesButton;
        private FontAwesome.Sharp.IconButton settingsButton;
        private FontAwesome.Sharp.IconButton backupClipboard;
        private System.Windows.Forms.Panel panelVersion;
        private FontAwesome.Sharp.IconButton contactButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox aboutButton;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.LinkLabel btnSendFeedback;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel5;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel4;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel3;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel2;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblBackupDate;
        private System.Windows.Forms.Timer PanelTimer;
    }
}