using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**Signature**
 * Jonah Saywonson
 * September 23, 2022
 * CIS 3309
 * Project 1: Tic Tac Toe
 ***********/

namespace TicTacToe
{
    public partial class frmTicTacToe : Form
    {
        public frmTicTacToe()
        {
            InitializeComponent();
        }
        //Global variables declaration
        string player1name;                                         //declare variable to hold player 1 name
        List<PlayerModel> playerList = new List<PlayerModel>(2);    //create  instance of list that hold objects of type playermodel with size of 2
        BoardModel internalBoard = new BoardModel();               //create instance of boardmodel that tracks selected cells on the board
        List<Button> spaceList = new List<Button>(9);               // create list of buttons available for AI selection
        PlayerModel currentPlayer;                                  //declare variable to hold current playermodel
        int turnCounter = 0;                                        //create counter that tracks number of moves made


        //EVENT HANDLERS

        //This event handler makes visible player name input control
        //as well as the empty gameboard
        private void btnStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to My Tic-Tac-Toe Game!", "WELCOME");
            btnStart.Visible = false;
            //
            lblPlayer.Visible = true;
            txtPlayer.Visible = true;
            btnOK1.Visible = true;
            //
            lblInstructions.Visible = true;
        }

        //This event handler is responsible for validating the name of player One
        //and setting name variable to equal that of the input
        private void btnOK_Click(object sender, EventArgs e)
        {
            player1name = txtPlayer.Text.ToString();
            if(player1name != "")
            {
                txtPlayer.Enabled = false;
                btnOK1.Enabled = false;
                //enable and set focus to player 2 textbox
                btnPlayGame.Visible = true;
                lblInstructions.Text = "Press play to begin.";
            }
            else
            {
                MessageBox.Show("No name eneterd for player, enter a name", "Blank Name");
                txtPlayer.Focus();
            }
           
        }


        //This handler is responsible for creating playerModel variables containing arguments 
        //of player(one or two) with corresponding token, and putting then within a list.
        //This handler also cals the createboard method when clicked, as well as enablinig the game board
        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            btnPlayGame.Visible = false; //make visible the play game button

            //create two PlayerModel objects and add them to playerlist
            PlayerModel p;
            p = new PlayerModel(player1name, 'X');
            playerList.Add(p);
            p = new PlayerModel("AI", 'O');
            playerList.Add(p);
            currentPlayer = playerList[0]; //set current player as Player

            //call method to create gameboard from rows and columns of buttons appended to the panel control
            //enable the gameboard
            createBoard();
            pnlBoard.Enabled = true;

            //hide player name
            lblPlayer.Visible = false;
            txtPlayer.Text = playerList[0].Name;
            btnOK1.Visible = false;

            //move player names textboxes and instruction label dynamically
            txtPlayer.Location = new Point(44, 47);
            txtPlayer.Font = new Font("Lato", 16, FontStyle.Bold);
            txtPlayer.TextAlign = HorizontalAlignment.Center;
            //
            txtAI.Text = playerList[1].Name;
            txtAI.Location = new Point(269, 47);
            txtAI.Font = new Font("Lato", 16, FontStyle.Bold);
            txtAI.TextAlign = HorizontalAlignment.Center;
            txtAI.Visible = true;
            //
            lblVS.Visible = true;
            lblInstructions.Location = new Point(205, 10);

            //display players wins labels
            lblPlayerWins.Text = playerList[0].Wins.ToString();
            lblPlayerWins.Visible = true;
            //
            lblAIWins.Text = playerList[1].Wins.ToString();
            lblAIWins.Visible = true;

            //make visible restart button and update instruction label
            btnRestart.Visible = true;
            lblInstructions.Text = txtPlayer.Text + " turn.";
        }

        //This handler is responsible for exiting the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //This handler takes the combined the rows ID and Column ID index values and 
        //couple them into a single integer variable named cellID
        //This handler also calls upon the record turn methd to log a players turn
        //and the hasPlayerWon method to determine if a player has won
        private void Button_Click(object sender, EventArgs e)
        {
            //get row and column ID from button
            int rowID = convertCharToInt(((Button)sender).Name[3]);
            int colID = convertCharToInt(((Button)sender).Name[4]);
            int cellID = rowID * 3 + colID; //calculate cell ID from row and column ID

            //put current player's icon on the button, then disable the button
            internalBoard.recordTurn(currentPlayer, cellID);
            string thisToken = (currentPlayer.Icon).ToString();
            ((Button)sender).Text = thisToken;
            ((Button)sender).Enabled = false;

            //check if player has won by calling method in board BoardModel object
            if (internalBoard.hasPlayerWon(currentPlayer.Icon, cellID))
            {
                MessageBox.Show(currentPlayer.Name + " has won!");  //display winning message box
                currentPlayer.won();                                //call winning method for current player

                //disable gameboard and update win display
                pnlBoard.Enabled = false;
                lblPlayerWins.Text = playerList[0].Wins.ToString();
                lblAIWins.Text = playerList[1].Wins.ToString();
            }
            else
            {
                turnCounter++; //increment the turn counter
                if (turnCounter >= 9)
                {
                    MessageBox.Show("We have a draw!");
                    pnlBoard.Enabled = false;
                }
                else
                {
                    //call method to change the current player PlayerModel to alternative player
                    alternateTurn();
                }
            }

        }

        // This handler is responsible for clearing the gameboard creating a new gameboard
        private void btnRestart_Click(object sender, EventArgs e)
        {
            //clear and recreated the external and internal gameboards
            pnlBoard.Controls.Clear();
            internalBoard = new BoardModel();
            spaceList.Clear();
            createBoard();
            // reset turn counter, current player, reenable gamebaord control
            turnCounter = 0;
            currentPlayer = playerList[0];
            pnlBoard.Enabled = true;
        }


        //METHODS

        //This method is resposible for Dynamically creating a 3x3 array for storing refrences to the 
        // buttons that form the Tic-Tac_Toe Board on the game form 
        // Written by Bill Hall with Joe Jupin and FLF
        // All button locations appear relative to the upper left corner of the panel
        private void createBoard()
        {
            pnlBoard.Visible = true;
            Size size = new Size(75, 75);
            Point loc = new Point(0, 0);
            int padding = 25;

            // Button [,] btnSpace = new Button [2,2];

            int topMargin = 40;
            for (int row = 0; row <= 2; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 80;
                for (int col = 0; col <= 2; col++)
                {
                    Button newButton = new Button();
                    newButton.Location = new Point(extraLeftPadding + col * (size.Width + padding), loc.Y);
                    newButton.Size = size;
                    newButton.Font = new Font("Arial", 48, FontStyle.Bold);
                    newButton.Text = "";
                    newButton.Enabled = true;
                    newButton.Name = "btn" + row + col;
                    newButton.Click += new EventHandler(Button_Click); //wire newly created buttont to Button_Click event

                    // Add button to the form and list of buttons
                    pnlBoard.Controls.Add(newButton);
                    spaceList.Add(newButton);
                } // end for col
            } // end for row
        } 

        //This method is responsible for changing the current player to the alternative
        //and updating the the instruction display
        private void alternateTurn()
        {
           if(currentPlayer.Icon == 'X')
            {
                //change current player to AI
                //calculate AI selection in the internal board
                currentPlayer = playerList[1];
                int AIPick = internalBoard.AIPick();

                //activa click button event handler for AI pick from button list
                Button btnAIPick = spaceList[AIPick];
                Button_Click(btnAIPick, null);
            }
            else
            {
                currentPlayer = playerList[0];
            }
            lblInstructions.Text = currentPlayer.Name + " turn.";

        }

        //This method is responsible for converting the  value of cells from ASCII value, to desired value
        private int convertCharToInt(char v)
        {
            int answer = v - 48;
            return answer;
            
        }


    }
}
