
namespace SanderVictorAssgt
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.bPvai = new System.Windows.Forms.Button();
            this.bPvp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bPvai
            // 
            this.bPvai.BackColor = System.Drawing.Color.Black;
            this.bPvai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPvai.FlatAppearance.BorderSize = 2;
            this.bPvai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPvai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPvai.ForeColor = System.Drawing.Color.Gold;
            this.bPvai.Location = new System.Drawing.Point(156, 299);
            this.bPvai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bPvai.Name = "bPvai";
            this.bPvai.Size = new System.Drawing.Size(244, 84);
            this.bPvai.TabIndex = 8;
            this.bPvai.Text = "Player vs AI";
            this.bPvai.UseVisualStyleBackColor = false;
            this.bPvai.Click += new System.EventHandler(this.bPvai_Click);
            // 
            // bPvp
            // 
            this.bPvp.BackColor = System.Drawing.Color.Black;
            this.bPvp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPvp.FlatAppearance.BorderSize = 2;
            this.bPvp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPvp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPvp.ForeColor = System.Drawing.Color.Gold;
            this.bPvp.Location = new System.Drawing.Point(156, 202);
            this.bPvp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bPvp.Name = "bPvp";
            this.bPvp.Size = new System.Drawing.Size(244, 84);
            this.bPvp.TabIndex = 10;
            this.bPvp.Text = "Player vs Player";
            this.bPvp.UseVisualStyleBackColor = false;
            this.bPvp.Click += new System.EventHandler(this.bPvp_Click);
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
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Black;
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.FlatAppearance.BorderSize = 2;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.ForeColor = System.Drawing.Color.Gold;
            this.bExit.Location = new System.Drawing.Point(156, 397);
            this.bExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(244, 84);
            this.bExit.TabIndex = 12;
            this.bExit.Text = "Exit Game";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(568, 496);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bPvp);
            this.Controls.Add(this.bPvai);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Groan!";
            this.Load += new System.EventHandler(this.FormStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bPvai;
        private System.Windows.Forms.Button bPvp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bExit;
    }
}