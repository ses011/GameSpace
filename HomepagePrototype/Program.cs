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
            Players.userList.Add("catast0phi", new User("catast0phi", "oh boy!!! VIOLENCE for christmas!!!!!!", false, "https://i.pinimg.com/originals/2d/45/05/2d4505705df8dc95c4dcd25d14c22cd0.jpg"));
            Players.userList.Add("gooobr", new User("gooobr", ":3", false, "https://i.pinimg.com/originals/a1/6b/a9/a16ba9957f841ff5f56fab5390a211ae.jpg"));
            Players.userList.Add("anonygoose", new User("anonygoose", "your local fisherman dad", false, "https://i.pinimg.com/564x/fe/b1/18/feb11807683359c6102bdd4e613bb037.jpg"));
            Players.userList.Add(".grbe", new User(".grbe", "", false, "https://i.pinimg.com/originals/aa/91/37/aa9137d78650403d094481d841a9cf21.jpg"));
            Players.userList.Add("not_phoeniix", new User("not_phoeniix", "they call me the Grinch\nthey call me\nthey call me the\nthey\nGrinch", false, "https://i.pinimg.com/originals/21/f7/08/21f7084857ead254deaafc8b48356420.jpg"));


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Homepage());
        }
    }
}
