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
    public partial class PVAI : Form 
    {
        string player1, player2;
        int score;
        string[] names = { "Bobby", "Amy", "Thomas", "Roger" }; // the array of AI names 
        Random rndm = new Random(); // using random library 

        private void bPlay_Click(object sender, EventArgs e)
        {
            player1 = player1Input.Text; // storing the names
            player2 = names[rndm.Next(0, 4)]; // to randomly generate AI names from the names array
            score = Convert.ToInt32(scoreInput.Text);
            if (score < 50 || score > 100) // making sure the score is between 50-100
            {
                MessageBox.Show("Score should be within the range of 50-100.");
            }
            else
            {
                PVAIGame game = new PVAIGame(player1, player2, score, 0, 0); // starting PVAI game
                game.Show();
                this.Hide();
            }
        }

        private void bBack_Click(object sender, EventArgs e) // to return to previous screen ( form start )
        {
            FormStart start = new FormStart();
            start.Show();
            this.Hide();
        }

        private void PVAI_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        public PVAI()
        {
            InitializeComponent();
        }
    }
}
