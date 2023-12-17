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


            int[] compat = new int[Players.userList.Count];
            for(int i = 0; i < compat.Length; i++)
            {
                compat[i] = 0;
            }

            label1.Text = compat[0].ToString();

        }

        private void homeLabel_Click(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {

        }

        private void previousButton_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
