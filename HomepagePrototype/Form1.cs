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

namespace HomepagePrototype
{

    public static void Main()
    {
        PlayerInfo players = new PlayerInfo();
        userList.Add("ses011", new User("ses011", "nope. just nope", false));
        userList.Add("kash_registerr", new User("kash_registerr", "", false));
        userList.Add("catast0phi", new User("catast0phi", "oh boy!!! VIOLENCE for christmas!!!!!!", false));
        userList.Add("goooobr", new User("gooobr", ":3", false));
        userList.Add("anonygoose", new User("anonygoose", "your local fisherman dad", false));
        userList.Add(".grbe", new User(".grbe", "", false));
        userList.Add("not_phoeniix", new User("not_phoeniix", "they call me the Grinch\nthey call me\nthey call me the\nthey\nGrinch", false));
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            this.matchButton.Click += new EventHandler(MatchButton__Click);
        }

        public void MatchButton__Click(object sender, EventArgs e)
        {
            
        }
    }
}
