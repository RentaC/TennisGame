namespace TennisGame.Tests
{

    // This is a test class for the TennisGame class.
    // It uses the xUnit testing framework to define test methods.
    // Rules that should be followed for the TennisGame:
    // 1. The game starts at "Love-All".
    // 2. The score progresses as follows: Love, Fifteen, Thirty, Forty.
    // 3. If both players have the same score from Love to Forty,
    // the score is displayed as "Love-All", "Fifteen-All", "Thirty-All", or "Deuce" (for Forty-All).
    // 4. If a player has at least three points and leads by one point,
    // the score is "Advantage" for that player.
    // 5. If a player has at least four points and leads by two points, 
    // that player wins the game, and the score is displayed as "Win for player1" or "Win for player2".
    // 6. The score should be displayed in the format "player1Score-player2Score" for all other cases.
    // 7. The game should handle invalid scores gracefully,
    // returning an appropriate message or throwing an exception.

    public class TennisGameTests
    {
        [Theory]
        [InlineData("p1", "p2", 0, 1, "Love - Fifteen")]
        [InlineData("p1", "p2", 1, 0, "Fifteen - Love")]
        [InlineData("p1", "p2", 2, 1, "Thirty - Fifteen")]
        [InlineData("p1", "p2", 3, 1, "Forty - Fifteen")]
        public void GivenPoints_ReturnsCorrectScore(string player1Name, string player2Name, int player1Score, int player2Score, string expectedScore)
        {
            // Arrange
            TennisGame tennisGame = new TennisGame(player1Name, player2Name);

            // Act
            string score = tennisGame.GetScore(player1Score, player2Score);

            // Assert
            Assert.Equal(expectedScore, score);

        }

        [Theory]
        [InlineData("p1", "p2", 0, 0, "Love - All")]
        [InlineData("p1", "p2", 1, 1, "Fifteen - All")]
        [InlineData("p1", "p2", 2, 2, "Thirty - All")]
        [InlineData("p1", "p2", 3, 3, "Deuce")]
        [InlineData("p1", "p2", 4, 4, "Deuce")]
        public void GivenPoints_ReturnsCorrectScore_Ties(string player1Name, string player2Name, int player1Score, int player2Score, string expectedScore)
        {
            // Arrange
            TennisGame tennisGame = new TennisGame(player1Name, player2Name);

            // Act
            string score = tennisGame.GetScore(player1Score, player2Score);

            // Assert
            Assert.Equal(expectedScore, score);

        }
    }
}
