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


    public partial class PVPGame : Form
    {
        int runningScorePlayer1, runningScorePlayer2, cumulativeScorePlayer1, cumulativeScorePlayer2, playerState = 1, turns = 0 ,p1,p2,die1,die2;
        //making a list using the class from the listholder.cs as the object in the list
        private List<ListHolder.TableContent> Table = new List<ListHolder.TableContent>();
        
        private Timer t = new Timer() // creating the timer for the dice roll
        {
            //this is how fast the dice will roll, it will always randomize 4 times so how fast those 4 times happens is changed here in ms
            Interval = 50
            
        };
        
        int counter= 0; // setting counter variable for animation purposes
        Random rndm = new Random(); // using C# random library and calling it 


        public PVPGame(string player1, string player2, int score, int p1,int p2)
        {
            InitializeComponent();

            player1Name.Text = player1; // importing names from start up pages and setting the display to those names
            player2Name.Text = player2; // importing names from start up pages and setting the display to those names
            scoreToBeatDisplay.Text = score.ToString(); // importing score from start up pages and setting the display to the score
            this.p1 = p1; // storing games won by players and setting the display to the games won
            this.p2 = p2; // storing games won by players and setting the display to the games won

            gamesWonDisplay.Text = p1.ToString() + " - " + p2.ToString(); // changing to string for display
            playerState = rndm.Next(1, 3);// randomizing the starting player values 1 for player 1 and 2 for player 2
            PlayerStateCheck(playerState);// player state check doubles as the color coder of the names to indicate the player playing
            
            bPass.Visible = false; //hiding pass button
            
        }

        private void bRoll_Click(object sender, EventArgs e)
        {
            
            bPass.Visible = true; // users able to see pass button
            t.Start();// to start the dice rolling and animation
            turns++;//increase the turns for storage purposes 
            
        }

        private void bPass_Click(object sender, EventArgs e)
        {
            if (turns != 0) 
            {

                passStatus(playerState);//change the player state and store the running score into the cumulative
                PlayerStateCheck(playerState);//change the color to indicate the player turn


                if (playerState == 2)
                {
                    commentsLabel.Text = " " + player1Name.Text + " decides to pass the dice";



                    //Since when clicking the button to roll again they will always add the " They Roll Again." i use this (.IndexOf) to detect if this statement occurs
                    int index = Table[turns - 1].comments.IndexOf(" They Roll Again.");
                    if (index != -1)
                    {
                        //Table[turns-1] is to get the member prior to this click meaning im modifying the previous member
                        //once the if statement confirms the statement occurs the (.Remove(index)) will remove the statement then i add the comment
                        Table[turns - 1].comments = Table[turns - 1].comments.Remove(index) + commentsLabel.Text;
                        //This is to retroactively add the cumulative score to the previous member of the array 
                        Table[turns - 1].cumScore = Table[turns - 1].runScore + Table[turns - 1].cumScore;
                    }
                    else
                    {

                    }



                }
                else
                {

                    //Same as above just for the other player so that it reflects the correct name and stores in the correct values
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

        private void PVPGame_Load(object sender, EventArgs e)
        {
            //Create a timer on form load 
            t.Tick += new System.EventHandler(diceAnimation_Tick);
            //Ensures the form isnt freely resizable
            FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void passStatus(int a)//Function that controls what happens after a player presses pass
        {
            if (a == 1) // checking for player state
            {
                cumulativeScorePlayer1 += runningScorePlayer1;//adding the running score to the cumulative score for player 1
                cumulativeScoreDisplay1.Text = cumulativeScorePlayer1.ToString();//displaying the new values
                runningScorePlayer1 = 0;//resetting the running score 
                runningScoreDisplay1.Text = runningScorePlayer1.ToString(); //displaying the new value
                
                playerState = 2;//changing the player state
            }
            else
            {
                //same as above but for the other player
                cumulativeScorePlayer2 += runningScorePlayer2;
                cumulativeScoreDisplay2.Text = cumulativeScorePlayer2.ToString();
                runningScorePlayer2 = 0;
                runningScoreDisplay2.Text = runningScorePlayer2.ToString();
                
                playerState = 1;//changing the player state 
            }
        }





        private ListHolder.TableContent GenerateTableContent( int key, string a, int b, int c, int d,int e, string f) // creating a user defined function to generate the list of data meant for the datagrid table and return the list
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
        private void CheckWinner(int concurrentScore,int totalScore,int winningScore,string playerName,int p1,int p2,int die1,int die2)
        {

            string winner = playerName; // storing the name for the finishing sheet.
            if (concurrentScore + totalScore >= winningScore)//checking the total values and ensuring its above or equal to the winning score 
            {


                if (playerState == 1){//checking player state
                    p1++;
                    turns++;
                    //adding the winning log into the final list to be sent into the scoresheet, it takes in the turns, the player name, the die rolls and the scores and adding a comment for the log 
                    this.Table.Add(GenerateTableContent(turns, player1Name.Text, die1, die2, concurrentScore, totalScore+concurrentScore, player1Name.Text + " rolled a " + die1.ToString() + " and a " + die2.ToString() + " and since the addition of " + concurrentScore.ToString() + " + " + totalScore.ToString() + " => " + winningScore.ToString() + ", they have won the game!"));
                    // starting the winning screen with the parameters require, the main thing to look at here is the second last argument which is the list called table meant for the data grid in the winning form. the last argument is meant to tell the winning screen which mode youre playing between PVP or PVAI so that it can use that to know which form to open again when you press play again.               
                    Results winningScreen = new Results(player1Name.Text, player2Name.Text, Convert.ToInt32(scoreToBeatDisplay.Text), winner, p1, p2, Table,1);
                    winningScreen.Show();//shows the winning screen
                    this.Hide();//hides this form
                }
                else
                {
                    //same as above but for player 2
                    p2++;
                    turns++;
                    this.Table.Add(GenerateTableContent(turns, player2Name.Text, die1, die2, concurrentScore, totalScore+concurrentScore, player2Name.Text + " rolled a " + die1.ToString()+" and a " +die2.ToString()+" and since the addition of " + concurrentScore.ToString()+ " + "+ totalScore.ToString() +" => "+winningScore.ToString()+ ", they have won the game!"));
                    Results winningScreen = new Results(player1Name.Text, player2Name.Text, Convert.ToInt32(scoreToBeatDisplay.Text), winner, p1, p2, Table,1);
                    winningScreen.Show();
                    
                    this.Hide();
                }



            



                
                
            }
            
        }

        //Just to change minor things like the color of the name
        private int PlayerStateCheck(int a)
        {
            switch(a){
                case 1:
                    player1Name.ForeColor = Color.Gold;
                    player2Name.ForeColor = Color.Black;
                    return 1;
                 
                
                case 2:
                    player2Name.ForeColor = Color.Gold;
                    player1Name.ForeColor = Color.Black;
                    return 2;
                    
                default:
                    return 1;
                    
            }
            

           
        }

        
        //This generates all of the comments and returns them so they can be used for the game commentary and for the table at the end
        private string Comments(int a, int b,int con1,int con2, int state)
        {
            string player1 = player1Name.Text;
            string player2 = player2Name.Text;
            string comment;
            if (state == 1) //player 1 comments
            {
                
                if (a == 1 || b == 1) // if player 1 rolled 1 
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
               
                return comment; // returning the comments
            }
            else // comments for player 2
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


        //This is to calculate the total and check for the snakeeyes or single 1 rolls 
        private void TallyScore(int a,int dice1,int dice2)
        {
            int diceSum = dice1 + dice2;
            if (a == 1) // player 1
            {
                
                if (dice1 == 1 || dice2 == 1) // if player 1 rolled 1 
                {
                    runningScorePlayer1 = 0; // restart its running score
                    runningScoreDisplay1.Text = runningScorePlayer1.ToString(); 
                     if (dice1 == 1 && dice2 == 1) // if player 1 rolled 1 for both dices
                    {
                        
                        runningScorePlayer1 = 0;
                        cumulativeScorePlayer1 = 0;
                        cumulativeScoreDisplay1.Text = cumulativeScorePlayer1.ToString();
                        runningScoreDisplay1.Text = runningScorePlayer1.ToString();
                    }

                    playerState = 2;
                }
                
                else // adding dice sum to running score
                {
                    runningScorePlayer1 += diceSum; // adding the running score 
                    runningScoreDisplay1.Text = runningScorePlayer1.ToString(); // displaying the running score
                    
                }
            }
            else // same as above but for player 2
            {
                if (dice1 == 1 || dice2 == 1)
                {
                    runningScorePlayer2 = 0;
                    runningScoreDisplay2.Text = runningScorePlayer2.ToString();
                    if (dice1 == 1 && dice2 == 1)
                    {
                        
                        runningScorePlayer2 = 0;
                        cumulativeScorePlayer2 = 0;
                        cumulativeScoreDisplay2.Text = cumulativeScorePlayer2.ToString();
                        runningScoreDisplay2.Text = runningScorePlayer2.ToString();
                        
                    }
                    playerState = 1;
                }
               
                else
                {
                    runningScorePlayer2 += diceSum;
                    runningScoreDisplay2.Text = runningScorePlayer2.ToString();

                }

            }
        }

 







        //This tick event handler now contains all the stuff i was putting in the roll dice button click. Now the button just starts the timer and it does the animation followed by all the actual processes
           void diceAnimation_Tick(object sender, EventArgs e)
        
            {

            if (counter >= 5) // when the counter = 5, it will stop the animation and resets the counter and store the all of the values. ( running score, cumulative scores and both dices ) and checks whether player has won and also generate a new member for the list 
            {
                counter = 0;

                TallyScore(PlayerStateCheck(playerState), die1, die2);
                CheckWinner(runningScorePlayer1, cumulativeScorePlayer1, Convert.ToInt32(scoreToBeatDisplay.Text), player1Name.Text, p1, p2, die1, die2);
                CheckWinner(runningScorePlayer2, cumulativeScorePlayer2, Convert.ToInt32(scoreToBeatDisplay.Text), player2Name.Text, p1, p2, die1, die2);
                commentsLabel.Text = Comments(die1, die2, runningScorePlayer1, runningScorePlayer2, playerState);
                if (playerState == 1) // for player1
                {
                    if (die1 == 1 || die2 == 1) {
                        Table.Add(GenerateTableContent(turns, player2Name.Text, die1, die2, runningScorePlayer1, cumulativeScorePlayer1, Comments(die1, die2, runningScorePlayer1, runningScorePlayer2, playerState) + " " + player1Name.Text + " is given the turn."));
                    }
                    else
                    {
                        Table.Add(GenerateTableContent(turns, player1Name.Text, die1, die2, runningScorePlayer1, cumulativeScorePlayer1, Comments(die1, die2, runningScorePlayer1, runningScorePlayer2, playerState) + " They Roll Again."));
                    }
                    

                }
                else // for player 2
                {
                    if (die1 == 1 || die2 == 1)
                    {
                        Table.Add(GenerateTableContent(turns, player1Name.Text, die1, die2, runningScorePlayer2, cumulativeScorePlayer2, Comments(die1, die2, runningScorePlayer1, runningScorePlayer2, playerState) +" " + player2Name.Text+ " is given the turn."));
                    }
                    else
                    {
                        Table.Add(GenerateTableContent(turns, player2Name.Text, die1, die2, runningScorePlayer2, cumulativeScorePlayer2, Comments(die1, die2, runningScorePlayer1, runningScorePlayer2, playerState) +  " They Roll Again."));
                    }
                    

                }
                
                bRoll.Enabled = true;
                bPass.Enabled = true;
                PlayerStateCheck(playerState);
                t.Stop();
                
            }
            else { // animation and the dice generation happens here. The reason there is a check for counter 4 is pause because we do not want to store all values that was animated. Only the values the dice stops on
                
                bRoll.Enabled = false;
                bPass.Enabled = false;
                
               
                int a = rndm.Next(1, 7); // dice 1 has a random value of 1-6
                int b = rndm.Next(1, 7); // dice 2 has a random value of 1-6


                switch (a) // using a switch case to change the picturebox images to reflect the values of the randomized dice and storing correct values into dices
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
