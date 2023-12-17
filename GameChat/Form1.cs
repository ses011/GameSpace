using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayerInfo;

//add using statements here for the player info database and the profile-display class 
//so the error about the user object is gone

namespace GameChat
{

    public partial class GameChatForm : Form
    {
        public GameChatForm()
        {
            InitializeComponent();

            this.sonsOfTheForestButton.Click += new EventHandler(SonsOfTheForestButton__Click);
            this.rainbowSixSeigeButton.Click += new EventHandler(RainbowSixSeigeButton__Click);
            this.valorantButton.Click += new EventHandler(ValorantButton__Click);
            this.counterStrikeButton.Click += new EventHandler(CounterStrikeButton__Click);
            this.robloxButton.Click += new EventHandler(RobloxButton__Click);
            this.vrChatButton.Click += new EventHandler(VrChatButton__Click);
        }

        private void VrChatButton__Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new ChatForm("VR Chat");
        }
        private void RobloxButton__Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new ChatForm("Roblox");
        }
        private void CounterStrikeButton__Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new ChatForm("Counter Strike 2");
        }
        private void ValorantButton__Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new ChatForm("Valorant");
        }
        private void RainbowSixSeigeButton__Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new ChatForm("Rainbow Six Seige");
        }
        private void SonsOfTheForestButton__Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new ChatForm("Sons of the Forest");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
