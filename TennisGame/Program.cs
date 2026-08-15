
public class Program
{
    private static async Task Main(string[] args)
    {
        PrintBanner();

        Console.WriteLine();
        Console.Write("Please enter player one name: ");
        string playerOneName = Console.ReadLine();

        Console.Write("Please enter player two name: ");
        string playerTwoName = Console.ReadLine();

        Console.WriteLine("Press enter to start the game...");
        Console.ReadLine();

        var game = new TennisGame.TennisGame(playerOneName, playerTwoName);
        await game.Start();

        Console.WriteLine();
        Console.WriteLine("Bye!");
    }

    private static void PrintBanner()
    {
        Console.WriteLine(@" _____                          _       ");
        Console.WriteLine(@"|_   _|   ___   _ __    _ __   (_)  ___ ");
        Console.WriteLine(@"  | |    / _ \ | '_ \  | '_ \  | | / __|");
        Console.WriteLine(@"  | |   |  __/ | | | | | | | | | | \__ \");
        Console.WriteLine(@"  |_|    \___| |_| |_| |_| |_| |_| |___/");
    }
}