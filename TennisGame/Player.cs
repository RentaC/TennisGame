using System;
using System.Collections.Generic;
using System.Text;

namespace TennisGame
{
    public class Player
    {
        public string Name { get; init; }
        public int Score { get; private set; }
        public Player(string name)
        {
            Name = name;
            Score = 0;
        }
        public void WinPoint()
        {
            Score++;
        }
    }
}
