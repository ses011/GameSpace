namespace GameChat
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.messageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(0, 417);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(372, 22);
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sendButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sendButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(0, 394);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(372, 23);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            // 
            // messageRichTextBox
            // 
            this.messageRichTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageRichTextBox.Location = new System.Drawing.Point(0, 27);
            this.messageRichTextBox.Name = "messageRichTextBox";
            this.messageRichTextBox.ReadOnly = true;
            this.messageRichTextBox.Size = new System.Drawing.Size(373, 373);
            this.messageRichTextBox.TabIndex = 2;
            this.messageRichTextBox.Text = "";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(9, 7);
            this.userLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(42, 21);
            this.userLabel.TabIndex = 3;
            this.userLabel.Text = "User";
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 439);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.messageRichTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.textBox);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.RichTextBox messageRichTextBox;
        private System.Windows.Forms.Label userLabel;
    }
}