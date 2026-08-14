using System;
using System.Collections.Generic;
using System.Text;

namespace TennisGame
{
    public class TennisGame : ITennisGame
    {
        private int _player1Score;
        private int _player2Score;
        private string _player1Name;
        private string _player2Name;

        private static readonly Dictionary<int, string> scoreDict = new Dictionary<int, string>
        {
            { 0, "Love" },
            { 1, "Fifteen" },
            { 2, "Thirty" },
            { 3, "Forty" }
        };

        public TennisGame(string player1Name, string player2Name)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;
        }

        public string GetScore(int player1Score, int player2Score)
        {
            if (player1Score == player2Score)
            {
                if (player1Score < 3)
                {
                    return scoreDict[player1Score] + " - All";
                }
                else
                {
                    return "Deuce";
                }
            }
            // Implementation default score
            return scoreDict[player1Score] + " - " + scoreDict[player2Score];
        }
    }
}
