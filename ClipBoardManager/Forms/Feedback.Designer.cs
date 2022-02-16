namespace ClipBoardManager.Forms
{
    partial class Feedback
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
            this.txtFeedbackNote = new System.Windows.Forms.RichTextBox();
            this.txtFeedBackTopic = new Guna.UI.WinForms.GunaComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.elipseForm = new Guna.UI.WinForms.GunaElipse(this.components);
            this.lblCharacterLimit = new System.Windows.Forms.Label();
            this.InputController = new System.Windows.Forms.Timer(this.components);
            this.btnSendFeedback = new FontAwesome.Sharp.IconButton();
            this.returnHome = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFeedbackNote
            // 
            this.txtFeedbackNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txtFeedbackNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFeedbackNote.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFeedbackNote.ForeColor = System.Drawing.Color.White;
            this.txtFeedbackNote.Location = new System.Drawing.Point(32, 142);
            this.txtFeedbackNote.MaxLength = 250;
            this.txtFeedbackNote.Name = "txtFeedbackNote";
            this.txtFeedbackNote.Size = new System.Drawing.Size(658, 271);
            this.txtFeedbackNote.TabIndex = 0;
            this.txtFeedbackNote.Text = "";
            this.txtFeedbackNote.TextChanged += new System.EventHandler(this.txtFeedbackNote_TextChanged);
            // 
            // txtFeedBackTopic
            // 
            this.txtFeedBackTopic.BackColor = System.Drawing.Color.Transparent;
            this.txtFeedBackTopic.BaseColor = System.Drawing.Color.White;
            this.txtFeedBackTopic.BorderColor = System.Drawing.Color.Silver;
            this.txtFeedBackTopic.BorderSize = 0;
            this.txtFeedBackTopic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFeedBackTopic.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtFeedBackTopic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtFeedBackTopic.FocusedColor = System.Drawing.Color.Empty;
            this.txtFeedBackTopic.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFeedBackTopic.ForeColor = System.Drawing.Color.Black;
            this.txtFeedBackTopic.FormattingEnabled = true;
            this.txtFeedBackTopic.Items.AddRange(new object[] {
            "Select Topic",
            "Design",
            "Programming",
            "Optimization",
            "Bugs / Errors",
            "Improvement",
            "Other"});
            this.txtFeedBackTopic.Location = new System.Drawing.Point(32, 72);
            this.txtFeedBackTopic.Name = "txtFeedBackTopic";
            this.txtFeedBackTopic.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFeedBackTopic.OnHoverItemForeColor = System.Drawing.Color.White;
            this.txtFeedBackTopic.Size = new System.Drawing.Size(658, 26);
            this.txtFeedBackTopic.StartIndex = 0;
            this.txtFeedBackTopic.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.aboutButton);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 29);
            this.panel1.TabIndex = 2;
            // 
            // aboutButton
            // 
            this.aboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutButton.Image = global::ClipBoardManager.Properties.Resources.minimized;
            this.aboutButton.Location = new System.Drawing.Point(686, 7);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(15, 15);
            this.aboutButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aboutButton.TabIndex = 26;
            this.aboutButton.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Image = global::ClipBoardManager.Properties.Resources.close;
            this.exitButton.Location = new System.Drawing.Point(716, 7);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(15, 15);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 24;
            this.exitButton.TabStop = false;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Image = global::ClipBoardManager.Properties.Resources.about;
            this.minimizeButton.Location = new System.Drawing.Point(701, 7);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(15, 15);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeButton.TabIndex = 25;
            this.minimizeButton.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClipBoardManager.Properties.Resources.feedback;
            this.pictureBox1.Location = new System.Drawing.Point(9, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feedback System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Feedback Topic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Feedback Note";
            // 
            // elipseForm
            // 
            this.elipseForm.Radius = 15;
            this.elipseForm.TargetControl = this;
            // 
            // lblCharacterLimit
            // 
            this.lblCharacterLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharacterLimit.ForeColor = System.Drawing.Color.Lime;
            this.lblCharacterLimit.Location = new System.Drawing.Point(537, 416);
            this.lblCharacterLimit.Name = "lblCharacterLimit";
            this.lblCharacterLimit.Size = new System.Drawing.Size(153, 16);
            this.lblCharacterLimit.TabIndex = 5;
            this.lblCharacterLimit.Text = "Character Limit: 0/250";
            this.lblCharacterLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InputController
            // 
            this.InputController.Enabled = true;
            this.InputController.Interval = 1;
            this.InputController.Tick += new System.EventHandler(this.InputController_Tick);
            // 
            // btnSendFeedback
            // 
            this.btnSendFeedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendFeedback.FlatAppearance.BorderSize = 0;
            this.btnSendFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendFeedback.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btnSendFeedback.IconColor = System.Drawing.Color.White;
            this.btnSendFeedback.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSendFeedback.IconSize = 36;
            this.btnSendFeedback.Location = new System.Drawing.Point(192, 435);
            this.btnSendFeedback.Name = "btnSendFeedback";
            this.btnSendFeedback.Size = new System.Drawing.Size(165, 56);
            this.btnSendFeedback.TabIndex = 6;
            this.btnSendFeedback.Text = "Send Feedback";
            this.btnSendFeedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSendFeedback.UseVisualStyleBackColor = true;
            this.btnSendFeedback.Click += new System.EventHandler(this.btnSendFeedback_Click);
            // 
            // returnHome
            // 
            this.returnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnHome.FlatAppearance.BorderSize = 0;
            this.returnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnHome.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.returnHome.IconColor = System.Drawing.Color.White;
            this.returnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.returnHome.IconSize = 36;
            this.returnHome.Location = new System.Drawing.Point(374, 435);
            this.returnHome.Name = "returnHome";
            this.returnHome.Size = new System.Drawing.Size(165, 56);
            this.returnHome.TabIndex = 7;
            this.returnHome.Text = "Return Main Menu";
            this.returnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.returnHome.UseVisualStyleBackColor = true;
            this.returnHome.Click += new System.EventHandler(this.returnHome_Click);
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(743, 518);
            this.Controls.Add(this.returnHome);
            this.Controls.Add(this.btnSendFeedback);
            this.Controls.Add(this.lblCharacterLimit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtFeedBackTopic);
            this.Controls.Add(this.txtFeedbackNote);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.Feedback_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtFeedbackNote;
        private Guna.UI.WinForms.GunaComboBox txtFeedBackTopic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox aboutButton;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaElipse elipseForm;
        private System.Windows.Forms.Label lblCharacterLimit;
        private System.Windows.Forms.Timer InputController;
        private FontAwesome.Sharp.IconButton btnSendFeedback;
        private FontAwesome.Sharp.IconButton returnHome;
    }
}