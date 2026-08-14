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
            var scoreDict = new Dictionary<int, string>
            {
                { 0, "Love" },
                { 1, "Fifteen" },
                { 2, "Thirty" },
                { 3, "Forty" }
            };

            // Implementation for getting the score
            return scoreDict[player1Score]
                   + " - "
                   + scoreDict[player2Score];
        }
    }
}
