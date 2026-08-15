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
        // All test cases for default scores (12)
        [Theory]
        [InlineData(0, 1, "Love - Fifteen")]
        [InlineData(1, 0, "Fifteen - Love")]
        [InlineData(2, 0, "Thirty - Love")]
        [InlineData(0, 2, "Love - Thirty")]
        [InlineData(3, 0, "Forty - Love")]
        [InlineData(0, 3, "Love - Forty")]
        [InlineData(2, 1, "Thirty - Fifteen")]
        [InlineData(1, 2, "Fifteen - Thirty")]
        [InlineData(3, 1, "Forty - Fifteen")]
        [InlineData(1, 3, "Fifteen - Forty")]
        [InlineData(3, 2, "Forty - Thirty")]
        [InlineData(2, 3, "Thirty - Forty")]
        public void GivenPoints_ReturnsCorrectScore_DefaultScores(int player1Score, int player2Score, string expectedScore)
        {
            // Arrange
            TennisGame tennisGame = new TennisGame("p1Name", "p2Name");

            // Act
            string score = tennisGame.GetScore(player1Score, player2Score);

            // Assert
            Assert.Equal(expectedScore, score);

        }

        // All test cases for ties, including Deuce (5)
        [Theory]
        [InlineData(0, 0, "Love - All")]
        [InlineData(1, 1, "Fifteen - All")]
        [InlineData(2, 2, "Thirty - All")]
        [InlineData(3, 3, "Deuce")]
        [InlineData(4, 4, "Deuce")]
        public void GivenPoints_ReturnsCorrectScore_Ties(int player1Score, int player2Score, string expectedScore)
        {
            // Arrange
            TennisGame tennisGame = new TennisGame("p1Name", "p2Name");

            // Act
            string score = tennisGame.GetScore(player1Score, player2Score);

            // Assert
            Assert.Equal(expectedScore, score);

        }

        // All test cases for Advantage (4)
        [Theory]
        [InlineData(4, 3, "Advantage p1Name")]
        [InlineData(3, 4, "Advantage p2Name")]
        [InlineData(5, 4, "Advantage p1Name")]
        [InlineData(4, 5, "Advantage p2Name")]
        public void GivenPoints_ReturnsCorrectScore_Advantage(int player1Score, int player2Score, string expectedScore)
        {
            // Arrange
            TennisGame tennisGame = new TennisGame("p1Name", "p2Name");
            // Act
            string score = tennisGame.GetScore(player1Score, player2Score);
            // Assert
            Assert.Equal(expectedScore, score);
        }

        // All test cases for Win (8)
        [Theory]
        [InlineData(4, 0, "Win for p1Name")]
        [InlineData(0, 4, "Win for p2Name")]
        [InlineData(4, 1, "Win for p1Name")]
        [InlineData(1, 4, "Win for p2Name")]
        [InlineData(4, 2, "Win for p1Name")]
        [InlineData(2, 4, "Win for p2Name")]
        [InlineData(5, 3, "Win for p1Name")]
        [InlineData(3, 5, "Win for p2Name")]
        public void GivenPoints_ReturnsCorrectScore_Win(int player1Score, int player2Score, string expectedScore)
        {
            // Arrange
            TennisGame tennisGame = new TennisGame("p1Name", "p2Name");
            // Act
            string score = tennisGame.GetScore(player1Score, player2Score);
            // Assert
            Assert.Equal(expectedScore, score);
        }
    }
}
