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
            Players.userList.Add("ses011", new User("ses011", "nope. just nope", false, "https://i.pinimg.com/564x/ef/3e/e1/ef3ee14feee15daddd90a0751597c97f.jpg"));
            Players.userList.Add("kash_registerr", new User("kash_registerr", "", false, "https://i.pinimg.com/originals/04/92/09/049209be806b75a21290058ea12160e7.jpg"));
            Players.userList.Add("catast0phi", new User("catast0phi", "oh boy!!! VIOLENCE for christmas!!!!!!", false, ""));
            Players.userList.Add("goooobr", new User("gooobr", ":3", false, ""));
            Players.userList.Add("anonygoose", new User("anonygoose", "your local fisherman dad", false, "https://i.pinimg.com/564x/fe/b1/18/feb11807683359c6102bdd4e613bb037.jpg"));
            Players.userList.Add(".grbe", new User(".grbe", "", false, ""));
            Players.userList.Add("not_phoeniix", new User("not_phoeniix", "they call me the Grinch\nthey call me\nthey call me the\nthey\nGrinch", false, ""));


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Homepage());
        }
    }
}
