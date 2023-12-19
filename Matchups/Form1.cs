using PlayerInfo;
using Profile_Display;
using Leaderboard;
using HomepagePrototype;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.CodeDom.Compiler;
using System.Runtime.InteropServices.ComTypes;

// Niko Huber
// IGME 201
// Final Project

namespace Matchups
{
    // GameSpace Matchups
    public partial class MatchupForm : Form
    {
        // init variables
        int currentUser = 0;
        IList<string> names;

        // the user profile
        User myProfile;
        int compatScore = 0;

        // init
        public MatchupForm()
        {
            InitializeComponent();

            // set the current user 
            myProfile = Players.userList["ses011"];

            // set the list of names from main database
            names = Players.userList.Keys;

            // display the first profile
            UpdateProfile();

            // removed formclosing event
            //this.FormClosing += new FormClosingEventHandler(Form__Closing);

        }

        /*private void Form__Closing(object sender, FormClosingEventArgs e)
        {
            MatchupForm form = new tempForm();
        }*/

        // Update displayed profile
        private void UpdateProfile()
        {
            // get current user
            User thisUser = Players.userList[names[currentUser]];

            // reset compat score
            compatScore = 0;

            // set all text to 0
            game1.Text = "";
            game2.Text = "";
            game3.Text = "";

            int i;

            // go through current user game list
            for (i = 0; i < thisUser.gameNames.Count; i++)
            { 
                // goes through first three games in gameList if they exist
                switch (i)
                {
                    // if game 1 exists
                    case (0):
                        // set text for game name
                        game1.Text = thisUser.gameNames[0];
                        // check current user profile and adjust score
                        if (myProfile.gameNames[0] == thisUser.gameNames[0])
                        {
                            compatScore += 40;
                        }
                        break;
                    // if game 2 exists
                    case (1):
                        // set text for game name
                        game2.Text = thisUser.gameNames[1];
                        // check current user profile and adjust score
                        if (myProfile.gameNames[1] == thisUser.gameNames[1])
                        {
                            compatScore += 30;
                        }
                        break;
                    // if game 3 exists
                    case (2):
                        // set text for game name
                        game3.Text = thisUser.gameNames[2];
                        // check current user profile and adjust score
                        if (myProfile.gameNames[2] == thisUser.gameNames[2])
                        {
                            compatScore += 30;
                        }
                        break;
                        // default case
                    default:
                        break;

                }
            }

            // set name label text, picture box, and compatability label
            nameLabel.Text = thisUser.username;

            pictureBox1.ImageLocation = thisUser.pfp;

            compatLabel.Text = compatScore.ToString() + "%";
        }
        // go home
        private void homeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Next Button Event
        private void nextButton_Click(object sender, EventArgs e)
        {
            // if current user is within bounds of list
            if(currentUser < names.Count - 1)
            {
                // adjust current user and update profile
                currentUser++;
                UpdateProfile();
            }

        }

        // Previous Button Event
        private void previousButton_Click(object sender, EventArgs e)
        {
            // if current user is within bounds of list
            if (currentUser > 0)
            {
                // adjust current user and update profile
                currentUser--;
                UpdateProfile();
            }

        }

        // Picture Box Click Event
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // open user profile of given picture
            Form dispProf = new DisplayProfile(Players.userList[names[currentUser]]);
            dispProf.ShowDialog();
        }

        // show leaderboard
        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            Form form = new Board();
            this.Close();
            form.ShowDialog();
        }

        // go home 2
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // go to my profile
        private void usernameLabel_Click(object sender, EventArgs e)
        {
            Form dispProf = new DisplayProfile(myProfile);
            this.Close();
            dispProf.ShowDialog();
        }
    }
}
