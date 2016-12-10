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

namespace SlotMachine
{
    public partial class SlotMachineForm : Form
    {
        // private values
        private int playerMoney = 1000;
        private int winnings = 0;
        private int jackpot = 5000;
        private float turn = 0.0f;
        private int playerBet = 10;
        private float winNumber = 0.0f;
        private float lossNumber = 0.0f;
        private string[] spinResult;
        private string fruits = "";
        private float winRatio = 0.0f;
        private float lossRatio = 0.0f;
        private int grapes = 0;
        private int bananas = 0;
        private int oranges = 0;
        private int cherries = 0;
        private int bars = 0;
        private int bells = 0;
        private int sevens = 0;
        private int blanks = 0;
        private int totalWinnings = 0;

        private Random random = new Random();

        public SlotMachineForm()
        {
            InitializeComponent();
        }


        // Event Handlers
        // **************
        private void SpinPictureBox_Click(object sender, EventArgs e)
        {

            if (playerMoney == 0)
            {
                if (MessageBox.Show("You ran out of Money! \nDo you want to play again?", "Out of Money!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    resetAll();
                    setPlayerStats();
                }
            }
            else if (playerBet > playerMoney)
            {
                MessageBox.Show("You don't have enough Money to place that bet.", "Insufficient Funds");
            }
            else if (playerBet < 0)
            {
                MessageBox.Show("All bets must be a positive $ amount.", "Incorrect Bet");
            }
            else if (playerBet <= playerMoney)
            {
                spinResult = Reels();
                // display Results on Reels
                DisplayResults(spinResult);
                determineWinnings();
                totalWinnings += winnings;
                turn++;
                setPlayerStats();
                winnings = 0;
            }
            else
            {
                MessageBox.Show("Please enter a valid bet amount");
            }
        }
        private void SlotMachineForm_Load(object sender, EventArgs e)
        {
            // set stock pictures for reel's 

            // set labels to dollar amounts
            setPlayerStats();
        }
        private void ResetPictureBox_Click(object sender, EventArgs e)
        {
            resetAll();
            setPlayerStats();
            resetFruitTally();
        }


        // Private Functions
        // *******************
        private void DisplayResults(string[] arr)
        {
            if (arr.Count()>0)
            {
                var first = arr[0].ToLower();
                var second = arr[1].ToLower();
                var third = arr[2].ToLower();

                Reel1PictureBox.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(first);
                Reel2PictureBox.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(second);
                Reel3PictureBox.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(third);
            }
        }
        /* Utility function to show Player Stats */
        private void setPlayerStats()
        {
            winRatio = winNumber / turn;
            lossRatio = lossNumber / turn;
            string stats = "";
            stats += ("Turn: " + turn + "\n");
            stats += ("Wins: " + winNumber + "\n");
            stats += ("Losses: " + lossNumber + "\n");
            stats += ("Win Ratio: " + (winRatio * 100) + "%\n");
            stats += ("Loss Ratio: " + (lossRatio * 100) + "%\n");

            JackpotLabel.Text = "$" + jackpot.ToString();
            TotalCreditsLabel.Text = "$" + playerMoney.ToString();
            BetLabel.Text = "$" + playerBet.ToString();
            WinnerPaidLabel.Text = "$" + totalWinnings.ToString();
        }
        /* Utility function to reset all fruit tallies*/
        private void resetFruitTally()
        {
            grapes = 0;
            bananas = 0;
            oranges = 0;
            cherries = 0;
            bars = 0;
            bells = 0;
            sevens = 0;
            blanks = 0;
        }
        /* Utility function to reset the player stats */
        private void resetAll()
        {
            playerMoney = 1000;
            winnings = 0;
            jackpot = 5000;
            turn = 0;
            playerBet = 10;
            winNumber = 0;
            lossNumber = 0;
            winRatio = 0.0f;
            totalWinnings = 0;
        }
        /* Check to see if the player won the jackpot */
        private void checkJackPot()
        {
            /* compare two random values */
            var jackPotTry = this.random.Next(51) + 1;
            var jackPotWin = this.random.Next(51) + 1;
            if (jackPotTry == jackPotWin)
            {
                MessageBox.Show("You Won the $" + jackpot + " Jackpot!!","Jackpot!!");
                winnings += jackpot;
                jackpot = 1000;
            }
        }
        /* Utility function to show a win message and increase player money */
        private void showWinMessage()
        {
            // check jackpot
            checkJackPot();
            // concat winnings 
            playerMoney += winnings;
            MessageBox.Show("You Won: $" + winnings, "Winner!");
            // reset the tally
            resetFruitTally();
        }
        /* Utility function to show a loss message and reduce player money */
        private void showLossMessage()
        {
            playerMoney -= playerBet;
            MessageBox.Show("You Lost!", "Loss!");
            resetFruitTally();
        }
        /* Utility function to check if a value falls within a range of bounds */
        private bool checkRange(int value, int lowerBounds, int upperBounds)
        {
            return (value >= lowerBounds && value <= upperBounds) ? true : false;
            
        }
        /* When this function is called it determines the betLine results.
        e.g. Bar - Orange - Banana */
        private string[] Reels()
        {
            string[] betLine = { " ", " ", " " };
            int[] outCome = { 0, 0, 0 };

            for (var spin = 0; spin < 3; spin++)
            {
                outCome[spin] = this.random.Next(65) + 1;

               if (checkRange(outCome[spin], 1, 27)) {  // 41.5% probability
                    betLine[spin] = "blank";
                    blanks++;
                    }
                else if (checkRange(outCome[spin], 28, 37)){ // 15.4% probability
                    betLine[spin] = "Grapes";
                    grapes++;
                }
                else if (checkRange(outCome[spin], 38, 46)){ // 13.8% probability
                    betLine[spin] = "Banana";
                    bananas++;
                }
                else if (checkRange(outCome[spin], 47, 54)){ // 12.3% probability
                    betLine[spin] = "Orange";
                    oranges++;
                }
                else if (checkRange(outCome[spin], 55, 59)){ //  7.7% probability
                    betLine[spin] = "Cherry";
                    cherries++;
                }
                else if (checkRange(outCome[spin], 60, 62)){ //  4.6% probability
                    betLine[spin] = "Bar";
                    bars++;
                }
                else if (checkRange(outCome[spin], 63, 64)){ //  3.1% probability
                    betLine[spin] = "Bell";
                    bells++;
                }
                else if (checkRange(outCome[spin], 65, 65)){ //  1.5% probability
                    betLine[spin] = "Seven";
                    sevens++;
                }

            }
            return betLine;
        }
        /* This function calculates the player's winnings, if any */
        private void determineWinnings()
        {
            if (blanks == 0)
            {
                if (grapes == 3)
                {
                    winnings =  playerBet * 10;
                }
                else if (bananas == 3)
                {
                    winnings =  playerBet * 20;
                }
                else if (oranges == 3)
                {
                    winnings =  playerBet * 30;
                }
                else if (cherries == 3)
                {
                    winnings =  playerBet * 40;
                }
                else if (bars == 3)
                {
                    winnings =  playerBet * 50;
                }
                else if (bells == 3)
                {
                    winnings =  playerBet * 75;
                }
                else if (sevens == 3)
                {
                    winnings =  playerBet * 100;
                }
                else if (grapes == 2)
                {
                    winnings =  playerBet * 2;
                }
                else if (bananas == 2)
                {
                    winnings =  playerBet * 2;
                }
                else if (oranges == 2)
                {
                    winnings =  playerBet * 3;
                }
                else if (cherries == 2)
                {
                    winnings =  playerBet * 4;
                }
                else if (bars == 2)
                {
                    winnings =  playerBet * 5;
                }
                else if (bells == 2)
                {
                    winnings =  playerBet * 10;
                }
                else if (sevens == 2)
                {
                    winnings =  playerBet * 20;
                }
                else if (sevens == 1)
                {
                    winnings =  playerBet * 5;
                }
                else
                {
                    winnings =  playerBet * 1;
                }
                winNumber++;
                showWinMessage();
            }
            else
            {
                lossNumber++;
                showLossMessage();
                winnings = 0;
            }

        }
    }
}
