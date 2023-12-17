using PlayerInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matchups
{
    public partial class MatchupForm : Form
    {
        public MatchupForm()
        {
            InitializeComponent();


            label1.Text = PlayerInfo.Players.userList.Count.ToString();
        }
    }
}
