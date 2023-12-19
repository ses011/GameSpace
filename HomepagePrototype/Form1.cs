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
using Profile_Display;
using Matchups;
using Leaderboard;
using GameChat;
//using ListView = System.Windows.Forms.VisualStyles.VisualStyleElement;

/*
 * Author: Sarah Schneider
 * 
 * Homepage setup and event handlers
 */
namespace HomepagePrototype
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();

            // Populate listview with all the users
            foreach (User user in Players.userList.Values)
            {
                if (!user.username.Equals("ses011"))
                {
                    this.ListUsers.Items.Add(user.username);
                }
            }

            this.ListUsers.ItemActivate += new EventHandler(ListUsers__ItemActivate);

            this.matchButton.Click += new EventHandler(MatchButton__Click);
            this.matchLabel.Click += new EventHandler(MatchButton__Click);
            this.leaderboardLabel.Click += new EventHandler(LeaderboardLabel__Click);
            this.chatsLabel.Click += new EventHandler(ChatsLabel_Click);

            this.usernameLabel.Click += new EventHandler(UsernameLabel__Click);
        }

        // Open match page
        public void MatchButton__Click(object sender, EventArgs e)
        {
            MatchupForm match = new MatchupForm();
            match.ShowDialog();
        }

        // Open own profile
        public void UsernameLabel__Click(object sender, EventArgs e)
        {
            string val = "ses011";
            if (Players.userList.ContainsKey(val))
            {
                User user = Players.userList[val];
                DisplayProfile profile = new DisplayProfile(user);
                profile.ShowDialog();
            }
        }

        public void LeaderboardLabel__Click(Object sender, EventArgs e)
        {
            Board board = new Board();
            board.ShowDialog();
        }

        public void ChatsLabel_Click(Object sender, EventArgs e)
        {
            GameChatForm chats = new GameChatForm();
            chats.ShowDialog();
        }

        private void ListUsers__ItemActivate(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;

            string username = lv.SelectedItems[0].Text;

            if (username != null && Players.userList.ContainsKey(username))
            {
                DisplayProfile profile = new DisplayProfile(Players.userList[username]);
                profile.ShowDialog();
            }
        }
    }
}
