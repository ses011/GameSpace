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
using GameChat;

//Contributions to project: Created profile display, contributed to creating database, created yUML, scheduled/organized team meetings and team deadlines 
namespace Profile_Display
{

    // Class: DisplayProfile
    // Author: Kashaf Ahmed
    // Purpose: Get a user object from another form and display the information for the user passed in.
    // Restrictions: None
    public partial class DisplayProfile : Form
    {
        public User formUser; //class scoped variable for the user object passed in 
        public DisplayProfile(User user) //take in the user object 
        {
            InitializeComponent();

            this.dmButton.Click += new EventHandler(DmButton__Click); 


            this.formUser = user; //set the class scoped variable to the user passed in

            this.usernameLabel.Text = "Username: " + user.username.ToString();
            if(user.bioLabel.ToString() == "") //if there is no bio then say there is no bio, otherwise display the bio
            {
                this.bioLabel.Text = "No bio to display";
            }
            else
            {
                this.bioLabel.Text = "Bio: " + user.bioLabel.ToString();
            }
            this.photoPictureBox.ImageLocation = user.pfp; //gets the profile photo url for the specific user based on the user
            if (user.onlineStatus == false)
            {
                this.statusLabel.Text = "Status: Offline"; //check to see what the users status is and change the textbox according to the boolean value
            }
            else if (user.onlineStatus == true)
            {
                this.statusLabel.Text = "Status: Online";
            }


        }

        // Method: DmButton__Click
        // Author: Kashaf Ahmed
        // Purpose: If the user presses the message button, pass the formUser variable (our current user) into the
        // ChatForm to open up their chat. Also disable the form.
        // Restrictions: None
        private void DmButton__Click(object sender, EventArgs e)
        {
            //this.Enabled = false;
            ChatForm chat = new ChatForm(formUser);
            chat.ShowDialog();
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

        private void DisplayProfile_Load(object sender, EventArgs e)
        {

        }
    }
}