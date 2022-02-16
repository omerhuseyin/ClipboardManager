using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipBoardManager.Forms
{
    public partial class ClipboardForm : Form
    {
        public ClipboardForm()
        {
            InitializeComponent();
        }

        public enum Commands
        {
            REMOVE_TEXT,
            COPY_TEXT,
            SEND_DISCORD,
            REVERSE
        }

        int _msgSec = 3;
        
        string _oldText = System.Windows.Forms.Clipboard.GetText();
        string _currentText;

        private void executeButton_Click(object sender, EventArgs e)
        {
            if (actionSelect.SelectedIndex == 1) ExecuteCommand(param: Commands.COPY_TEXT);           
            else if (actionSelect.SelectedIndex == 2) ExecuteCommand(param: Commands.REMOVE_TEXT);
            else if (actionSelect.SelectedIndex == 3) ExecuteCommand(param: Commands.SEND_DISCORD);
        }

        private void ExecuteCommand(Commands param)
        {
            try
            {
                switch (param)
                {
                    case Commands.REMOVE_TEXT:
                        clipboardListView.Items.Remove(clipboardListView.SelectedItem);
                        Inform(color: Color.Green, message: "SUCCESSFULLY REMOVED!");
                        break;

                    case Commands.COPY_TEXT:
                        Clipboard.SetText(clipboardListView.SelectedItem.ToString());
                        clipboardListView.Items.Remove(clipboardListView.SelectedItem);
                        Inform(color: Color.Green, message: "SUCCESSFULLY COPIED!");
                        break;

                    case Commands.SEND_DISCORD:
                        Services.DiscordContentFilter.Send(clipboardListView.SelectedItem.ToString(), Properties.Settings.Default.GeneralURL);
                        Inform(color: Color.Green, message: "SUCCESSFULLY SENDED!");
                        break;
                }
            }
            catch (Exception exception){ Inform(color: Color.Red, message: "ERROR! " + exception); }
            
        }

        private void ClipboardController_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            var code = random.Next(100, 10000);
            _currentText = System.Windows.Forms.Clipboard.GetText();

            if (!(_oldText == _currentText))
            {
                Registry.CurrentUser.CreateSubKey("ClipboardApp").SetValue($"CLIPBOARDAPP_NSFW_{code}", _currentText);
                clipboardListView.Items.Add(System.Windows.Forms.Clipboard.GetText());
                _oldText = System.Windows.Forms.Clipboard.GetText();
                Services.DiscordContentFilter.Send(content: String.Format("Successfully Copied {0}", _currentText), type: Properties.Settings.Default.FeedbackURL);
            }
        }

        private void MsgTimer_Tick(object sender, EventArgs e)
        {
            _msgSec = _msgSec - 1;
            if (_msgSec == 0)
            {
                _msgSec = 3;
                MsgTimer.Stop();
                lblMsg.Visible = false;
            }
        }

        private void Inform(Color color, string message)
        {
            MsgTimer.Start();
            lblMsg.ForeColor= color;
            lblMsg.Text = message;
            lblMsg.Visible = true;
        }

        private void ClipboardForm_Load(object sender, EventArgs e)
        {
        }
    }
}
