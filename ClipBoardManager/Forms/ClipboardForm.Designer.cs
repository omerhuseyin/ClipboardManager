namespace ClipBoardManager.Forms
{
    partial class ClipboardForm
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
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.actionSelect = new Guna.UI.WinForms.GunaComboBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.clipboardListView = new System.Windows.Forms.ListBox();
            this.ClipboardController = new System.Windows.Forms.Timer(this.components);
            this.MsgTimer = new System.Windows.Forms.Timer(this.components);
            this.executeButton = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.BorderSize = 0;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Items.AddRange(new object[] {
            "All",
            "General",
            "NSFW",
            "Fun",
            "Programming",
            "YouTube",
            "Films",
            "Books"});
            this.gunaComboBox1.Location = new System.Drawing.Point(161, 25);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Radius = 10;
            this.gunaComboBox1.Size = new System.Drawing.Size(307, 24);
            this.gunaComboBox1.StartIndex = 0;
            this.gunaComboBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(270, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Category to List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(271, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Command to Run";
            // 
            // actionSelect
            // 
            this.actionSelect.BackColor = System.Drawing.Color.Transparent;
            this.actionSelect.BaseColor = System.Drawing.Color.White;
            this.actionSelect.BorderColor = System.Drawing.Color.Silver;
            this.actionSelect.BorderSize = 0;
            this.actionSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.actionSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionSelect.FocusedColor = System.Drawing.Color.Empty;
            this.actionSelect.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.actionSelect.ForeColor = System.Drawing.Color.Black;
            this.actionSelect.FormattingEnabled = true;
            this.actionSelect.Items.AddRange(new object[] {
            "SELECT A COMMAND",
            "COPY",
            "REMOVE",
            "SEND DISCORD"});
            this.actionSelect.Location = new System.Drawing.Point(209, 334);
            this.actionSelect.Name = "actionSelect";
            this.actionSelect.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.actionSelect.OnHoverItemForeColor = System.Drawing.Color.White;
            this.actionSelect.Radius = 10;
            this.actionSelect.Size = new System.Drawing.Size(222, 22);
            this.actionSelect.StartIndex = 0;
            this.actionSelect.TabIndex = 15;
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsg.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMsg.Location = new System.Drawing.Point(203, 405);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(242, 13);
            this.lblMsg.TabIndex = 13;
            this.lblMsg.Text = "MSG";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMsg.Visible = false;
            // 
            // clipboardListView
            // 
            this.clipboardListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.clipboardListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clipboardListView.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clipboardListView.ForeColor = System.Drawing.Color.White;
            this.clipboardListView.FormattingEnabled = true;
            this.clipboardListView.HorizontalScrollbar = true;
            this.clipboardListView.ItemHeight = 16;
            this.clipboardListView.Location = new System.Drawing.Point(7, 71);
            this.clipboardListView.Name = "clipboardListView";
            this.clipboardListView.Size = new System.Drawing.Size(650, 224);
            this.clipboardListView.TabIndex = 12;
            // 
            // ClipboardController
            // 
            this.ClipboardController.Enabled = true;
            this.ClipboardController.Interval = 1;
            this.ClipboardController.Tick += new System.EventHandler(this.ClipboardController_Tick);
            // 
            // MsgTimer
            // 
            this.MsgTimer.Interval = 1000;
            this.MsgTimer.Tick += new System.EventHandler(this.MsgTimer_Tick);
            // 
            // executeButton
            // 
            this.executeButton.FlatAppearance.BorderSize = 0;
            this.executeButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.executeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.executeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.executeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.executeButton.ForeColor = System.Drawing.Color.Transparent;
            this.executeButton.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.executeButton.IconColor = System.Drawing.Color.White;
            this.executeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.executeButton.IconSize = 36;
            this.executeButton.Location = new System.Drawing.Point(294, 366);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(60, 33);
            this.executeButton.TabIndex = 17;
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // ClipboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(662, 427);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.actionSelect);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.clipboardListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaComboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClipboardForm";
            this.Text = "ClipboardForm";
            this.Load += new System.EventHandler(this.ClipboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox actionSelect;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.ListBox clipboardListView;
        private FontAwesome.Sharp.IconButton executeButton;
        private System.Windows.Forms.Timer ClipboardController;
        private System.Windows.Forms.Timer MsgTimer;
    }
}