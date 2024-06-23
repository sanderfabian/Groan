
namespace SanderVictorAssgt
{
    partial class PVPGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PVPGame));
            this.player1Name = new System.Windows.Forms.Label();
            this.player2Name = new System.Windows.Forms.Label();
            this.cumulativeScoreDisplay1 = new System.Windows.Forms.TextBox();
            this.scoreToBeatDisplay = new System.Windows.Forms.Label();
            this.cumulativeScoreDisplay2 = new System.Windows.Forms.TextBox();
            this.diceRollNumber1 = new System.Windows.Forms.TextBox();
            this.diceRollNumber2 = new System.Windows.Forms.TextBox();
            this.bRoll = new System.Windows.Forms.Button();
            this.bPass = new System.Windows.Forms.Button();
            this.runningScoreDisplay1 = new System.Windows.Forms.Label();
            this.runningScoreDisplay2 = new System.Windows.Forms.Label();
            this.dice1Display = new System.Windows.Forms.PictureBox();
            this.dice2Display = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.gamesWonDisplay = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dice1Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // player1Name
            // 
            this.player1Name.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Name.Location = new System.Drawing.Point(42, 199);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(185, 34);
            this.player1Name.TabIndex = 0;
            this.player1Name.Text = " ";
            // 
            // player2Name
            // 
            this.player2Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.player2Name.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Name.Location = new System.Drawing.Point(997, 199);
            this.player2Name.Name = "player2Name";
            this.player2Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.player2Name.Size = new System.Drawing.Size(185, 34);
            this.player2Name.TabIndex = 1;
            // 
            // cumulativeScoreDisplay1
            // 
            this.cumulativeScoreDisplay1.Enabled = false;
            this.cumulativeScoreDisplay1.Location = new System.Drawing.Point(42, 231);
            this.cumulativeScoreDisplay1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cumulativeScoreDisplay1.Name = "cumulativeScoreDisplay1";
            this.cumulativeScoreDisplay1.Size = new System.Drawing.Size(185, 22);
            this.cumulativeScoreDisplay1.TabIndex = 2;
            this.cumulativeScoreDisplay1.Text = "0";
            // 
            // scoreToBeatDisplay
            // 
            this.scoreToBeatDisplay.BackColor = System.Drawing.Color.Transparent;
            this.scoreToBeatDisplay.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreToBeatDisplay.Location = new System.Drawing.Point(563, 259);
            this.scoreToBeatDisplay.Name = "scoreToBeatDisplay";
            this.scoreToBeatDisplay.Size = new System.Drawing.Size(133, 62);
            this.scoreToBeatDisplay.TabIndex = 3;
            this.scoreToBeatDisplay.Text = "0";
            this.scoreToBeatDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cumulativeScoreDisplay2
            // 
            this.cumulativeScoreDisplay2.Enabled = false;
            this.cumulativeScoreDisplay2.Location = new System.Drawing.Point(997, 231);
            this.cumulativeScoreDisplay2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cumulativeScoreDisplay2.Name = "cumulativeScoreDisplay2";
            this.cumulativeScoreDisplay2.Size = new System.Drawing.Size(185, 22);
            this.cumulativeScoreDisplay2.TabIndex = 4;
            this.cumulativeScoreDisplay2.Text = "0";
            // 
            // diceRollNumber1
            // 
            this.diceRollNumber1.Enabled = false;
            this.diceRollNumber1.Location = new System.Drawing.Point(306, 508);
            this.diceRollNumber1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diceRollNumber1.Name = "diceRollNumber1";
            this.diceRollNumber1.Size = new System.Drawing.Size(200, 22);
            this.diceRollNumber1.TabIndex = 5;
            // 
            // diceRollNumber2
            // 
            this.diceRollNumber2.Enabled = false;
            this.diceRollNumber2.Location = new System.Drawing.Point(754, 508);
            this.diceRollNumber2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diceRollNumber2.Name = "diceRollNumber2";
            this.diceRollNumber2.Size = new System.Drawing.Size(200, 22);
            this.diceRollNumber2.TabIndex = 6;
            // 
            // bRoll
            // 
            this.bRoll.BackColor = System.Drawing.Color.Black;
            this.bRoll.FlatAppearance.BorderSize = 2;
            this.bRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRoll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRoll.ForeColor = System.Drawing.Color.Gold;
            this.bRoll.Location = new System.Drawing.Point(306, 549);
            this.bRoll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bRoll.Name = "bRoll";
            this.bRoll.Size = new System.Drawing.Size(200, 74);
            this.bRoll.TabIndex = 7;
            this.bRoll.Text = "Roll Dice";
            this.bRoll.UseVisualStyleBackColor = false;
            this.bRoll.Click += new System.EventHandler(this.bRoll_Click);
            // 
            // bPass
            // 
            this.bPass.BackColor = System.Drawing.Color.Black;
            this.bPass.FlatAppearance.BorderSize = 2;
            this.bPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPass.ForeColor = System.Drawing.Color.Gold;
            this.bPass.Location = new System.Drawing.Point(754, 549);
            this.bPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bPass.Name = "bPass";
            this.bPass.Size = new System.Drawing.Size(200, 74);
            this.bPass.TabIndex = 8;
            this.bPass.Text = "Pass";
            this.bPass.UseVisualStyleBackColor = false;
            this.bPass.Click += new System.EventHandler(this.bPass_Click);
            // 
            // runningScoreDisplay1
            // 
            this.runningScoreDisplay1.AutoSize = true;
            this.runningScoreDisplay1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runningScoreDisplay1.Location = new System.Drawing.Point(42, 259);
            this.runningScoreDisplay1.Name = "runningScoreDisplay1";
            this.runningScoreDisplay1.Size = new System.Drawing.Size(24, 28);
            this.runningScoreDisplay1.TabIndex = 9;
            this.runningScoreDisplay1.Text = "0";
            // 
            // runningScoreDisplay2
            // 
            this.runningScoreDisplay2.AutoSize = true;
            this.runningScoreDisplay2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runningScoreDisplay2.Location = new System.Drawing.Point(1158, 259);
            this.runningScoreDisplay2.Name = "runningScoreDisplay2";
            this.runningScoreDisplay2.Size = new System.Drawing.Size(24, 28);
            this.runningScoreDisplay2.TabIndex = 10;
            this.runningScoreDisplay2.Text = "0";
            this.runningScoreDisplay2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dice1Display
            // 
            this.dice1Display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dice1Display.Cursor = System.Windows.Forms.Cursors.Default;
            this.dice1Display.Location = new System.Drawing.Point(306, 291);
            this.dice1Display.Margin = new System.Windows.Forms.Padding(4);
            this.dice1Display.Name = "dice1Display";
            this.dice1Display.Size = new System.Drawing.Size(200, 200);
            this.dice1Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dice1Display.TabIndex = 11;
            this.dice1Display.TabStop = false;
            // 
            // dice2Display
            // 
            this.dice2Display.Location = new System.Drawing.Point(754, 291);
            this.dice2Display.Margin = new System.Windows.Forms.Padding(4);
            this.dice2Display.Name = "dice2Display";
            this.dice2Display.Size = new System.Drawing.Size(200, 200);
            this.dice2Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dice2Display.TabIndex = 12;
            this.dice2Display.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(602, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Goal";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // commentsLabel
            // 
            this.commentsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.Location = new System.Drawing.Point(523, 321);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(215, 231);
            this.commentsLabel.TabIndex = 14;
            this.commentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gamesWonDisplay
            // 
            this.gamesWonDisplay.BackColor = System.Drawing.Color.Transparent;
            this.gamesWonDisplay.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesWonDisplay.Location = new System.Drawing.Point(563, 174);
            this.gamesWonDisplay.Name = "gamesWonDisplay";
            this.gamesWonDisplay.Size = new System.Drawing.Size(133, 46);
            this.gamesWonDisplay.TabIndex = 15;
            this.gamesWonDisplay.Text = "0 - 0";
            this.gamesWonDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SanderVictorAssgt.Properties.Resources.Asset_1_1080x;
            this.pictureBox1.InitialImage = global::SanderVictorAssgt.Properties.Resources.Asset_1_1080x;
            this.pictureBox1.Location = new System.Drawing.Point(448, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // PVPGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1222, 684);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gamesWonDisplay);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dice2Display);
            this.Controls.Add(this.dice1Display);
            this.Controls.Add(this.runningScoreDisplay2);
            this.Controls.Add(this.runningScoreDisplay1);
            this.Controls.Add(this.bPass);
            this.Controls.Add(this.bRoll);
            this.Controls.Add(this.diceRollNumber2);
            this.Controls.Add(this.diceRollNumber1);
            this.Controls.Add(this.cumulativeScoreDisplay2);
            this.Controls.Add(this.scoreToBeatDisplay);
            this.Controls.Add(this.cumulativeScoreDisplay1);
            this.Controls.Add(this.player2Name);
            this.Controls.Add(this.player1Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PVPGame";
            this.RightToLeftLayout = true;
            this.Text = "Groan!";
            this.Load += new System.EventHandler(this.PVPGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dice1Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1Name;
        private System.Windows.Forms.Label player2Name;
        private System.Windows.Forms.TextBox cumulativeScoreDisplay1;
        private System.Windows.Forms.Label scoreToBeatDisplay;
        private System.Windows.Forms.TextBox cumulativeScoreDisplay2;
        private System.Windows.Forms.TextBox diceRollNumber1;
        private System.Windows.Forms.TextBox diceRollNumber2;
        private System.Windows.Forms.Button bRoll;
        private System.Windows.Forms.Button bPass;
        private System.Windows.Forms.Label runningScoreDisplay1;
        private System.Windows.Forms.Label runningScoreDisplay2;
        private System.Windows.Forms.PictureBox dice1Display;
        private System.Windows.Forms.PictureBox dice2Display;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.Label gamesWonDisplay;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}