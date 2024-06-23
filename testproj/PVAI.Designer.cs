
namespace SanderVictorAssgt
{
    partial class PVAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PVAI));
            this.bPlay = new System.Windows.Forms.Button();
            this.scoreInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.player1Input = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bPlay
            // 
            this.bPlay.BackColor = System.Drawing.Color.Black;
            this.bPlay.FlatAppearance.BorderSize = 2;
            this.bPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPlay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPlay.ForeColor = System.Drawing.Color.Gold;
            this.bPlay.Location = new System.Drawing.Point(155, 385);
            this.bPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(244, 84);
            this.bPlay.TabIndex = 12;
            this.bPlay.Text = "Play";
            this.bPlay.UseVisualStyleBackColor = false;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // scoreInput
            // 
            this.scoreInput.Location = new System.Drawing.Point(154, 324);
            this.scoreInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scoreInput.Name = "scoreInput";
            this.scoreInput.Size = new System.Drawing.Size(243, 22);
            this.scoreInput.TabIndex = 11;
            this.scoreInput.Text = "50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Score Limit (50-100)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Player 1:";
            // 
            // player1Input
            // 
            this.player1Input.Location = new System.Drawing.Point(155, 247);
            this.player1Input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player1Input.Name = "player1Input";
            this.player1Input.Size = new System.Drawing.Size(243, 22);
            this.player1Input.TabIndex = 8;
            this.player1Input.Text = "Fabian";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SanderVictorAssgt.Properties.Resources.Asset_1_1080x;
            this.pictureBox1.InitialImage = global::SanderVictorAssgt.Properties.Resources.Asset_1_1080x;
            this.pictureBox1.Location = new System.Drawing.Point(106, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // bBack
            // 
            this.bBack.BackgroundImage = global::SanderVictorAssgt.Properties.Resources.back_arrow;
            this.bBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBack.FlatAppearance.BorderSize = 2;
            this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack.Location = new System.Drawing.Point(12, 12);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(42, 42);
            this.bBack.TabIndex = 14;
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // PVAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 496);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bPlay);
            this.Controls.Add(this.scoreInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player1Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PVAI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Groan!";
            this.Load += new System.EventHandler(this.PVAI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.TextBox scoreInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox player1Input;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bBack;
    }
}