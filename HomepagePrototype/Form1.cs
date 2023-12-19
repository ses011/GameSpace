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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomepagePrototype
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();

            foreach (User user in Players.userList.Values)
            {
                if (!user.username.Equals("ses011"))
                {
                    this.ListUsers.Items.Add(user.username);
                }
            }

            this.ListUsers.SelectedIndexChanged += new EventHandler(ListUsers__SelectedIndexChanged);

            this.matchButton.Click += new EventHandler(MatchButton__Click);
            this.matchLabel.Click += new EventHandler(MatchButton__Click);
            this.leaderboardLabel.Click += new EventHandler(LeaderboardLabel__Click);
            this.chatsLabel.Click += new EventHandler(ChatsLabel_Click);

            this.usernameLabel.Click += new EventHandler(UsernameLabel__Click);
        }

        public void MatchButton__Click(object sender, EventArgs e)
        {
            MatchupForm match = new MatchupForm();
            match.ShowDialog();
        }

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

        public void ListUsers__SelectedIndexChanged(object sender, EventArgs e)
        {
            string user = (ListUsers.SelectedItems).ToString();
            if (Players.userList.ContainsKey(user))
            {
                DisplayProfile profile = new DisplayProfile(Players.userList[user]);
                profile.ShowDialog();
            }
            
        }
    }
}
