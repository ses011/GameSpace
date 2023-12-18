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

namespace Matchups
{
    public partial class MatchupForm : Form
    {
        public MatchupForm()
        {
            InitializeComponent();


            int[] compat = new int[Players.userList.Count];
            for (int i = 0; i < compat.Length; i++)
            {
                compat[i] = 0;
            }


            User thisUser = Players.userList["ses011"];
            List<string> gamesList = thisUser.gameNames;


            game1.Text = "Game 1";
            game2.Text = "Game 2";
            game3.Text = "Game 3";

            nameLabel.Text = thisUser.username;

            compatLabel.Text = "%%";

            pictureBox1.ImageLocation = thisUser.pfp;

            //this.FormClosing += new FormClosingEventHandler(Form__Closing);

        }

        /*private void Form__Closing(object sender, FormClosingEventArgs e)
        {
            MatchupForm form = new MatchupForm();
        }*/

        private void homeLabel_Click(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {

        }

        private void previousButton_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }

        private void MatchupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
