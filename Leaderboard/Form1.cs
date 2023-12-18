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

namespace Leaderboard
{
    public partial class Form1 : Form
    {
        private bool isShuffled = false;
        private bool isShuffled2 = false;
        private bool isShuffled3 = false;
        private bool isShuffled4 = false;
        private bool isShuffled5 = false;
        private bool isShuffled6 = false;

        public Form1()
        {
            InitializeComponent();

            //game radio buttons
            this.gameRadioButton1.CheckedChanged += new EventHandler(this.gameRadioButton1__CheckedChanged);
            this.gameRadioButton2.CheckedChanged += new EventHandler(this.gameRadioButton2__CheckedChanged);
            this.gameRadioButton3.CheckedChanged += new EventHandler(this.gameRadioButton3__CheckedChanged);
            this.gameRadioButton4.CheckedChanged += new EventHandler(this.gameRadioButton4__CheckedChanged);
            this.gameRadioButton5.CheckedChanged += new EventHandler(this.gameRadioButton5__CheckedChanged);
            this.gameRadioButton6.CheckedChanged += new EventHandler(this.gameRadioButton6__CheckedChanged);


            leaderboard.View = View.Details;
            leaderboard.Columns.Add("Rank", 50); 
            leaderboard.Columns.Add("Username", 250); 
            leaderboard.Columns.Add("Playtime", 150); 

            string[] usernames = { "ses011", "kash_registerr", "catas0phi", "goooober", "anonygoose", ".grbe", "not_phoeniix" };
            Random random = new Random();

            for (int i = 0; i < usernames.Length; i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(usernames[i]);

                TimeSpan randomTime = new TimeSpan(0, random.Next(0, 60), random.Next(0, 60), random.Next(0, 60));
                item.SubItems.Add(randomTime.ToString(@"hh\:mm\:ss"));

                leaderboard.Items.Add(item);
            }


        }

        //code to randomly shuffle the usernames in the leaderboard
        private void ShuffleUsernames()
        {
            Random random = new Random();
            List<ListViewItem> shuffledItems = new List<ListViewItem>(leaderboard.Items.Cast<ListViewItem>());

            int n = shuffledItems.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);

                string tempUsername = shuffledItems[k].SubItems[1].Text;
                shuffledItems[k].SubItems[1].Text = shuffledItems[n].SubItems[1].Text;
                shuffledItems[n].SubItems[1].Text = tempUsername;

                //create random timespans using hours, minutes, and seconds to represent playtime
                TimeSpan randomTimeK = new TimeSpan(0, random.Next(0, 60), random.Next(0, 60), random.Next(0, 60));
                shuffledItems[k].SubItems[2].Text = randomTimeK.ToString(@"hh\:mm\:ss");

                TimeSpan randomTimeN = new TimeSpan(0, random.Next(0, 60), random.Next(0, 60), random.Next(0, 60));
                shuffledItems[n].SubItems[2].Text = randomTimeN.ToString(@"hh\:mm\:ss");
            }

            //clear the itms for new items
            leaderboard.Items.Clear();
            leaderboard.Items.AddRange(shuffledItems.ToArray());
        }



        private void gameRadioButton1__CheckedChanged(object sender, EventArgs e)
        {
            if (!isShuffled)
            {
                ShuffleUsernames();
            }

            this.label1.Text = "Leaderboard for Sons of the Forest";
        }

        private void gameRadioButton2__CheckedChanged(object sender, EventArgs e)
        {

            if (!isShuffled2)
            {
                ShuffleUsernames();

            }
            this.label1.Text = "Leaderboard for Rainbow Six Seige";
        }

        private void gameRadioButton3__CheckedChanged(object sender, EventArgs e)
        {
            if (!isShuffled3)
            {
                ShuffleUsernames();

            }

            this.label1.Text = "Leaderboard for Valorant";
        }

        private void gameRadioButton4__CheckedChanged(object sender, EventArgs e)
        {
            if (!isShuffled4)
            {
                ShuffleUsernames();

            }

            this.label1.Text = "Leaderboard for Counter-Strike";
        }

        private void gameRadioButton5__CheckedChanged(object sender, EventArgs e)
        {
            if (!isShuffled5)
            {
                ShuffleUsernames();

            }

            this.label1.Text = "Leaderboard for Roblox";
        }

        private void gameRadioButton6__CheckedChanged(object sender, EventArgs e)
        {
            if (!isShuffled6)
            {
                ShuffleUsernames();

            }

            this.label1.Text = "Leaderboard for VRChat";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
