using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using PlayerInfo;
using GameChat;
using System.Runtime.Remoting.Messaging;

/*
 * Authors: Kashaf Ahmed and Sarah Schnedier
 */
namespace PlayerInfo
{
    //Enumerated type to hold the game names
    public enum EGames 
    {
      Sons_of_The_Forest,
      Rainbow_Six_Siege,
      Valorant,
      Counter_Strike,
      Roblox,
      VRChat
    
    }


    // Class: User
    // Author: Kashaf Ahmed and Sarah Schnedier
    // Purpose: Creates the user object with a username, bio, online status, profile picture, as well as 
    // the lists for the games, times, rank, and friends for the current user. The sorted lists are populated
    // from different methods that Sarah had written. The time and rank are accessed by the game name (key) and everything else
    // is accessed from the username (key).
    // Restrictions: None
    public class User
    {

        public string username;
        public string bioLabel;
        public bool onlineStatus;
        public string pfp;

        
        public SortedList<string, string> gameNames = new SortedList<string, string>();
      
        public SortedList<string, double> times = new SortedList<string, double>();
      
        public SortedList<string, int> rank = new SortedList<string, int>();
       
        public SortedList<string, User> friends = new SortedList<string, User>();


        // Constructor
        public User(string username, string bioLabel, bool onlineStatus)
        {
            this.username = username;
            this.bioLabel = bioLabel;
            this.onlineStatus = onlineStatus;
            this.gameNames = this.SetRandomGames();
            this.times = this.SetTimes();
            this.friends = this.SetFriends();
        }

        private SortedList<string, string> SetRandomGames()
        {
            Random random = new Random();
           

            foreach (string game in Enum.GetNames(typeof(EGames))) {
                // 50/50 randomization that a game gets added to the list of games
                if(random.Next(2) == 1)
                {
                    gameNames.Add(this.username, game);
                }
            }

            return gameNames;
        }

        private SortedList<string, double> SetTimes()
        {
            SortedList<string, double> time = new SortedList<string, double>();
            Random random = new Random();
            foreach (string game in this.gameNames.Values)
            {
                double val = random.NextDouble();
                if (val > 3 && val < 40)
                {
                    time.Add(game, val);
                }
            }

            return time;
        }

        private SortedList<string, User> SetFriends()
        {
            Random random = new Random();

            foreach (string name in Players.userList.Keys)
            {
                // 50/50 randomization that a game gets added to the list of games
                if (random.Next(2) == 1 && !name.Equals(this.username))
                {
                    friends.Add(name, Players.userList[name]);
                }
            }
            return friends;
        }

        public static SortedList<string, int> SetRank()
        {

            return rank;
        }

       
    }


    // Class: Players
    // Author: Kashaf Ahmed 
    // Purpose: Create the list of users and have the username be the key to remove a user object from the list if necessary.
    // the indexer property allows us to access the sorted list and get a user object based on the username.
    // Restrictions: None
    public class Players 
    {

        // create a Sorted List indexed on username (string) and storing User objects
        public static SortedList<string, User> userList = new SortedList<string, User>();

        public void Remove(string username)
        {
            if (username != null)
            {
                userList.Remove(username);
            }
        }

        // indexer property allows array access to sortedList via the class object
        // and catching missing keys and duplicate key exceptions
        //gets a user based on the username as the key and the whole object as the value 
        public User this[string username]
        {
            get
            {
                User returnVal;
                try
                {
                    returnVal = (User)userList[username]; 
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                try
                {
                    //we can add to the list if we want by username
                    userList[username] = value;
                }
                catch
                {
                    // an exception will be raised if an entry with a duplicate key is added
                    // duplicate key handling (should we write something for this catch statement or is it ok to leave it empty)**
                }
            }
        }
    }
}