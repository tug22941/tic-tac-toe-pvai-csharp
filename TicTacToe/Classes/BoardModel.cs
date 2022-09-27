using System;
using System.Collections.Generic;

/**Signature**
 * Jonah Saywonson
 * September 23, 2022
 * CIS 3309
 * Project 1: Tic Tac Toe
 ***********/

namespace TicTacToe
{
    internal class BoardModel
    {
        // Board model class
        // Class that tracks the turns taken by each player and determine win or draw
        // Responsible for data store and methods required to determine a winner or draw

        //Create arrays for tracking spaces picked by players
        //Create counter for both player turns
        int[] playerOne = new int[5];
        int[] playerTwo = new int[4];
        int countOne = 0;
        int countTwo = 0;
        List<int> usedSpace = new List<int>(9);

        internal BoardModel()
        {

        }
        //This method records the turn of the current player as indicated by the icon, by
        //incrementing the value for that player when their icon is placed within a cellID
        internal void recordTurn(PlayerModel player, int cell)
        {
            if(player.Icon == 'X')
            {
                playerOne[countOne] = cell;
                countOne++;
            }
            else
            {
                playerTwo[countTwo] = cell;
                countTwo++;
            }

            usedSpace.Add(cell);

        }

        // This method determines whether a player has a winninng combination of cellIDs 
        // by comparing the player selected cell ID'S to a list of winning combination
        internal bool hasPlayerWon(char icon, int cellID)
        {
            //if player one has played at least 3 turns
            if (countOne >= 3)
            {
                // call the createWinList that creates a list of
                // arrays containing winning cell combinations
                List<int[]> winList = createWinList();
                int[] currentPlayer;
                int count;

                //determine current player and counter
                if (icon == 'X')
                { 
                    currentPlayer = playerOne;
                    count = countOne;
                }else
                { 
                    currentPlayer = playerTwo;
                    count = countTwo;
                }

                // create and fill a new array containing only cellIDs selected 
                // by player with no blank (0) index
                int[] playerPicks = new int [count];
                for(int i=0; i<=count-1; i++)
                {
                    playerPicks[i] = currentPlayer[i];
                }

                //iterate through the winning combo list and 
                //check if all the winning numbers are in the player picks array
                for (int i = 0; i < winList.Count; i++)
                {

                    int[] wincombo = winList[i]; //current win combo
                    //find index of wining number that is in player picks array
                    //return -1 for index if not found 
                    int pick1 = Array.IndexOf(playerPicks, wincombo[0]); 
                    int pick2 = Array.IndexOf(playerPicks, wincombo[1]);
                    int pick3 = Array.IndexOf(playerPicks, wincombo[2]);

                    //if all three winning numbers from combo are in playerpicks array
                    if (pick1 != -1 && pick2 != -1 && pick3 != -1)
                    {
                        return true;
                    }
                }
                return false;
            }
            else { return false; }

        }

        // This method is responsible for returning a list of interger arrays containing winning
        // combinations of cell ID for the tic-tac-toe gameboard
        public List<int[]> createWinList()
        {
            List<int[]> winList = new List<int[]>(8);
            //
            int[] rowWin1 = { 0, 1, 2 };
            int[] rowWin2 = { 3, 4, 5 };
            int[] rowWin3 = { 6, 7, 8 };
            //
            winList.Add(rowWin1);
            winList.Add(rowWin2);
            winList.Add(rowWin3);

            int[] colWin1 = { 0, 3, 6 };
            int[] colWin2 = { 1, 4, 7 };
            int[] colWin3 = { 2, 5, 8 };
            //
            winList.Add(colWin1);
            winList.Add(colWin2);
            winList.Add(colWin3);

            int[] diagWin1 = { 0, 4, 8 };
            int[] diagWin2 = { 2, 4, 6 };
            //
            winList.Add(diagWin1);
            winList.Add(diagWin2);

            return winList;

        }

        //This method is responsible for checking the available spaces of the gameboard 
        //and returning a integer ID representing AI opponent selected space
        public int AIPick()
        {
            int size =  9 - (countOne + countTwo);
            int[] freeSpace = new int[size];
            int count = 0;

            for(int i = 0; i < 8; i++)
            {
                if (!usedSpace.Contains(i))
                {
                    freeSpace[count] = i;
                    count++;
                }
            }

            Random rand = new Random();
            int randindex = rand.Next(0, count);
            int pick = freeSpace[randindex];
            return pick;
        }
    }
}