using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayerInfo;
using Profile_Display;

namespace GameChat
{
  
    public partial class ChatForm : Form
    {
        private User recipient;
        private string filename;
        public ChatForm(User recipient)
        {
            InitializeComponent();
            string username = recipient.username;
            
            /*int order = username.CompareTo(recipient);
            if(order < 0)
            {
                //username_recipient
                this.filename = username + "_" + recipient + ".txt";
            }
            else if (order > 0)
            {
                //recipient_username
                this.filename = recipient + "_" + username + ".txt";
            }*/
            this.filename = recipient + ".txt";
            //messageRichTextBox.LoadFile(filename, RichTextBoxStreamType.RichText);


            this.sendButton.Click += new EventHandler(SendButton__Click);
        }

        private void SendButton__Click(object sender, EventArgs e)
        {
            string message = ": " + textBox.Text;
            messageRichTextBox.Text += message;

            /*using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(message.ToString());
            }*/
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
