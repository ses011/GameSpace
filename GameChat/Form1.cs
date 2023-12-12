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

            sonsOfTheForestButton.Click += new EventHandler(SonsOfTheForestButton__Click);
        }

        private void SonsOfTheForestButton__Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
