﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profile_Display
{
    public partial class DisplayProfile : Form
    {
        public DisplayProfile() //take in the player object
        {
            //get the listview fixed because there is an extra column****
            InitializeComponent();

            this.dmButton.Click += new EventHandler(DmButton__Click); //go to their chat from the message class (inherit from this class only)
                                                                      //and access the users time,rank,games,username,bio,
                                                                      //and profile picture from the list (data base) 

            //display all info. from the lists here (display profile picture here too)**

        }

        private void DmButton__Click(object sender, EventArgs e)
        {
            //open the chat for the specific form
            //close form
        }

        public void PaintListView(string username) //take in the player and implement their data in the listview 
        {

        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void photoGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void gameListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void peopleListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void statsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dmButton_Click(object sender, EventArgs e)
        {

        }
    }
}
