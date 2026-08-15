
namespace TennisGame
{
    public static class LuckGen
    {
        // Decides, purely by chance, who wins the next point.
        // Introduced a delay to simulate the time taken for a point to be played.
        private static readonly Random _random = new Random();

        public static async Task<bool> IsPlayer1Lucky()
        {
            await Task.Delay(1000);
            return _random.Next(0, 2) == 0; // 50% chance
        }
    }
}
