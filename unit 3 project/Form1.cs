/*
 * Brendan van der Meulen
 * Date completed: 11/10/2013
 * Using microsoft visual studio 2010
 * on a microsoft windows 7 platform
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //Create the sorted list named 'card'.
        SortedList card = new SortedList();

        //create a list for cards that are dealt
        SortedList dealtCards = new SortedList();

        //Random card instance.
        Random randomDeal = new Random();

        //Creating the picture box.
        PictureBox picBox = new PictureBox();

        #region variables

        //Creating the player total variable.
        int playerTot;

        //Creating the dealer total variable.
        int dealerTot;

        //Total wins variable.
        int totWins = 0;

        //Total loses variable.
        int totLoss = 0;

        //Total tied variable.
        int totTied = 0;

        //Total games played variable.
        int totPlayed = 0;

        //creating the counter variable for the cards in the playerPanel.
        int counter = 0;

        //creating the counter variable for the card in the dealerPanle.
        int dealerCounter = 0;

        #endregion

        #region methods

        //method to reset the cards after a bust, win or tie.
        public void reset()
        {
            //The images are removed and the scores are zero'd for the next game to begin.
            dealerCard1.Image = Image.FromFile("CardBack.png");
            dealerCard2.Image = Image.FromFile("CardBack.png");

            playerCard1.Image = Image.FromFile("CardBack.png");
            playerCard2.Image = Image.FromFile("CardBack.png");

            playerPanel.Controls.Clear();
            dealerPanel.Controls.Clear();

            dealerScore.Text = "Score: ";
            playerScore.Text = "Score: ";

            counter = 0;
            dealerCounter = 0;

            deal.Enabled = true;
            hit.Enabled = false;
            stand.Enabled = false;

            dealtCards.Clear();
        }

        //method to check the players total score and display the relevant message.
        public void playerScoreCount()
        {
            if (playerTot == 21)
            {
                /*
                 * If the player scores a blackjack on the deal he wins, 
                 * and the relevant scores are update with a message saying they won, 
                 * and the 'reset' method is executed.
                 */
                MessageBox.Show(
                    "Player got blackjack! Player wins.",
                    "Blackjack",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                totPlayed = totPlayed + 1;
                totWins = totWins + 1;

                Wins.Text = "Wins: " + totWins;
                played.Text = "Games played: " + totPlayed;
                reset();
            }
            else if (playerTot > 21)
            {
                /*
                 * If the player scores over twenty one, he has gone bust, and the relevant scores are updated 
                 * with a message explaining the loss, and the 'reset' method is executed. 
                 */
                MessageBox.Show(
                    "You are bust! Dealer wins.",
                    "Dealer wins.",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);

                totLoss = totLoss + 1;
                Losses.Text = "Losses: " + totLoss;
                totPlayed = totPlayed + 1;
                played.Text = "Games played: " + totPlayed;
                reset();
            }
        }

        //Method to check the dealers total score and display the relevant message.
        public void dealerScoreCount()
        {
            if (dealerTot > 21)
            {
                /*
                 * If the dealer scores over 21, he has gone bust, and the relevant scores are updated
                 * with a message explaining the loss, and the 'reset' method is executed.
                 */
                MessageBox.Show(
                    "Dealer is bust. Player wins.",
                    "Player wins.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                totWins = totWins + 1;
                Wins.Text = "Wins: " + totWins;

                totPlayed = totPlayed + 1;
                reset();
            }
            else if (dealerTot == 21)
            {
                /*
                 * If the dealer scores a 21, the players score must be checked, if the player also scored a 21 it is a tie
                 * and the relevant scores must be updated, as is with the first nested if statement. Or the player has less than 21, in which case
                 * the dealer wins and the relevant scores are updated, as is with the else if statement. In either scenario, 
                 * the reset method is executed.
                 */
                if (playerTot == 21)
                {
                    MessageBox.Show(
                        "You both score 21, its a tie!",
                        "Tie.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    totTied = totTied + 1;
                    Ties.Text = "Ties: " + totTied;

                    totPlayed = totPlayed + 1;
                    reset();
                }
                else if (playerTot != 21)
                {
                    MessageBox.Show(
                        "Dealer has blackjack, you lose",
                        "Dealer wins",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    totLoss = totLoss + 1;
                    Losses.Text = "Losses: " + totLoss;

                    totPlayed = totPlayed + 1;
                    reset();
                }
            }
            else if (dealerTot == 17)
            {
                /*
                 * If the dealer scores a 17, he may not hit again, so then the dealer and player scores must be compared.
                 * If the player scores under 17 the dealer wins and the relevant scores are updated, with a message explaining.
                 * other wise the player scores over 17, or is bust.
                 */
                if (playerTot < 17)
                {
                    MessageBox.Show(
                        "Dealer has higher score! Dealer wins.",
                        "Player loses.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    totLoss = totLoss + 1;
                    Losses.Text = "Losses: " + totLoss;

                    totPlayed = totPlayed + 1;
                    reset();
                }
                else if (playerTot > 17) 
                {
                    MessageBox.Show(
                        "Player has higher score! Player wins.",
                        "Player wins.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    totWins = totWins + 1;
                    Wins.Text = "Wins: " + totWins;

                    totPlayed = totPlayed + 1;
                    reset();
                }
                //The dealer can not hit again if he scores 17, if the player stands on 17 it is a tie.
                else if (playerTot == 17)
                {
                    MessageBox.Show(
                    "Dealer has same score! Its a tie!",
                    "Tie!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                    totTied = totTied + 1;
                    played.Text = "Played: " + totTied;

                    totPlayed = totPlayed + 1;
                    reset();
                }
            }
            else if (dealerTot > playerTot)
            {
                /*
                 * If the dealer score is higher than the player, the relevant scores are updated and message displayed.
                 */
                MessageBox.Show(
                        "Dealer has higher score! Dealer wins.",
                        "Player loses.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                totLoss = totLoss + 1;
                Losses.Text = "Losses: " + totLoss;

                totPlayed = totPlayed + 1;
                reset();
            }
            else if (playerTot > dealerTot)
            {
                /*
                 * If the players score is higher than the dealers, the player wins. 
                 * The relevant scores are updated along with the messages.
                 */
                MessageBox.Show(
                    "Player has higher score! Player wins.",
                    "Player wins.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                totWins = totWins + 1;
                Wins.Text = "Wins: " + totWins;

                totPlayed = totPlayed + 1;
                reset();
            }
            else if (dealerTot == playerTot)
            {
                /*
                 * If the player and dealer score the same, it is recorded as a draw/tie and the relevant 
                 * scores are updated along with messages explaining.
                 */
                MessageBox.Show(
                    "It is a tie!",
                    "Tie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                totTied = totTied + 1;
                Ties.Text = "Ties: " + totTied;

                totPlayed = totPlayed + 1;
                reset();
            }
            played.Text = "Games played: " + totPlayed;
        }

        #endregion

        public Form1()
        {
            //inserting the information into the sorted list 'card' for the Hearts suit.
            card.Add("HeartsAce", 0);
            card.Add("HeartsTwo", 2);
            card.Add("HeartsThree", 3);
            card.Add("HeartsFour", 4);
            card.Add("HeartsFive", 5);
            card.Add("HeartsSix", 6);
            card.Add("HeartsSeven", 7);
            card.Add("HeartsEight", 8);
            card.Add("HeartsNine", 9);
            card.Add("HeartsTen", 10);
            card.Add("HeartsJack", 10);
            card.Add("HeartsQueen", 10);
            card.Add("HeartsKing", 10);

            //inserting the information into the sorted list 'card' for the Diamonds suit.
            card.Add("DiamondsAce", 0);
            card.Add("DiamondsTwo", 2);
            card.Add("DiamondsThree", 3);
            card.Add("DiamondsFour", 4);
            card.Add("DiamondsFive", 5);
            card.Add("DiamondsSix", 6);
            card.Add("DiamondsSeven", 7);
            card.Add("DiamondsEight", 8);
            card.Add("DiamondsNine", 9);
            card.Add("DiamondsTen", 10);
            card.Add("DiamondsJack", 10);
            card.Add("DiamondsQueen", 10);
            card.Add("DiamondsKing", 10);

            //inserting the information into the sorted list 'card' for the Spades suit.
            card.Add("SpadesAce", 0);
            card.Add("SpadesTwo", 2);
            card.Add("SpadesThree", 3);
            card.Add("SpadesFour", 4);
            card.Add("SpadesFive", 5);
            card.Add("SpadesSix", 6);
            card.Add("SpadesSeven", 7);
            card.Add("SpadesEight", 8);
            card.Add("SpadesNine", 9);
            card.Add("SpadesTen", 10);
            card.Add("SpadesJack", 10);
            card.Add("SpadesQueen", 10);
            card.Add("SpadesKing", 10);

            //inserting the information into the sorted list 'card' for the Clubs suit.
            card.Add("ClubsAce", 0);
            card.Add("ClubsTwo", 2);
            card.Add("ClubsThree", 3);
            card.Add("ClubsFour", 4);
            card.Add("ClubsFive", 5);
            card.Add("ClubsSix", 6);
            card.Add("ClubsSeven", 7);
            card.Add("ClubsEight", 8);
            card.Add("ClubsNine", 9);
            card.Add("ClubsTen", 10);
            card.Add("ClubsJack", 10);
            card.Add("ClubsQueen", 10);
            card.Add("ClubsKing", 10);

            //Initializing the form component
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Disabling the hit and stand button when the game is loaded. 
            hit.Enabled = false;
            stand.Enabled = false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //If the user wants to start a new game.
            DialogResult result = MessageBox.Show(
                "Are you sure you want to start a new game? The current information will be lost",
                "Continue?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //If yes is selected. If the used selects no, the gaame returns to how it was left.
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //If the user wants to quit the game.
            DialogResult result = MessageBox.Show(
                "Are you sure you want to quit this game? All current information will be lost.",
                "Continue?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //If yes is selected. If no is selected the game returns to how it was.
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void deal_Click(object sender, EventArgs e)
        {
            //When deal is selected, the hit and stand buttons are enabled and the deal button is disabled.
            hit.Enabled = true;
            stand.Enabled = true;
            deal.Enabled = false;

            #region player deal cards

            //Two random cards are selected and loaded in the picture boxes for the player.
            int deal1 = randomDeal.Next(52);
            playerCard1.Image = Image.FromFile("Cards\\" + card.GetKey(deal1) + ".png");
            dealtCards.Add(deal1, playerCard1);

            int deal2 = randomDeal.Next(52);
            do
            {
                deal2 = randomDeal.Next(52);
            }
            while (dealtCards.ContainsKey(deal2));
            playerCard2.Image = Image.FromFile("Cards\\" + card.GetKey(deal2) + ".png");
            dealtCards.Add(deal2, playerCard2);

            #endregion
           
            #region player Ace check

            //Checking if either card dealt is an ace.
            if (((int)(card.GetByIndex(deal1))) == 0)
            {
                //If the first card dealt is an ace it is counted as an 11.
                deal1 = 11;
            }
            else
            {
                //If the card is not an ace it keeps its original value.
                deal1 = ((int)(card.GetByIndex(deal1)));
            }

            if (((int)(card.GetByIndex(deal2))) == 0)
            {
                //If the second card dealt is an ace, and the first is an ace, the second is counted as a 1.
                if (deal1 == 0)
                {
                    deal2 = 1;
                }
                else
                {
                    //If the first card is not an ace the second card is counted as 11.
                    deal2 = 11;
                }
            }
            else
            {
                //If the second card is not an ace the original card value is counted.
                deal2 = ((int)(card.GetByIndex(deal2)));
            }

            #endregion

            //Players total is counted and displayed, then the 'playerScoreCount' method is run.
            playerTot = (deal1 + deal2);
            playerScore.Text = "Score: " + playerTot;
            playerScoreCount();

            #region dealer deal cards

            //A random card is selected and loaded in the first picture box for the dealer. The score is displayed for the one card.
            int deal3 = randomDeal.Next(52);
            do
            {
                deal3 = randomDeal.Next(52);
            }
            while (dealtCards.ContainsKey(deal3));
            dealerCard1.Image = Image.FromFile("Cards\\" + card.GetKey(deal3) + ".png");
            dealtCards.Add(deal3, dealerCard1);

            #endregion

            #region dealer Ace check


            //Checking if the card dealt to the dealer is an ace.
            if (((int)(card.GetByIndex(deal3))) == 0)
            {
                dealerTot = 11;
            }
            else
            {
                dealerTot = ((int)(card.GetByIndex(deal3)));
            }

            #endregion

            //Dealer score is displayed.
            dealerScore.Text = "Score: " + dealerTot;
        }

        private void hit_Click(object sender, EventArgs e)
        {

            //Random card is created when 'hit' is selected and displayed in the players panel.
            int hit = randomDeal.Next(52);
            do
            {
                hit = randomDeal.Next(52);
            }
            while (dealtCards.ContainsKey(hit));
            dealtCards.Add(hit, playerPanel);
            playerPanel.Controls.Add(new cardClass(counter, 0, card.GetKey(hit).ToString()));
            counter = counter + 15;

            /*
             * If the card has a value of zero (an Ace) it must be counted as 11, 
             * unless the total score would be over 21, at which point it would be counted as a 1.
             */
            if ((int)(card.GetByIndex(hit)) == 0)//Checking card value.
            {
                hit = 11; //Asigning value.
                if (playerTot + hit > 21)//If over 21, value is 1.
                {
                    hit = 1;
                }
            }
            else//If it is not an ace the original value is counted.
            {
                hit = ((int)(card.GetByIndex(hit)));
            }

            //Player score is totaled and displayed, and the 'playerScoreCount' method is run.
            playerTot = playerTot + hit;
            playerScore.Text = "Score: " + playerTot;
            playerScoreCount();
        }

        private void stand_Click(object sender, EventArgs e)
        {

            //Hit and Stand buttons are disabled.
            hit.Enabled = false;
            stand.Enabled = false;

            //Random card is generated and displayed in the dealers panel.
            int deal4 = randomDeal.Next(52);
            do
            {
                deal4 = randomDeal.Next(52);
            }
            while (dealtCards.ContainsKey(deal4));
            dealtCards.Add(deal4, dealerCard2);
            dealerCard2.Image = Image.FromFile("Cards\\" + card.GetKey(deal4) + ".png");

            //Dealer total is counted and displayed.
            dealerTot = dealerTot + ((int)(card.GetByIndex(deal4)));
            dealerScore.Text = "Score: " + dealerTot;


            //If the dealer total is above 17, the card generated must be checked if it is an ace.
            if (dealerTot > 17)
            {
                if (((int)(card.GetByIndex(deal4))) == 0)//Checking for an Ace.
                {
                    dealerTot = dealerTot - 10;//Subtracting ten if the card is an ace.

                    //If the dealer total is below 17 after the ten is subtracted, another card must be generated.
                    if (dealerTot < 17)
                    {
                        int dealerHit3 = randomDeal.Next(52);
                        do
                        {
                            dealerHit3 = randomDeal.Next(52);
                        }
                        while (dealtCards.ContainsKey(dealerHit3));
                        dealtCards.Add(dealerHit3, dealerPanel);
                        dealerPanel.Controls.Add(new cardClass(dealerCounter, 0, card.GetKey(dealerHit3).ToString()));
                        dealerCounter = dealerCounter + 15;
                    }
                }
                dealerScoreCount();
            }
            
            //If the dealers total is less than 17, another card must be generated.
            else if (dealerTot < 17)
            {
                int dealerHit = randomDeal.Next(52);
                do
                {
                    dealerHit = randomDeal.Next(52);
                }
                while (dealtCards.ContainsKey(dealerHit));
                dealtCards.Add(dealerHit, dealerPanel);
                dealerPanel.Controls.Add(new cardClass(dealerCounter, 0, card.GetKey(dealerHit).ToString()));
                dealerCounter = dealerCounter + 15;

                dealerTot = dealerTot + ((int)(card.GetByIndex(dealerHit)));
                dealerScore.Text = "Score: " + dealerTot;

                //If the dealers total is still less than 17, another card must be generated.
                if (dealerTot < 17)
                {
                    int dealerHit2 = randomDeal.Next(52);
                    do
                    {
                        dealerHit2 = randomDeal.Next(52);
                    }
                    while (dealtCards.ContainsKey(dealerHit2));
                    dealtCards.Add(dealerHit2, dealerPanel);
                    dealerPanel.Controls.Add(new cardClass(counter, 0, card.GetKey(dealerHit2).ToString()));
                    counter = counter + 15;

                    dealerTot = dealerTot + ((int)(card.GetByIndex(dealerHit2)));
                    dealerScore.Text = "Score: " + dealerTot;
                }
                dealerScoreCount();
            }
            //If the dealers total is 17, the 'dealerScoreCount' methos is run.
            else if (dealerTot == 17)
            {
                dealerScoreCount();
            }
            //If the dealer and plaer share equal scores, the 'dealerScoreCount' method is run.
            else if (dealerTot == playerTot)
            {
                dealerScoreCount();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }

    //A class for the card generation method.
    public class cardClass : System.Windows.Forms.PictureBox
    {
        public cardClass(int X_Cord, int Y_Cord, string cardkey)
        {
            this.Image = System.Drawing.Image.FromFile("Cards\\" + cardkey + ".png");
            this.Location = new System.Drawing.Point(X_Cord, Y_Cord);
            this.Size = new System.Drawing.Size(79, 123);
        }
    }
}
