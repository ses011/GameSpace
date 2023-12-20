namespace GameChat
{
    partial class Meetup
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.peopleLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.interestCheckBox = new System.Windows.Forms.CheckBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.attendingTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nameLabel.Location = new System.Drawing.Point(185, 9);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(74, 32);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "event";
            // 
            // peopleLabel
            // 
            this.peopleLabel.AutoSize = true;
            this.peopleLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.peopleLabel.Location = new System.Drawing.Point(187, 225);
            this.peopleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.peopleLabel.Name = "peopleLabel";
            this.peopleLabel.Size = new System.Drawing.Size(132, 21);
            this.peopleLabel.TabIndex = 2;
            this.peopleLabel.Text = "People Attending:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.locationLabel.Location = new System.Drawing.Point(187, 153);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(65, 21);
            this.locationLabel.TabIndex = 4;
            this.locationLabel.Text = "location";
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // interestCheckBox
            // 
            this.interestCheckBox.AutoSize = true;
            this.interestCheckBox.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.interestCheckBox.Location = new System.Drawing.Point(187, 348);
            this.interestCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.interestCheckBox.Name = "interestCheckBox";
            this.interestCheckBox.Size = new System.Drawing.Size(124, 25);
            this.interestCheckBox.TabIndex = 5;
            this.interestCheckBox.Text = "I\'m Interested";
            this.interestCheckBox.UseVisualStyleBackColor = true;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.timeLabel.Location = new System.Drawing.Point(187, 183);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(41, 21);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "time";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // attendingTextBox
            // 
            this.attendingTextBox.BackColor = System.Drawing.Color.White;
            this.attendingTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.attendingTextBox.Location = new System.Drawing.Point(187, 250);
            this.attendingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.attendingTextBox.Multiline = true;
            this.attendingTextBox.Name = "attendingTextBox";
            this.attendingTextBox.ReadOnly = true;
            this.attendingTextBox.Size = new System.Drawing.Size(135, 78);
            this.attendingTextBox.TabIndex = 7;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.White;
            this.descriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.descriptionTextBox.Location = new System.Drawing.Point(187, 49);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(182, 100);
            this.descriptionTextBox.TabIndex = 8;
            // 
            // Meetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 421);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.attendingTextBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.interestCheckBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.peopleLabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Meetup";
            this.Text = "Meetup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label peopleLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.CheckBox interestCheckBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox attendingTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
    }
}