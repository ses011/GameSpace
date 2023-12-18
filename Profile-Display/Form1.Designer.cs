namespace Profile_Display
{
    partial class DisplayProfile
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
            this.photoGroupBox = new System.Windows.Forms.GroupBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.bioLabel = new System.Windows.Forms.Label();
            this.dmButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.photoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // photoGroupBox
            // 
            this.photoGroupBox.Controls.Add(this.photoPictureBox);
            this.photoGroupBox.Location = new System.Drawing.Point(10, 11);
            this.photoGroupBox.Name = "photoGroupBox";
            this.photoGroupBox.Size = new System.Drawing.Size(291, 259);
            this.photoGroupBox.TabIndex = 53;
            this.photoGroupBox.TabStop = false;
            this.photoGroupBox.Enter += new System.EventHandler(this.photoGroupBox_Enter);
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.Color.LightGray;
            this.photoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.photoPictureBox.Location = new System.Drawing.Point(3, 16);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(285, 240);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPictureBox.TabIndex = 0;
            this.photoPictureBox.TabStop = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Navy;
            this.usernameLabel.Location = new System.Drawing.Point(318, 27);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(170, 33);
            this.usernameLabel.TabIndex = 54;
            this.usernameLabel.Text = "usernameLabel";
            this.usernameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // bioLabel
            // 
            this.bioLabel.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bioLabel.ForeColor = System.Drawing.Color.Navy;
            this.bioLabel.Location = new System.Drawing.Point(317, 144);
            this.bioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bioLabel.Name = "bioLabel";
            this.bioLabel.Size = new System.Drawing.Size(283, 83);
            this.bioLabel.TabIndex = 55;
            this.bioLabel.Text = "bioLabel";
            // 
            // dmButton
            // 
            this.dmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dmButton.Font = new System.Drawing.Font("Yu Gothic UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmButton.Location = new System.Drawing.Point(321, 264);
            this.dmButton.Margin = new System.Windows.Forms.Padding(2);
            this.dmButton.Name = "dmButton";
            this.dmButton.Size = new System.Drawing.Size(285, 57);
            this.dmButton.TabIndex = 56;
            this.dmButton.Text = "Message";
            this.dmButton.UseVisualStyleBackColor = false;
            this.dmButton.Click += new System.EventHandler(this.dmButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Navy;
            this.statusLabel.Location = new System.Drawing.Point(506, 27);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(148, 33);
            this.statusLabel.TabIndex = 58;
            this.statusLabel.Text = "Status:";
            // 
            // DisplayProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(665, 353);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.dmButton);
            this.Controls.Add(this.bioLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.photoGroupBox);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DisplayProfile";
            this.Text = "DisplayProfile";
            this.Load += new System.EventHandler(this.DisplayProfile_Load);
            this.photoGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox photoGroupBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label bioLabel;
        private System.Windows.Forms.Button dmButton;
        private System.Windows.Forms.Label statusLabel;
    }
}

