using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanderVictorAssgt
{//Sander Fabian C3418982 & Victor Chua Jia Zhi C3418248
    public partial class PVP : Form
    {
        string player1 , player2; // creating variables for player 1 and player 2
        int score; // creating variables for scores
        
        public PVP()
        {
            InitializeComponent();
        }

        private void PVP_Load(object sender, EventArgs e)
        {
           
            FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void bBack_Click(object sender, EventArgs e) // return to previous page ( form start )
        {
            FormStart start = new FormStart();
            start.Show();
            this.Hide();
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            player1 = player1Input.Text; // storing player1 name
            player2 = player2Input.Text; // storing player 2 name
            score = Convert.ToInt32(scoreInput.Text); // storing of score given by the users
            if (score < 50 || score > 100) // to check if the score is between 50-100
            {
                MessageBox.Show("Score should be within the range of 50-100.");
            }
            else
            {
                PVPGame game = new PVPGame(player1, player2, score, 0, 0); // start PVP game
                game.Show();
                this.Hide();
            }
        }


    }
}
