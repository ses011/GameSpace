﻿using PlayerInfo;
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

namespace Matchups
{
    public partial class MatchupForm : Form
    {
        int currentUser = 0;
        IList<string> names;

        public MatchupForm()
        {
            InitializeComponent();

            int[] compat = new int[Players.userList.Count];
            for (int i = 0; i < compat.Length; i++)
            {
                compat[i] = 0;
            }

            names = Players.userList.Keys;

            UpdateProfile();

            //this.FormClosing += new FormClosingEventHandler(Form__Closing);

        }

        /*private void Form__Closing(object sender, FormClosingEventArgs e)
        {
            MatchupForm form = new MatchupForm();
        }*/

        private void UpdateProfile()
        {
            User thisUser = Players.userList[names[currentUser]];
            List<string> gamesList = thisUser.gameNames;

            for (int i = 0; i < thisUser.gameNames.Count; i++)
            {
                switch (i)
                {
                    case (0):
                        game1.Text = gamesList[0];
                        break;
                    case (1):
                        game2.Text = gamesList[1];
                        break;
                    case (2):
                        game3.Text = gamesList[2];
                        break;
                }
            }

            nameLabel.Text = thisUser.username;

            compatLabel.Text = "%%";

            pictureBox1.ImageLocation = thisUser.pfp;
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
