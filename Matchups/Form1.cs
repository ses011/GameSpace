using PlayerInfo;
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

                switch (i)
                {
                    case (0):
                        game1.Text = thisUser.gameNames[0];
                        if (myProfile.gameNames[0] == thisUser.gameNames[0])
                        {
                            compatScore += 40;
                        }
                        break;
                    case (1):
                        game2.Text = thisUser.gameNames[1];
                        if (myProfile.gameNames[1] == thisUser.gameNames[1])
                        {
                            compatScore += 30;
                        }
                        break;
                    case (2):
                        game3.Text = thisUser.gameNames[2];
                        if (myProfile.gameNames[2] == thisUser.gameNames[2])
                        {
                            compatScore += 30;
                        }
                        break;

                }
            }

            nameLabel.Text = thisUser.username;

            pictureBox1.ImageLocation = thisUser.pfp;

            compatLabel.Text = compatScore.ToString() + "%";
        }

        private void homeLabel_Click(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if(currentUser < names.Count - 1)
            {
                currentUser++;
                UpdateProfile();
            }

        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (currentUser > 0)
            {
                currentUser--;
                UpdateProfile();
            }

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }

        private void MatchupForm_Load(object sender, EventArgs e)
        {

        }

        private void compatLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
