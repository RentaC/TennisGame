using System;
using System.Collections.Generic;
using System.Text;

namespace TennisGame
{
    public class TennisGame : ITennisGame
    {
        private Player _player1;
        private Player _player2;

        private static readonly Dictionary<int, string> scoreDict = new Dictionary<int, string>
        {
            { 0, "Love" },
            { 1, "Fifteen" },
            { 2, "Thirty" },
            { 3, "Forty" }
        };

        public TennisGame(string player1Name, string player2Name)
        {
            _player1 = new Player(player1Name);
            _player2 = new Player(player2Name);
        }

        public string GetScore(int player1Score, int player2Score)
        {
            _player1.Score = player1Score;
            _player2.Score = player2Score;

            if (_player1.Score == _player2.Score)
            {
                if (_player1.Score < 3)
                {
                    return scoreDict[_player1.Score] + " - All";
                }
                else
                {
                    return "Deuce";
                }
            }
            // Implementation default score
            return scoreDict[_player1.Score] + " - " + scoreDict[_player2.Score];
        }
    }
}
