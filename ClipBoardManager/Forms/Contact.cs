using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipBoardManager.Forms
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void DiscordBannerController_Tick(object sender, EventArgs e)
        {
            pcrDiscord.ImageLocation = "https://discord.c99.nl/widget/theme-4/892785729153933313.png";

        }

        private void pcrDiscord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.com/users/892785729153933313");

        }

        private void pcrGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/omerhuseyingul");

        }

        private void pcrInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/omerhuseyingul0/");

        }

        private void pcrTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/omerhuseyingul");

        }

        private void pcrMail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:omerhuseyingul@outlook.com");

        }
    }
}
