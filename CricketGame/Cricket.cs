using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Cricket
    {
        public int PlayerScore { get; set; }
        public bool IsPlayerOut { get; set; }

        public int NumberOfBallsPlayed { get; set; }
        public Cricket()
        {
            PlayerScore = 0;
            IsPlayerOut = false;
        }

        public void PlayerOut()
        {
            IsPlayerOut = true;
        }
        public void Score(int runs)
        {
            if ((0 < runs && runs < 7) && !IsPlayerOut)
            {
                PlayerScore += runs;
            }
        }
    }
}
