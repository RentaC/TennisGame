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
            if (player1Score == player2Score)
            {
                return Tie(player1Score);
            }
            else if (player1Score >= 4 || player2Score >=4)
            {
                return AdvOrWin(player1Score, player2Score);
            }
            // Implementation default score
            return scoreDict[player1Score] + " - " + scoreDict[player2Score];
        }

        private string AdvOrWin(int player1Score, int player2Score)
        {
            int scoreDifference = player1Score - player2Score;
            if (scoreDifference == 1)
            {
                return "Advantage " + _player1.Name;
            }
            else if (scoreDifference == -1)
            {
                return "Advantage " + _player2.Name;
            }
            else if (scoreDifference >= 2)
            {
                return "Win for " + _player1.Name;
            }
            else
            {
                return "Win for " + _player2.Name;
            }
        }

        private static string Tie(int player1Score)
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

        public void Start()
        {
            var score = GetScore(_player1.Score, _player2.Score);
            do
            {
               Console.WriteLine(score);

            } while (score != "Win for " + _player1.Name && score != "Win for " + _player2.Name);

        }
    }
}
