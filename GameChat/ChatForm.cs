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
  
    public partial class ChatForm : Form
    {
        public class Message
        {
            private User user;
            private string message;
            public Message(User user, string message)
            {
                this.user = user;
                this.message = message;
            }

            public override string ToString()
            {
                return user.username + ": " + message + "\n";
            }

        }
        private User user;
        public ChatForm(User user)
        {
            InitializeComponent();
            this.sendButton.Click += new EventHandler(SendButton__Click);
        }

        private void SendButton__Click(object sender, EventArgs e)
        {
            Message message = new Message(user, textBox.Text);
            messageRichTextBox.Text += message.ToString();
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
