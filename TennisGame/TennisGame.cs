using System;
using System.Collections.Generic;
using System.Text;

namespace TennisGame
{
    public class TennisGame : ITennisGame
    {
        public TennisGame() { }
        public string GetScore(int player1Score, int player2Score)
        {
            // Implementation for getting the score
            return player1Score.ToString() + " - " + player2Score.ToString();
        }
    }
}
