namespace Leaderboard
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.overallButton = new System.Windows.Forms.RadioButton();
            this.timeButton = new System.Windows.Forms.RadioButton();
            this.scoreButton = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.gameGroupBox = new System.Windows.Forms.GroupBox();
            this.gameRadioButton3 = new System.Windows.Forms.RadioButton();
            this.gameRadioButton2 = new System.Windows.Forms.RadioButton();
            this.gameRadioButton1 = new System.Windows.Forms.RadioButton();
            this.gameRadioButton4 = new System.Windows.Forms.RadioButton();
            this.gameRadioButton5 = new System.Windows.Forms.RadioButton();
            this.gameRadioButton6 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scoreButton);
            this.groupBox1.Controls.Add(this.timeButton);
            this.groupBox1.Controls.Add(this.overallButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(542, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // overallButton
            // 
            this.overallButton.AutoSize = true;
            this.overallButton.Location = new System.Drawing.Point(18, 29);
            this.overallButton.Name = "overallButton";
            this.overallButton.Size = new System.Drawing.Size(99, 17);
            this.overallButton.TabIndex = 0;
            this.overallButton.TabStop = true;
            this.overallButton.Text = "Overall Rank";
            this.overallButton.UseVisualStyleBackColor = true;
            // 
            // timeButton
            // 
            this.timeButton.AutoSize = true;
            this.timeButton.Location = new System.Drawing.Point(18, 62);
            this.timeButton.Name = "timeButton";
            this.timeButton.Size = new System.Drawing.Size(52, 17);
            this.timeButton.TabIndex = 1;
            this.timeButton.TabStop = true;
            this.timeButton.Text = "Time";
            this.timeButton.UseVisualStyleBackColor = true;
            // 
            // scoreButton
            // 
            this.scoreButton.AutoSize = true;
            this.scoreButton.Location = new System.Drawing.Point(18, 97);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(58, 17);
            this.scoreButton.TabIndex = 2;
            this.scoreButton.TabStop = true;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Rank,
            this.Username,
            this.Value});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(37, 125);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(461, 285);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Rank
            // 
            this.Rank.Text = "Rank";
            this.Rank.Width = 90;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 200;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Leaderboard for Sons of the Forest";
            // 
            // gameGroupBox
            // 
            this.gameGroupBox.Controls.Add(this.gameRadioButton6);
            this.gameGroupBox.Controls.Add(this.gameRadioButton5);
            this.gameGroupBox.Controls.Add(this.gameRadioButton4);
            this.gameGroupBox.Controls.Add(this.gameRadioButton3);
            this.gameGroupBox.Controls.Add(this.gameRadioButton2);
            this.gameGroupBox.Controls.Add(this.gameRadioButton1);
            this.gameGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameGroupBox.Location = new System.Drawing.Point(542, 253);
            this.gameGroupBox.Name = "gameGroupBox";
            this.gameGroupBox.Size = new System.Drawing.Size(200, 174);
            this.gameGroupBox.TabIndex = 3;
            this.gameGroupBox.TabStop = false;
            this.gameGroupBox.Text = "Game";
            // 
            // gameRadioButton3
            // 
            this.gameRadioButton3.AutoSize = true;
            this.gameRadioButton3.Location = new System.Drawing.Point(18, 71);
            this.gameRadioButton3.Name = "gameRadioButton3";
            this.gameRadioButton3.Size = new System.Drawing.Size(72, 17);
            this.gameRadioButton3.TabIndex = 2;
            this.gameRadioButton3.TabStop = true;
            this.gameRadioButton3.Text = "Valorant";
            this.gameRadioButton3.UseVisualStyleBackColor = true;
            // 
            // gameRadioButton2
            // 
            this.gameRadioButton2.AutoSize = true;
            this.gameRadioButton2.Location = new System.Drawing.Point(18, 48);
            this.gameRadioButton2.Name = "gameRadioButton2";
            this.gameRadioButton2.Size = new System.Drawing.Size(131, 17);
            this.gameRadioButton2.TabIndex = 1;
            this.gameRadioButton2.TabStop = true;
            this.gameRadioButton2.Text = "Rainbow Six Seige";
            this.gameRadioButton2.UseVisualStyleBackColor = true;
            // 
            // gameRadioButton1
            // 
            this.gameRadioButton1.AutoSize = true;
            this.gameRadioButton1.Location = new System.Drawing.Point(18, 25);
            this.gameRadioButton1.Name = "gameRadioButton1";
            this.gameRadioButton1.Size = new System.Drawing.Size(129, 17);
            this.gameRadioButton1.TabIndex = 0;
            this.gameRadioButton1.TabStop = true;
            this.gameRadioButton1.Text = "Sons of the Forest";
            this.gameRadioButton1.UseVisualStyleBackColor = true;
            // 
            // gameRadioButton4
            // 
            this.gameRadioButton4.AutoSize = true;
            this.gameRadioButton4.Location = new System.Drawing.Point(18, 94);
            this.gameRadioButton4.Name = "gameRadioButton4";
            this.gameRadioButton4.Size = new System.Drawing.Size(106, 17);
            this.gameRadioButton4.TabIndex = 3;
            this.gameRadioButton4.TabStop = true;
            this.gameRadioButton4.Text = "Counter-Strike";
            this.gameRadioButton4.UseVisualStyleBackColor = true;
            // 
            // gameRadioButton5
            // 
            this.gameRadioButton5.AutoSize = true;
            this.gameRadioButton5.Location = new System.Drawing.Point(18, 117);
            this.gameRadioButton5.Name = "gameRadioButton5";
            this.gameRadioButton5.Size = new System.Drawing.Size(64, 17);
            this.gameRadioButton5.TabIndex = 4;
            this.gameRadioButton5.TabStop = true;
            this.gameRadioButton5.Text = "Roblox";
            this.gameRadioButton5.UseVisualStyleBackColor = true;
            // 
            // gameRadioButton6
            // 
            this.gameRadioButton6.AutoSize = true;
            this.gameRadioButton6.Location = new System.Drawing.Point(18, 140);
            this.gameRadioButton6.Name = "gameRadioButton6";
            this.gameRadioButton6.Size = new System.Drawing.Size(68, 17);
            this.gameRadioButton6.TabIndex = 5;
            this.gameRadioButton6.TabStop = true;
            this.gameRadioButton6.Text = "VRChat";
            this.gameRadioButton6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sorting by Overall Rank";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gameGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gameGroupBox.ResumeLayout(false);
            this.gameGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton scoreButton;
        private System.Windows.Forms.RadioButton timeButton;
        private System.Windows.Forms.RadioButton overallButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Rank;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Value;
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

