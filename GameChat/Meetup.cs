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
        public Meetup(string name, string description, string place, string time, List<User> attending)
        {
            InitializeComponent();
            this.nameLabel.Text = name;
            this.descriptionLabel.Text = description;
            this.locationLabel.Text = place;
            this.timeLabel.Text = time;

            foreach (User user in attending)
            {
                this.attendingTextBox.Text += user.username + "\n";
            }
        }
    }
}
