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

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Policy;
//using System.Text;
//using System.Threading.Tasks;
//using PlayerInfo;
//using GameChat;
//using System.Runtime.Remoting.Messaging;
//
///**
// * Authors: Kashaf Ahmed (majority) and Sarah Schnedier
// * 
// * 
// * 
// */
//namespace PlayerInfo
//{
//    //we could also user enumerated type to store data from sorted lists instead (we can't add spaces to enumerated types so
//    //maybe sorted list would be better for the things that have spaces in between maybe?
//    public enum EGames
//    {
//        Sons_of_The_Forest,
//        Rainbow_Six_Siege,
//        Valorant,
//        Counter_Strike,
//        Roblox,
//        VRChat
//
//    }
//
//
//    public class User
//    {
//
//        public string username;
//        public string bioLabel;
//        public bool onlineStatus;
//        public string pfp;
//
//        //sorted list that takes in the username as the key and the games as a value (could use a tuple for the value to store multiple values in)
//        //of if there was an easier way of doing it not too sure 
//        public SortedList<string, string> gameNames = new SortedList<string, string>();
//        //username is key and the time is the value (could also use the tuple approach for the value so we could store multiple things in one value)
//        public SortedList<string, int> times = new SortedList<string, int>();
//        //username is key and the rank is the value(could also use the tuple approach for the value so we could store multiple things in one value)
//        public SortedList<string, int> rank = new SortedList<string, int>();
//        //a user's friends
//        public SortedList<string, string> friends = new SortedList<string, string>();
//
//
//        // Constructor
//        public User(string username, string bioLabel, bool onlineStatus)
//        {
//            this.username = username;
//            this.bioLabel = bioLabel;
//            this.onlineStatus = onlineStatus;
//            this.gameNames = this.SetRandomGames();
//            this.times = this.SetTimes();
//            this.friends = this.SetFriends();
//            this.rank = this.SetRank();
//        }
//
//        private SortedList<string, string> SetRandomGames()
//        {
//            Random random = new Random();
//            SortedList<string, string> games = new SortedList<string, string>();
//
//            foreach (string game in Enum.GetNames(typeof(EGames)))
//            {
//                // 50/50 randomization that a game gets added to the list of games
//                if (random.Next(2) == 1)
//                {
//                    games.Add(this.username, game);
//                }
//            }
//
//            return games;
//        }
//
//        private SortedList<string, int> SetTimes()
//        {
//            SortedList<string, int> time = new SortedList<string, int>();
//
//            return time;
//        }
//
//        private SortedList<string, string> SetFriends()
//        {
//            SortedList<string, string> friends = new SortedList<string, string>();
//
//            return friends;
//        }
//
//        private SortedList<string, int> SetRank()
//        {
//            SortedList<string, int> rank = new SortedList<string, int>();
//
//            return rank;
//        }
//
//        //implement each list in UserDataBase file we will create and populate the userList defined in Players based on the username as the key
//        //and the User object as the value 
//
//
//        //was not too sure if we wanted a comparison here either but kept it just in case 
//        //public static bool operator <(Student s1, Student s2)
//        //{
//        //    return (s1.gpa < s2.gpa);
//        //}
//        //
//        //public static bool operator <=(Student s1, Student s2)
//        //{
//        //    return (s1.gpa <= s2.gpa);
//        //}
//        //
//        //public static bool operator >(Student s1, Student s2)
//        //{
//        //    return (s1.gpa > s2.gpa);
//        //}
//        //
//        //public static bool operator >=(Student s1, Student s2)
//        //{
//        //    return (s1.gpa >= s2.gpa);
//        //}
//        //
//        //public static bool operator ==(Student s1, Student s2)
//        //{
//        //    return (s1.gpa == s2.gpa);
//        //}
//        //
//        //public static bool operator !=(Student s1, Student s2)
//        //{
//        //    return (s1.gpa != s2.gpa);
//        //}
//    }
//
//    // [+People|sortedList:SortedList<string, Person>|this:email|+Remove(email: string)]
//    public class Players //did players here instead of users so it would not be confusing 
//    {
//
//        // create a Sorted List indexed on username (string) and storing User objects
//        public static SortedList<string, User> userList = new SortedList<string, User>();
//
//        public void Remove(string username)
//        {
//            if (username != null)
//            {
//                userList.Remove(username);
//            }
//        }
//
//        // indexer property allows array access to sortedList via the class object
//        // and catching missing keys and duplicate key exceptions
//        //gets a user based on the username as the key and the whole object as the value 
//        public User this[string username]
//        {
//            get
//            {
//                User returnVal;
//                try
//                {
//                    returnVal = (User)userList[username];
//                }
//                catch
//                {
//                    returnVal = null;
//                }
//
//                return (returnVal);
//            }
//
//            set
//            {
//                try
//                {
//                    //we can add to the list if we want by username
//                    userList[username] = value;
//                }
//                catch
//                {
//                    // an exception will be raised if an entry with a duplicate key is added
//                    // duplicate key handling
//                }
//            }
//        }
//
//
//        public static void Main()
//        {
//            userList.Add("ses011", new User("ses011", "nope. just nope", false));
//            userList.Add("kash_registerr", new User("kash_registerr", "", false));
//            userList.Add("catast0phi", new User("catast0phi", "oh boy!!! VIOLENCE for christmas!!!!!!", false));
//            userList.Add("goooobr", new User("gooobr", ":3", false));
//            userList.Add("anonygoose", new User("anonygoose", "your local fisherman dad", false));
//            userList.Add(".grbe", new User(".grbe", "", false));
//            userList.Add("not_phoeniix", new User("not_phoeniix", "they call me the Grinch\nthey call me\nthey call me the\nthey\nGrinch", false));
//        }
//    }
//}