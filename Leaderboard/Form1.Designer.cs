namespace Leaderboard
{
    partial class Board
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
            this.leaderboard = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.gameGroupBox = new System.Windows.Forms.GroupBox();
            this.gameRadioButton6 = new System.Windows.Forms.RadioButton();
            this.gameRadioButton5 = new System.Windows.Forms.RadioButton();
            this.gameRadioButton4 = new System.Windows.Forms.RadioButton();
            this.gameRadioButton3 = new System.Windows.Forms.RadioButton();
            this.gameRadioButton2 = new System.Windows.Forms.RadioButton();
            this.gameRadioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // leaderboard
            // 
            this.leaderboard.BackColor = System.Drawing.Color.White;
            this.leaderboard.GridLines = true;
            this.leaderboard.HideSelection = false;
            this.leaderboard.Location = new System.Drawing.Point(56, 192);
            this.leaderboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.leaderboard.Name = "leaderboard";
            this.leaderboard.Size = new System.Drawing.Size(690, 436);
            this.leaderboard.TabIndex = 1;
            this.leaderboard.UseCompatibleStateImageBehavior = false;
            this.leaderboard.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(118, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Leaderboard for Sons of the Forest";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameGroupBox
            // 
            this.gameGroupBox.Controls.Add(this.gameRadioButton6);
            this.gameGroupBox.Controls.Add(this.gameRadioButton5);
            this.gameGroupBox.Controls.Add(this.gameRadioButton4);
            this.gameGroupBox.Controls.Add(this.gameRadioButton3);
            this.gameGroupBox.Controls.Add(this.gameRadioButton2);
            this.gameGroupBox.Controls.Add(this.gameRadioButton1);
            this.gameGroupBox.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gameGroupBox.Location = new System.Drawing.Point(812, 272);
            this.gameGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gameGroupBox.Name = "gameGroupBox";
            this.gameGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gameGroupBox.Size = new System.Drawing.Size(300, 268);
            this.gameGroupBox.TabIndex = 3;
            this.gameGroupBox.TabStop = false;
            this.gameGroupBox.Text = "Game";
            // 
            // gameRadioButton6
            // 
            this.gameRadioButton6.AutoSize = true;
            this.gameRadioButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gameRadioButton6.Location = new System.Drawing.Point(27, 215);
            this.gameRadioButton6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gameRadioButton6.Name = "gameRadioButton6";
            this.gameRadioButton6.Size = new System.Drawing.Size(101, 27);
            this.gameRadioButton6.TabIndex = 5;
            this.gameRadioButton6.TabStop = true;
            this.gameRadioButton6.Text = "VRChat";
            this.gameRadioButton6.UseVisualStyleBackColor = true;
            // 
            // gameRadioButton5
            // 
            this.gameRadioButton5.AutoSize = true;
            this.gameRadioButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gameRadioButton5.Location = new System.Drawing.Point(27, 180);
            this.gameRadioButton5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gameRadioButton5.Name = "gameRadioButton5";
            this.gameRadioButton5.Size = new System.Drawing.Size(96, 27);
            this.gameRadioButton5.TabIndex = 4;
            this.gameRadioButton5.TabStop = true;
            this.gameRadioButton5.Text = "Roblox";
            this.gameRadioButton5.UseVisualStyleBackColor = true;
            // 
            // gameRadioButton4
            // 
            this.gameRadioButton4.AutoSize = true;
            this.gameRadioButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gameRadioButton4.Location = new System.Drawing.Point(27, 145);
            this.gameRadioButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gameRadioButton4.Name = "gameRadioButton4";
            this.gameRadioButton4.Size = new System.Drawing.Size(166, 27);
            this.gameRadioButton4.TabIndex = 3;
            this.gameRadioButton4.TabStop = true;
            this.gameRadioButton4.Text = "Counter-Strike";
            this.gameRadioButton4.UseVisualStyleBackColor = true;
            // 
            // gameRadioButton3
            // 
            this.gameRadioButton3.AutoSize = true;
            this.gameRadioButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gameRadioButton3.Location = new System.Drawing.Point(27, 109);
            this.gameRadioButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gameRadioButton3.Name = "gameRadioButton3";
            this.gameRadioButton3.Size = new System.Drawing.Size(107, 27);
            this.gameRadioButton3.TabIndex = 2;
            this.gameRadioButton3.TabStop = true;
            this.gameRadioButton3.Text = "Valorant";
            this.gameRadioButton3.UseVisualStyleBackColor = true;
            // 
            // gameRadioButton2
            // 
            this.gameRadioButton2.AutoSize = true;
            this.gameRadioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gameRadioButton2.Location = new System.Drawing.Point(27, 74);
            this.gameRadioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gameRadioButton2.Name = "gameRadioButton2";
            this.gameRadioButton2.Size = new System.Drawing.Size(197, 27);
            this.gameRadioButton2.TabIndex = 1;
            this.gameRadioButton2.TabStop = true;
            this.gameRadioButton2.Text = "Rainbow Six Seige";
            this.gameRadioButton2.UseVisualStyleBackColor = true;
            // 
            // gameRadioButton1
            // 
            this.gameRadioButton1.AutoSize = true;
            this.gameRadioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gameRadioButton1.Location = new System.Drawing.Point(27, 38);
            this.gameRadioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gameRadioButton1.Name = "gameRadioButton1";
            this.gameRadioButton1.Size = new System.Drawing.Size(197, 27);
            this.gameRadioButton1.TabIndex = 0;
            this.gameRadioButton1.TabStop = true;
            this.gameRadioButton1.Text = "Sons of the Forest";
            this.gameRadioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(264, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sorting by Play Time";
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gameGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leaderboard);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Board";
            this.Text = "Form1";
            this.gameGroupBox.ResumeLayout(false);
            this.gameGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView leaderboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gameGroupBox;
        private System.Windows.Forms.RadioButton gameRadioButton3;
        private System.Windows.Forms.RadioButton gameRadioButton2;
        private System.Windows.Forms.RadioButton gameRadioButton1;
        private System.Windows.Forms.RadioButton gameRadioButton5;
        private System.Windows.Forms.RadioButton gameRadioButton4;
        private System.Windows.Forms.RadioButton gameRadioButton6;
        private System.Windows.Forms.Label label2;
    }
}

