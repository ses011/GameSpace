using PlayerInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomepagePrototype
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Players.userList.Add("ses011", new User("ses011", "nope. just nope", false));
            Players.userList.Add("kash_registerr", new User("kash_registerr", "", false));
            Players.userList.Add("catast0phi", new User("catast0phi", "oh boy!!! VIOLENCE for christmas!!!!!!", false));
            Players.userList.Add("goooobr", new User("gooobr", ":3", false));
            Players.userList.Add("anonygoose", new User("anonygoose", "your local fisherman dad", false));
            Players.userList.Add(".grbe", new User(".grbe", "", false));
            Players.userList.Add("not_phoeniix", new User("not_phoeniix", "they call me the Grinch\nthey call me\nthey call me the\nthey\nGrinch", false));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
