namespace HomepagePrototype
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.label1 = new System.Windows.Forms.Label();
            this.matchButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ListUsers = new System.Windows.Forms.ListView();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.usernameLabel = new System.Windows.Forms.ToolStripLabel();
            this.matchLabel = new System.Windows.Forms.ToolStripLabel();
            this.leaderboardLabel = new System.Windows.Forms.ToolStripLabel();
            this.chatsLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.flowLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get started here";
            // 
            // matchButton
            // 
            this.matchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.matchButton.Font = new System.Drawing.Font("Yu Gothic UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchButton.Location = new System.Drawing.Point(104, 228);
            this.matchButton.Name = "matchButton";
            this.matchButton.Size = new System.Drawing.Size(392, 102);
            this.matchButton.TabIndex = 1;
            this.matchButton.TabStop = false;
            this.matchButton.Text = "MATCH!";
            this.matchButton.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flowLayoutPanel1.Controls.Add(this.ListUsers);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(660, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(253, 557);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ListUsers
            // 
            this.ListUsers.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListUsers.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ListUsers.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListUsers.HideSelection = false;
            this.ListUsers.Location = new System.Drawing.Point(3, 3);
            this.ListUsers.Name = "ListUsers";
            this.ListUsers.Size = new System.Drawing.Size(247, 541);
            this.ListUsers.TabIndex = 0;
            this.ListUsers.UseCompatibleStateImageBehavior = false;
            this.ListUsers.View = System.Windows.Forms.View.List;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 32);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.usernameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.IsLink = true;
            this.usernameLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.usernameLabel.LinkColor = System.Drawing.Color.Black;
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(86, 32);
            this.usernameLabel.Text = "ses011";
            // 
            // matchLabel
            // 
            this.matchLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchLabel.IsLink = true;
            this.matchLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.matchLabel.LinkColor = System.Drawing.Color.Black;
            this.matchLabel.Margin = new System.Windows.Forms.Padding(80, 2, 0, 3);
            this.matchLabel.Name = "matchLabel";
            this.matchLabel.Size = new System.Drawing.Size(88, 32);
            this.matchLabel.Text = "Match!";
            // 
            // leaderboardLabel
            // 
            this.leaderboardLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderboardLabel.IsLink = true;
            this.leaderboardLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.leaderboardLabel.LinkColor = System.Drawing.Color.Black;
            this.leaderboardLabel.Margin = new System.Windows.Forms.Padding(65, 2, 0, 3);
            this.leaderboardLabel.Name = "leaderboardLabel";
            this.leaderboardLabel.Size = new System.Drawing.Size(157, 32);
            this.leaderboardLabel.Text = "Leaderboards";
            // 
            // chatsLabel
            // 
            this.chatsLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatsLabel.IsLink = true;
            this.chatsLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.chatsLabel.LinkColor = System.Drawing.Color.Black;
            this.chatsLabel.Margin = new System.Windows.Forms.Padding(65, 2, 0, 3);
            this.chatsLabel.Name = "chatsLabel";
            this.chatsLabel.Size = new System.Drawing.Size(73, 32);
            this.chatsLabel.Text = "Chats";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.usernameLabel,
            this.matchLabel,
            this.leaderboardLabel,
            this.chatsLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(913, 37);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 596);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.matchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Homepage";
            this.Text = "GameSpace";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button matchButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListView ListUsers;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel usernameLabel;
        private System.Windows.Forms.ToolStripLabel matchLabel;
        private System.Windows.Forms.ToolStripLabel leaderboardLabel;
        private System.Windows.Forms.ToolStripLabel chatsLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

