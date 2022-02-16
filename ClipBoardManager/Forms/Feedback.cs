using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipBoardManager.Forms
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void PlaySound(string param)
        {
            try
            {
                using (SoundPlayer player = new SoundPlayer())
                {

                    player.SoundLocation = param;
                    player.Play();
                    player.Dispose();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void GoMainMenu()
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.Show();
        }

        private void txtFeedbackNote_TextChanged(object sender, EventArgs e)
        {
            int _len = txtFeedbackNote.TextLength;
            lblCharacterLimit.Text = "Character Limit: "+ txtFeedbackNote.TextLength.ToString() + "/" + txtFeedbackNote.MaxLength;

            if (_len >= 0 && _len <=99)
                lblCharacterLimit.ForeColor = Color.Lime;
            else if (_len >= 100 && _len <= 230)
                lblCharacterLimit.ForeColor = Color.Yellow;
            else if (_len >= 231)
                lblCharacterLimit.ForeColor = Color.Red;
        }

        private void Feedback_Load(object sender, EventArgs e)
        {

        }

        private void InputController_Tick(object sender, EventArgs e)
        {
            if (txtFeedbackNote.TextLength < 5 || txtFeedBackTopic.SelectedIndex == 0 || txtFeedBackTopic.SelectedIndex == -1)
                btnSendFeedback.Enabled = false;
            else        
                btnSendFeedback.Enabled = true;
            
        }

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {
            Services.DiscordContentFilter.Send
                ("-------------------------------------------\n" +
                "New Feedback!\nTopic: " + 
                txtFeedBackTopic.Text + 
                "\n\nContent: " + 
                txtFeedbackNote.Text, 
                Properties.Settings.Default.FeedbackURL);

            PlaySound(@"reported.wav");
            MessageBox.Show("Your feedback was sent successfully!","ClipBoardApp Warning",MessageBoxButtons.OK);
            GoMainMenu();

        }

        private void returnHome_Click(object sender, EventArgs e)
        {
            GoMainMenu();
        }
    }
}
