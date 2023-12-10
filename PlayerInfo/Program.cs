﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using PlayerInfo;
using GameChat;



/**
 * Authors: Kashaf Ahmed (majority) and Sarah Schnedier
 * 
 * 
 * 
 */
namespace PlayerInfo
{
    //public enum EGames //we could also user enumerated type to store data from sorted lists instead (we can't add spaces to enumerated types so
    //                    //maybe sorted list would be better for the things that have spaces in between maybe?
    //{
    //  Sons_of_The_Forest,
    //  Rainbow_Six_Siege,
    //  Valorant,
    //  Counter_Strike,
    //  Roblox,
    //  VRChat
    //
    //
    //}
    //
    //public enum ETimes
    //{
    //    
    //}
    //
    //public enum ERank
    //{
    //    
    //}
    //public enum EProfilePhotos
    //{
    // 
    //}
    //
    public class User
    {

        public string username;
        public string bioLabel;
        public bool onlineStatus;

        //sorted list that takes in the username as the key and the games as a value (could use a tuple for the value to store multiple values in)
        //of if there was an easier way of doing it not too sure 
        public SortedList<string, string> gameNames = new SortedList<string, string>();
        //username is key and the time is the value (could also use the tuple approach for the value so we could store multiple things in one value)
        public SortedList<string, int> times = new SortedList<string, int>();
        //username is key and the rank is the value(could also use the tuple approach for the value so we could store multiple things in one value)
        public SortedList<string, int> rank = new SortedList<string, int>();
        //each user (key) has an associated photopath which is the value
        public SortedList<string, string> profilePhotos = new SortedList<string, string>();


        // Constructor
        public User(string username, string bioLabel, bool onlineStatus, SortedList<string,string> gameNames, SortedList<string, int> times, SortedList<string, int> rank, SortedList<string, string> profilePhotos)
        {
            this.username = username;
            this.bioLabel = bioLabel;
            this.onlineStatus = onlineStatus;
            this.gameNames = gameNames;
            this.times = times;
            this.rank = rank;
            this.profilePhotos = profilePhotos;
        }

        //implement each list in UserDataBase file we will create and populate the userList defined in Players based on the username as the key
        //and the User object as the value 


        //was not too sure if we wanted a comparison here either but kept it just in case 
        //public static bool operator <(Student s1, Student s2)
        //{
        //    return (s1.gpa < s2.gpa);
        //}
        //
        //public static bool operator <=(Student s1, Student s2)
        //{
        //    return (s1.gpa <= s2.gpa);
        //}
        //
        //public static bool operator >(Student s1, Student s2)
        //{
        //    return (s1.gpa > s2.gpa);
        //}
        //
        //public static bool operator >=(Student s1, Student s2)
        //{
        //    return (s1.gpa >= s2.gpa);
        //}
        //
        //public static bool operator ==(Student s1, Student s2)
        //{
        //    return (s1.gpa == s2.gpa);
        //}
        //
        //public static bool operator !=(Student s1, Student s2)
        //{
        //    return (s1.gpa != s2.gpa);
        //}
    }

    // [+People|sortedList:SortedList<string, Person>|this:email|+Remove(email: string)]
    public class Players //did players here instead of users so it would not be confusing 
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
                    // duplicate key handling
                }
            }
        }


        public static void Main()
        {
            Players.userList.Add("ses011", new User("ses011", "nope. just nope", false));
            Players.userList.Add("kash_registerr", new User("kash_registerr", "", false));
            Players.userList.Add("catast0phi", new User("catast0phi", "oh boy!!! VIOLENCE for christmas!!!!!!", false));
            Players.userList.Add("goooobr", new User("gooobr", ":3", false));
            Players.userList.Add("anonygoose", new User("anonygoose", "your local fisherman dad", false));
            Players.userList.Add(".grbe", new User(".grbe", "", false));
            Players.userList.Add("not_phoeniix", new User("not_phoeniix", "they call me the Grinch\nthey call me\nthey call me the\nthey\nGrinch", false));
        }
    }
}