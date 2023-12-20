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
            this.meetupButton.Click += new EventHandler(MeetupButton__Click);
        }

        private void VrChatButton__Click(object sender, EventArgs e)
        {
            ChatForm chatForm = new ChatForm("VR Chat");
            chatForm.ShowDialog();
        }
        private void RobloxButton__Click(object sender, EventArgs e)
        {
            ChatForm chatForm = new ChatForm("Roblox");
            chatForm.ShowDialog();
        }
        private void CounterStrikeButton__Click(object sender, EventArgs e)
        {
            ChatForm chatForm = new ChatForm("Counter Strike 2");
            chatForm.ShowDialog();
        }
        private void ValorantButton__Click(object sender, EventArgs e)
        {
            ChatForm chatForm = new ChatForm("Valorant");
            chatForm.ShowDialog();
        }
        private void RainbowSixSeigeButton__Click(object sender, EventArgs e)
        {
            ChatForm chatForm = new ChatForm("Rainbow Six Seige");
            chatForm.ShowDialog();
        }
        private void SonsOfTheForestButton__Click(object sender, EventArgs e)
        {
            ChatForm chatForm = new ChatForm("Sons of the Forest");
            chatForm.ShowDialog();
        }

        private void MeetupButton__Click(Object sender, EventArgs e)
        {
            List<string> users = new List<string>();
            users.Add("anonygoose");
            users.Add("gooobr");
            users.Add(".grbe");
            Meetup meetup = new Meetup("Valorant Watchparty", "Come and hang out with other Valorant players and watch the esports team play Rutgers!", "MAGIC Spell Studios (MSS)-2150", "12/22 5:00 PM", users);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
