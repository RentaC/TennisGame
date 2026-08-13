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
        [InlineData(0, 0, "0 - 0")]
        [InlineData(1, 1, "1 - 1")]
        [InlineData(2, 2, "2 - 2")]
        [InlineData(3, 3, "3 - 3")]
        public void GivenPoints_ReturnsCorrectScore(int player1Score, int player2Score, string expectedScore)
        {
            // Arrange
            TennisGame tennisGame = new TennisGame();

            // Act
            string score = tennisGame.GetScore(player1Score, player2Score);

            // Assert
            Assert.Equal(expectedScore, score);

        }
    }
}
