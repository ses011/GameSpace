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

namespace GameChat
{
    public partial class Meetup : Form
    {
        private List<string> attending;
        public Meetup(string name, string description, string place, string time, List<string> attending)
        {
            InitializeComponent();
            this.nameLabel.Text = name;
            this.descriptionTextBox.Text = description;
            this.locationLabel.Text = place;
            this.timeLabel.Text = time;
            this.attending = attending;
            

            foreach (string user in attending)
            {
                this.attendingTextBox.Text += user + "\r\n";
            }
            this.interestCheckBox.CheckedChanged += new EventHandler(InterestCheckBox__CheckChanged);
        }

        private void InterestCheckBox__CheckChanged(object sender, EventArgs e)
        {
            if (this.interestCheckBox.Checked)
            {
                attending.Add("ses101");
                changeAttending();
            }
            else
            {
                if (attending.Contains("ses101"))
                {
                    attending.Remove("ses101");
                    changeAttending();
                }
            }
        }
        private void changeAttending()
        {
            this.attendingTextBox.Text = "";
            foreach (string user in attending)
            {
                this.attendingTextBox.Text += user + "\n";
            }
        }
    }
}
