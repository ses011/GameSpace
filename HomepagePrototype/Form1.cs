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

namespace HomepagePrototype
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();




            this.matchButton.Click += new EventHandler(MatchButton__Click);
            this.matchLabel.Click += new EventHandler(MatchButton__Click);

            this.usernameLabel.Click += new EventHandler(UsernameLabel__Click);
        }

        public void MatchButton__Click(object sender, EventArgs e)
        {
            MatchupForm match = new MatchupForm();
            match.ShowDialog();
        }

        public void UsernameLabel__Click(object sender, EventArgs e)
        {
            string val = "kash_registerr";
            if (Players.userList.ContainsKey(val))
            {
                User user = Players.userList[val];
                DisplayProfile profile = new DisplayProfile(user);
                profile.ShowDialog();
            }
        }
    }
}
