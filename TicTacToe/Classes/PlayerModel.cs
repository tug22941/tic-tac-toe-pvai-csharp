namespace TicTacToe
{
    internal class PlayerModel
    {
        // Player model class
        // Class that models the attributes and methods for one player
        // Responsible for data stores and methods required to model a player
        // Frank L. Friedman
        // January 11, 2016 (Rev 3)


        private string hiddenName;
        private char hiddenIcon;
        private int hiddenWins;

        //initializes the values for hiddenName, hiddenIcon and hiddenWins
        //This class uses a series of get{} to store the value of the declared variables
        public PlayerModel(string name, char icon)
        {
            hiddenName = name;
            hiddenIcon = icon;
            hiddenWins = 0;

        }


        //Read only properties
        public string Name
        {
            get
            {
                return hiddenName;
            }
        }

        public char Icon
        {
            get
            {
                return hiddenIcon;
            }
        }

        public int Wins
        {
            get
            {
                return hiddenWins;
            }
        }

        //increment number of wins for this player
        public void won()
        {
            hiddenWins++;
        }
    }
}