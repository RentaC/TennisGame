using System;
using System.Collections.Generic;
using System.Text;

namespace TennisGame
{
    public interface ITennisGame
    {
       string GetScore(int player1Score, int player2Score);
    }
}
