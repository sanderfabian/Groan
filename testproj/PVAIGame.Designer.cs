
namespace SanderVictorAssgt
{
    partial class PVAIGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PVAIGame));
            this.gamesWonDisplay = new System.Windows.Forms.Label();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dice2Display = new System.Windows.Forms.PictureBox();
            this.dice1Display = new System.Windows.Forms.PictureBox();
            this.runningScoreDisplayPlayer2 = new System.Windows.Forms.Label();
            this.runningScoreDisplayPlayer1 = new System.Windows.Forms.Label();
            this.bPass = new System.Windows.Forms.Button();
            this.bRoll = new System.Windows.Forms.Button();
            this.diceRollNumber2 = new System.Windows.Forms.TextBox();
            this.diceRollNumber1 = new System.Windows.Forms.TextBox();
            this.cumulativeScoreDisplayPlayer2 = new System.Windows.Forms.TextBox();
            this.scoreToBeatDisplay = new System.Windows.Forms.Label();
            this.cumulativeScoreDisplayPlayer1 = new System.Windows.Forms.TextBox();
            this.player2Name = new System.Windows.Forms.Label();
            this.player1Name = new System.Windows.Forms.Label();
            this.aiTimer = new System.Windows.Forms.Timer(this.components);
            this.trashTalk = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.aiMask = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dice2Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiMask)).BeginInit();
            this.SuspendLayout();
            // 
            // gamesWonDisplay
            // 
            this.gamesWonDisplay.BackColor = System.Drawing.Color.Transparent;
            this.gamesWonDisplay.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesWonDisplay.Location = new System.Drawing.Point(556, 210);
            this.gamesWonDisplay.Name = "gamesWonDisplay";
            this.gamesWonDisplay.Size = new System.Drawing.Size(133, 46);
            this.gamesWonDisplay.TabIndex = 31;
            this.gamesWonDisplay.Text = "0 - 0";
            this.gamesWonDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // commentsLabel
            // 
            this.commentsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.Location = new System.Drawing.Point(516, 357);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(215, 231);
            this.commentsLabel.TabIndex = 30;
            this.commentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(595, 256);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 28);
            this.label6.TabIndex = 29;
            this.label6.Text = "Goal";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dice2Display
            // 
            this.dice2Display.Location = new System.Drawing.Point(747, 327);
            this.dice2Display.Margin = new System.Windows.Forms.Padding(4);
            this.dice2Display.Name = "dice2Display";
            this.dice2Display.Size = new System.Drawing.Size(200, 200);
            this.dice2Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dice2Display.TabIndex = 28;
            this.dice2Display.TabStop = false;
            // 
            // dice1Display
            // 
            this.dice1Display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dice1Display.Cursor = System.Windows.Forms.Cursors.Default;
            this.dice1Display.Location = new System.Drawing.Point(299, 327);
            this.dice1Display.Margin = new System.Windows.Forms.Padding(4);
            this.dice1Display.Name = "dice1Display";
            this.dice1Display.Size = new System.Drawing.Size(200, 200);
            this.dice1Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dice1Display.TabIndex = 27;
            this.dice1Display.TabStop = false;
            // 
            // runningScoreDisplayPlayer2
            // 
            this.runningScoreDisplayPlayer2.AutoSize = true;
            this.runningScoreDisplayPlayer2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runningScoreDisplayPlayer2.Location = new System.Drawing.Point(1151, 295);
            this.runningScoreDisplayPlayer2.Name = "runningScoreDisplayPlayer2";
            this.runningScoreDisplayPlayer2.Size = new System.Drawing.Size(24, 28);
            this.runningScoreDisplayPlayer2.TabIndex = 26;
            this.runningScoreDisplayPlayer2.Text = "0";
            this.runningScoreDisplayPlayer2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // runningScoreDisplayPlayer1
            // 
            this.runningScoreDisplayPlayer1.AutoSize = true;
            this.runningScoreDisplayPlayer1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runningScoreDisplayPlayer1.Location = new System.Drawing.Point(35, 295);
            this.runningScoreDisplayPlayer1.Name = "runningScoreDisplayPlayer1";
            this.runningScoreDisplayPlayer1.Size = new System.Drawing.Size(24, 28);
            this.runningScoreDisplayPlayer1.TabIndex = 25;
            this.runningScoreDisplayPlayer1.Text = "0";
            // 
            // bPass
            // 
            this.bPass.BackColor = System.Drawing.Color.Black;
            this.bPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPass.ForeColor = System.Drawing.Color.Gold;
            this.bPass.Location = new System.Drawing.Point(747, 585);
            this.bPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bPass.Name = "bPass";
            this.bPass.Size = new System.Drawing.Size(200, 74);
            this.bPass.TabIndex = 24;
            this.bPass.Text = "Pass";
            this.bPass.UseVisualStyleBackColor = false;
            this.bPass.Click += new System.EventHandler(this.bPass_Click);
            // 
            // bRoll
            // 
            this.bRoll.BackColor = System.Drawing.Color.Black;
            this.bRoll.FlatAppearance.BorderSize = 2;
            this.bRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRoll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRoll.ForeColor = System.Drawing.Color.Gold;
            this.bRoll.Location = new System.Drawing.Point(299, 585);
            this.bRoll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bRoll.Name = "bRoll";
            this.bRoll.Size = new System.Drawing.Size(200, 74);
            this.bRoll.TabIndex = 23;
            this.bRoll.Text = "Roll Dice";
            this.bRoll.UseVisualStyleBackColor = false;
            this.bRoll.Click += new System.EventHandler(this.bRoll_Click);
            // 
            // diceRollNumber2
            // 
            this.diceRollNumber2.Enabled = false;
            this.diceRollNumber2.Location = new System.Drawing.Point(747, 544);
            this.diceRollNumber2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diceRollNumber2.Name = "diceRollNumber2";
            this.diceRollNumber2.Size = new System.Drawing.Size(200, 22);
            this.diceRollNumber2.TabIndex = 22;
            // 
            // diceRollNumber1
            // 
            this.diceRollNumber1.Enabled = false;
            this.diceRollNumber1.Location = new System.Drawing.Point(299, 544);
            this.diceRollNumber1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diceRollNumber1.Name = "diceRollNumber1";
            this.diceRollNumber1.Size = new System.Drawing.Size(200, 22);
            this.diceRollNumber1.TabIndex = 21;
            // 
            // cumulativeScoreDisplayPlayer2
            // 
            this.cumulativeScoreDisplayPlayer2.Enabled = false;
            this.cumulativeScoreDisplayPlayer2.Location = new System.Drawing.Point(990, 267);
            this.cumulativeScoreDisplayPlayer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cumulativeScoreDisplayPlayer2.Name = "cumulativeScoreDisplayPlayer2";
            this.cumulativeScoreDisplayPlayer2.Size = new System.Drawing.Size(185, 22);
            this.cumulativeScoreDisplayPlayer2.TabIndex = 20;
            this.cumulativeScoreDisplayPlayer2.Text = "0";
            // 
            // scoreToBeatDisplay
            // 
            this.scoreToBeatDisplay.BackColor = System.Drawing.Color.Transparent;
            this.scoreToBeatDisplay.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreToBeatDisplay.Location = new System.Drawing.Point(556, 295);
            this.scoreToBeatDisplay.Name = "scoreToBeatDisplay";
            this.scoreToBeatDisplay.Size = new System.Drawing.Size(133, 62);
            this.scoreToBeatDisplay.TabIndex = 19;
            this.scoreToBeatDisplay.Text = "0";
            this.scoreToBeatDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cumulativeScoreDisplayPlayer1
            // 
            this.cumulativeScoreDisplayPlayer1.Enabled = false;
            this.cumulativeScoreDisplayPlayer1.Location = new System.Drawing.Point(35, 267);
            this.cumulativeScoreDisplayPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cumulativeScoreDisplayPlayer1.Name = "cumulativeScoreDisplayPlayer1";
            this.cumulativeScoreDisplayPlayer1.Size = new System.Drawing.Size(185, 22);
            this.cumulativeScoreDisplayPlayer1.TabIndex = 18;
            this.cumulativeScoreDisplayPlayer1.Text = "0";
            // 
            // player2Name
            // 
            this.player2Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.player2Name.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Name.Location = new System.Drawing.Point(990, 235);
            this.player2Name.Name = "player2Name";
            this.player2Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.player2Name.Size = new System.Drawing.Size(185, 34);
            this.player2Name.TabIndex = 17;
            // 
            // player1Name
            // 
            this.player1Name.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Name.Location = new System.Drawing.Point(35, 235);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(185, 34);
            this.player1Name.TabIndex = 16;
            this.player1Name.Text = " ";
            // 
            // aiTimer
            // 
            this.aiTimer.Interval = 1000;
            this.aiTimer.Tick += new System.EventHandler(this.aiTimer_Tick);
            // 
            // trashTalk
            // 
            this.trashTalk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trashTalk.BackColor = System.Drawing.SystemColors.Control;
            this.trashTalk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trashTalk.Location = new System.Drawing.Point(747, 196);
            this.trashTalk.Name = "trashTalk";
            this.trashTalk.Padding = new System.Windows.Forms.Padding(10);
            this.trashTalk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trashTalk.Size = new System.Drawing.Size(341, 39);
            this.trashTalk.TabIndex = 32;
            this.trashTalk.Text = "trashTalk";
            this.trashTalk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.trashTalk.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SanderVictorAssgt.Properties.Resources.Asset_1_1080x;
            this.pictureBox3.InitialImage = global::SanderVictorAssgt.Properties.Resources.Asset_1_1080x;
            this.pictureBox3.Location = new System.Drawing.Point(446, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(347, 144);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // aiMask
            // 
            this.aiMask.Location = new System.Drawing.Point(266, 585);
            this.aiMask.Name = "aiMask";
            this.aiMask.Size = new System.Drawing.Size(743, 87);
            this.aiMask.TabIndex = 34;
            this.aiMask.TabStop = false;
            this.aiMask.Visible = false;
            // 
            // PVAIGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1222, 684);
            this.Controls.Add(this.aiMask);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.trashTalk);
            this.Controls.Add(this.gamesWonDisplay);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dice2Display);
            this.Controls.Add(this.dice1Display);
            this.Controls.Add(this.runningScoreDisplayPlayer2);
            this.Controls.Add(this.runningScoreDisplayPlayer1);
            this.Controls.Add(this.bPass);
            this.Controls.Add(this.bRoll);
            this.Controls.Add(this.diceRollNumber2);
            this.Controls.Add(this.diceRollNumber1);
            this.Controls.Add(this.cumulativeScoreDisplayPlayer2);
            this.Controls.Add(this.scoreToBeatDisplay);
            this.Controls.Add(this.cumulativeScoreDisplayPlayer1);
            this.Controls.Add(this.player2Name);
            this.Controls.Add(this.player1Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PVAIGame";
            this.Text = "Groan!";
            this.Load += new System.EventHandler(this.PVAIGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dice2Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiMask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gamesWonDisplay;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox dice2Display;
        private System.Windows.Forms.PictureBox dice1Display;
        private System.Windows.Forms.Label runningScoreDisplayPlayer2;
        private System.Windows.Forms.Label runningScoreDisplayPlayer1;
        private System.Windows.Forms.Button bPass;
        private System.Windows.Forms.Button bRoll;
        private System.Windows.Forms.TextBox diceRollNumber2;
        private System.Windows.Forms.TextBox diceRollNumber1;
        private System.Windows.Forms.TextBox cumulativeScoreDisplayPlayer2;
        private System.Windows.Forms.Label scoreToBeatDisplay;
        private System.Windows.Forms.TextBox cumulativeScoreDisplayPlayer1;
        private System.Windows.Forms.Label player2Name;
        private System.Windows.Forms.Label player1Name;
        private System.Windows.Forms.Timer aiTimer;
        private System.Windows.Forms.Label trashTalk;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox aiMask;
    }
}