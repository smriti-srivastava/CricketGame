using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class TwoPlayers
    {
        public Cricket Player1 { get; set; }
        public Cricket Player2 { get; set; }
        public TwoPlayers()
        {
            Player1 = new Cricket();
            Player2 = new Cricket();
        }

        //Winner Method
        //-- Returns 1 when Player 1 Wins
        //-- Returns 2 when Player 2 Wins
        //-- Returns -1 when the match is tie
        public int Winner()
        {
            if (Player1.PlayerScore > Player2.PlayerScore)
                return 1;
            else if (Player1.PlayerScore < Player2.PlayerScore)
                return 2;
            else
                return -1;

        }
    }
}
