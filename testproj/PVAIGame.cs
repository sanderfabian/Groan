using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanderVictorAssgt
{//Sander Fabian C3418982 & Victor Chua Jia Zhi C3418248

    //PVAI and PVP are mostly similar with some key differences
    public partial class PVAIGame : Form
    {
        int runningScorePlayer1, runningScorePlayer2, cumulativeScorePlayer1, cumulativeScorePlayer2, playerState = 1, turns = 0, p1, p2, die1, die2,aiCurrent,aiTurns;
        //i make the table here  using the class from the listholder
        private List<ListHolder.TableContent> Table = new List<ListHolder.TableContent>();

        string[] trash = {"Aww man!", "Haha again!", "Im going for double 6s noob", "I will destroy you!", "Again!","You go ahead noob!", "Hey wake up, its your turn!", "Ill give you a chance to roll LOL!" };//an array of comments to be made by the AI

        private Timer g = new Timer()
        {
            //this is how fast the dice will roll, it will always randomize 4 times so how fast those 4 times happens is changed here in ms
            Interval = 50

        };

        int counter = 0;



        Random rndm = new Random();


        public PVAIGame(string player1, string player2, int score, int p1, int p2)
        {
            InitializeComponent();

            player1Name.Text = player1; // importing names from start up pages
            player2Name.Text = player2;
            scoreToBeatDisplay.Text = score.ToString();
            this.p1 = p1;
            this.p2 = p2;

            gamesWonDisplay.Text = p1.ToString() + " - " + p2.ToString();
            playerState = rndm.Next(1, 3); ;
            PlayerStateCheck(playerState);
            bPass.Enabled = false;
            bPass.Visible = false;

        }

        private void PVAIGame_Load(object sender, EventArgs e)
        {
            g.Tick += new System.EventHandler(diceAnimation_Tick);
            if (playerState == 2) // on load if it is the ai's turn the timer begins
            {
                aiMask.Visible = true;//to hide the buttons for no player accidental clicking while the ai is still able to click.
                aiCurrent = 0;
                aiTurns = rndm.Next(1, 4);// giving the ai turns from 1 to 3
                aiTimer.Start();

            }
            FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void bPass_Click(object sender, EventArgs e)
        {

            if (turns != 0)
            {

                passStatus(playerState);
                PlayerStateCheck(playerState);


                if (playerState == 2)
                {
                    commentsLabel.Text = " " + player1Name.Text + " decides to pass the dice";



                    //Since when clicking the button to roll again they will always add the " They Roll Again." i use this (.IndexOf) to detect if this statement occurs
                    int index = Table[turns - 1].comments.IndexOf(" They Roll Again.");
                    if (index != -1)
                    {
                        //Table[turns-1] is to get the member prior to this click meaning im modifying the previous member
                        //once the if statement confirms the statement occurs the (.Remove(index)) will remove the statement then i add label7* see line 402
                        Table[turns - 1].comments = Table[turns - 1].comments.Remove(index) + commentsLabel.Text;
                        //This is to retroactively add the cumulative score to the previous member of the array 
                        Table[turns - 1].cumScore = Table[turns - 1].runScore + Table[turns - 1].cumScore;

                    }
                    else
                    {

                    }
                    aiCurrent = 0;
                    aiTurns = rndm.Next(1,4);//setting the ai turns

                    aiTimer.Start();

                }
                else
                {

                    //Same shit as above just for the other player so that it reflects the correct name 
                    commentsLabel.Text = " " + player2Name.Text + " decides to pass the dice";
                    int index = Table[turns - 1].comments.IndexOf(" They Roll Again.");
                    if (index != -1)
                    {

                        Table[turns - 1].comments = Table[turns - 1].comments.Remove(index) + commentsLabel.Text;
                        Table[turns - 1].cumScore = Table[turns - 1].runScore + Table[turns - 1].cumScore;
                    }
                    else
                    {

                    }

                }
            }
            else
            {

            }
        }

        private void bRoll_Click(object sender, EventArgs e)
        {
            if (playerState == 1)
            {
                trashTalk.Visible = false;// hide the trash talk when it isnt the ai turn
            }
            bPass.Enabled = true;
            bPass.Visible = true;
            g.Start();
            turns++;


        }

        private void aiTimer_Tick(object sender, EventArgs e)// a different timer this is meant for the ai actions. The ai will stop pressing the button if it hits 1.
        {
            if (playerState == 1)
            {
                aiTimer.Stop();
            }
            else
            {
                if (aiCurrent >= aiTurns && die1 != 1 && die2 != 1)
                {
                    trashTalk.Text = trash[rndm.Next(5, 8)];//5 to 7 are all trashtalk  
                    bPass.PerformClick();// simulates a click by the ai
                    aiTimer.Stop();

                }
                else
                {


                    trashTalk.Visible = true;

                    trashTalk.Text = trash[rndm.Next(1, 5)];
                    bRoll.PerformClick();
                    aiCurrent++;
                    


                }
            }
            
        }

        private void passStatus(int a)
        {
            if (a == 1)
            {
                cumulativeScorePlayer1 += runningScorePlayer1;
                cumulativeScoreDisplayPlayer1.Text = cumulativeScorePlayer1.ToString();
                runningScorePlayer1 = 0;
                runningScoreDisplayPlayer1.Text = runningScorePlayer1.ToString();

                playerState = 2;
            }
            else
            {
                cumulativeScorePlayer2 += runningScorePlayer2;
                cumulativeScoreDisplayPlayer2.Text = cumulativeScorePlayer2.ToString();
                runningScorePlayer2 = 0;
                runningScoreDisplayPlayer2.Text = runningScorePlayer2.ToString();

                playerState = 1;
            }
        }




        private ListHolder.TableContent GenerateTableContent(int key, string a, int b, int c, int d, int e, string f)
        {
            ListHolder.TableContent t = new ListHolder.TableContent();
            t.key = key;
            t.activePlayer = a;
            t.die1 = b;
            t.die2 = c;
            t.runScore = d;
            t.cumScore = e;
            t.comments = f;

            return t;
        }



        //Checks the winner and opens the winning sheet
        private void CheckWinner(int concurrentScore, int totalScore, int winningScore, string playerName, int p1, int p2, int die1, int die2)
        {

            string winner = playerName;
            if (concurrentScore + totalScore >= winningScore)
            {


                if (playerState == 1)
                {
                    p1 = p1 + 1;
                    turns++;
                    this.Table.Add(GenerateTableContent(turns, player1Name.Text, die1, die2, concurrentScore, totalScore + concurrentScore, player1Name.Text + " rolled a " + die1.ToString() + " and a " + die2.ToString() + " and since the addition of " + concurrentScore.ToString() + " + " + totalScore.ToString() + " => " + winningScore.ToString() + ", they have won the game!"));
                    Results winningScreen = new Results(player1Name.Text, player2Name.Text, Convert.ToInt32(scoreToBeatDisplay.Text), winner, p1, p2, Table,2);
                    winningScreen.Show();
                    this.Hide();
                }
                else
                {
                    p2 = p2 + 1;
                    turns++;
                    this.Table.Add(GenerateTableContent(turns, player2Name.Text, die1, die2, concurrentScore, totalScore + concurrentScore, player2Name.Text + " rolled a " + die1.ToString() + " and a " + die2.ToString() + " and since the addition of " + concurrentScore.ToString() + " + " + totalScore.ToString() + " => " + winningScore.ToString() + ", they have won the game!"));
                    Results winningScreen = new Results(player1Name.Text, player2Name.Text, Convert.ToInt32(scoreToBeatDisplay.Text), winner, p1, p2, Table,2);
                    winningScreen.Show();

                    this.Hide();
                }









            }

        }

        //Just to change minor things like the color of the name for now, maybe later on i can add other things to make whose turn it is more obvious
        private int PlayerStateCheck(int a)
        {
            switch (a)
            {
                case 1:
                    player1Name.ForeColor = Color.Gold;
                    player2Name.ForeColor = Color.Black;
                    aiMask.Visible = false;
                    return 1;


                case 2:
                    player2Name.ForeColor = Color.Gold;
                    player1Name.ForeColor = Color.Black;
                    aiMask.Visible = true;

                    return 2;

                default:
                    return 1;

            }



        }


        //This generates all my comments and returns them so they can be used for the game commentary and for the table at the end
        private string Comments(int a, int b, int con1, int con2, int state)
        {
            string player1 = player1Name.Text;
            string player2 = player2Name.Text;
            string comment;
            if (state == 1)
            {

                if (a == 1 || b == 1)
                {

                    comment = player2.ToString() + " rolled  a 1 and loss his running score! The dice is Passed.";
                    if (a == 1 && b == 1)
                    {

                        comment = player2.ToString() + " rolled Snake eyes! and now has 0 points overall. The dice is passed.";
                    }
                }
                else
                {
                    comment = player1.ToString() + " rolled a " + a.ToString() + " and a " + b.ToString() + " and has a cumulative score of " + con1.ToString() + ".";
                }

                return comment;
            }
            else
            {

                if (a == 1 || b == 1)
                {

                    comment = player1.ToString() + " rolled  a 1 and loss his running score! The dice is passed.";
                    if (a == 1 && b == 1)
                    {

                        comment = player1.ToString() + " rolled Snake eyes! and now has 0 points overall. The dice is passed.";
                    }
                }
                else
                {
                    comment = player2.ToString() + " rolled a " + a.ToString() + " and a " + b.ToString() + " and has a cumulative score of " + con2.ToString() + ".";
                }


                return comment;
            }
        }



        //This is to calculate the total and check for the snake eyes or single 1 rolls 
        private void TallyScore(int a, int dice1, int dice2)
        {
            int diceSum = dice1 + dice2;
            if (a == 1)
            {

                if (dice1 == 1 || dice2 == 1)
                {
                    runningScorePlayer1 = 0;
                    runningScoreDisplayPlayer1.Text = runningScorePlayer1.ToString();
                    if (dice1 == 1 && dice2 == 1)
                    {

                        runningScorePlayer1 = 0;
                        cumulativeScorePlayer1 = 0;
                        cumulativeScoreDisplayPlayer1.Text = cumulativeScorePlayer1.ToString();
                        runningScoreDisplayPlayer1.Text = runningScorePlayer1.ToString();
                    }
                    playerState = 2;
                    aiCurrent = 0;
                    aiTurns = 3;

                    aiTimer.Start();
                    
                }

                else
                {
                    runningScorePlayer1 += diceSum;
                    runningScoreDisplayPlayer1.Text = runningScorePlayer1.ToString();

                }
            }
            else
            {
                if (dice1 == 1 || dice2 == 1)
                {
                    runningScorePlayer2 = 0;
                    runningScoreDisplayPlayer2.Text = runningScorePlayer2.ToString();
                    if (dice1 == 1 && dice2 == 1)
                    {

                        runningScorePlayer2 = 0;
                        cumulativeScorePlayer2 = 0;
                        cumulativeScoreDisplayPlayer2.Text = cumulativeScorePlayer2.ToString();
                        runningScoreDisplayPlayer2.Text = runningScorePlayer2.ToString();
                    }
                    playerState = 1;
                    aiTimer.Start();
                }

                else
                {
                    runningScorePlayer2 += diceSum;
                    runningScoreDisplayPlayer2.Text = runningScorePlayer2.ToString();

                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }






        //This tick event handler now contains all the stuff i was putting in the roll dice button click. Now the button just starts the timer and it does the animation followed by all the actual processes
        void diceAnimation_Tick(object sender, EventArgs e)

        {

            if (counter >= 5)
            {
                counter = 0;

                TallyScore(PlayerStateCheck(playerState), die1, die2);
                CheckWinner(runningScorePlayer1, cumulativeScorePlayer1, Convert.ToInt32(scoreToBeatDisplay.Text), player1Name.Text, p1, p2, die1, die2);
                CheckWinner(runningScorePlayer2, cumulativeScorePlayer2, Convert.ToInt32(scoreToBeatDisplay.Text), player2Name.Text, p1, p2, die1, die2);
                commentsLabel.Text = Comments(die1, die2, runningScorePlayer1, runningScorePlayer2, playerState);
                if (playerState == 1)
                {
                    if (die1 == 1 || die2 == 1)
                    {
                        Table.Add(GenerateTableContent(turns, player2Name.Text, die1, die2, runningScorePlayer1, cumulativeScorePlayer1, Comments(die1, die2, runningScorePlayer1, runningScorePlayer2, playerState) + " " + player1Name.Text + " is given the turn."));
                    }
                    else
                    {
                        Table.Add(GenerateTableContent(turns, player1Name.Text, die1, die2, runningScorePlayer1, cumulativeScorePlayer1, Comments(die1, die2, runningScorePlayer1, runningScorePlayer2, playerState) + " They Roll Again."));
                    }


                }
                else
                {
                    if (die1 == 1 || die2 == 1)
                    {
                        Table.Add(GenerateTableContent(turns, player1Name.Text, die1, die2, runningScorePlayer2, cumulativeScorePlayer2, Comments(die1, die2, runningScorePlayer1, runningScorePlayer2, playerState) + " " + player2Name.Text + " is given the turn."));
                    }
                    else
                    {
                        Table.Add(GenerateTableContent(turns, player2Name.Text, die1, die2, runningScorePlayer2, cumulativeScorePlayer2, Comments(die1, die2, runningScorePlayer1, runningScorePlayer2, playerState) + " They Roll Again."));
                    }


                }

                bRoll.Enabled = true;
                bPass.Enabled = true;
                PlayerStateCheck(playerState);
                g.Stop();

            }
            else
            {

                bRoll.Enabled = false;
                bPass.Enabled = false;


                int a = rndm.Next(1, 7);
                int b = rndm.Next(1, 7);


                switch (a)
                {
                    case 1:
                        dice1Display.Image = Properties.Resources.dice1;
                        if (counter == 4)
                        {
                            die1 = 1;
                            diceRollNumber1.Text = die1.ToString();

                        }

                        break;
                    case 2:
                        dice1Display.Image = Properties.Resources.dice2;
                        if (counter == 4)
                        {
                            die1 = 2;
                            diceRollNumber1.Text = die1.ToString();
                        }
                        break;
                    case 3:
                        dice1Display.Image = Properties.Resources.dice3;
                        if (counter == 4)
                        {
                            die1 = 3;
                            diceRollNumber1.Text = die1.ToString();
                        }
                        break;
                    case 4:
                        dice1Display.Image = Properties.Resources.dice4;
                        if (counter == 4)
                        {
                            die1 = 4;
                            diceRollNumber1.Text = die1.ToString();
                        }
                        break;
                    case 5:
                        dice1Display.Image = Properties.Resources.dice5;
                        if (counter == 4)
                        {
                            die1 = 5;
                            diceRollNumber1.Text = die1.ToString();
                        }
                        break;
                    case 6:
                        dice1Display.Image = Properties.Resources.dice6;
                        if (counter == 4)
                        {
                            die1 = 6;
                            diceRollNumber1.Text = die1.ToString();
                        }
                        break;

                }
                switch (b)
                {
                    case 1:
                        dice2Display.Image = Properties.Resources.dice1;
                        if (counter == 4)
                        {
                            die2 = 1;
                            diceRollNumber2.Text = die2.ToString();
                        }
                        break;
                    case 2:
                        dice2Display.Image = Properties.Resources.dice2;
                        if (counter == 4)
                        {
                            die2 = 2;
                            diceRollNumber2.Text = die2.ToString();
                        }
                        break;
                    case 3:
                        dice2Display.Image = Properties.Resources.dice3;
                        if (counter == 4)
                        {
                            die2 = 3;
                            diceRollNumber2.Text = die2.ToString();
                        }

                        break;
                    case 4:
                        dice2Display.Image = Properties.Resources.dice4;
                        if (counter == 4)
                        {
                            die2 = 4;
                            diceRollNumber2.Text = die2.ToString();
                        }
                        break;
                    case 5:
                        dice2Display.Image = Properties.Resources.dice5;
                        if (counter == 4)
                        {
                            die2 = 5;
                            diceRollNumber2.Text = die2.ToString();
                        }
                        break;
                    case 6:
                        dice2Display.Image = Properties.Resources.dice6;
                        if (counter == 4)
                        {
                            die2 = 6;
                            diceRollNumber2.Text = die2.ToString();
                        }

                        break;

                }

                counter++;

            }

        }



    }
}
