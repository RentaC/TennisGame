# TennisGame

TennisGame is a small .NET 10 solution that contains a TennisGame project and accompanying tests. This repository is intended for development and demonstration of game logic, unit testing, and .NET project structure.

## Requirements

- .NET 10 SDK
- Visual Studio 2026 (recommended) or any IDE that supports .NET 10

## Projects

- TennisGame/ - Main project (library or app)
- TennisGame.Tests/ - Unit tests project

## Build

Using the dotnet CLI:

```powershell
dotnet build
```

Or open the solution file `TennisGame.slnx` in Visual Studio and build from the IDE.

## Run

If the main project is an executable you can run it with:

```powershell
dotnet run --project TennisGame
```

If it's a library, reference the project from another executable or test project.

## Tests

Run unit tests with the dotnet CLI:

```powershell
dotnet test
```

## Usage (How to Play)
###Start the game by running the main project. 
The game will prompt you to enter player names and simulate a tennis match. Follow the on-screen instructions to play.
(To enter player names, type them and press Enter)

###After entering the all players names, and pressing enter, the game will simulate points being played. 
After each point, the game will display the current score and announce the winner when the match concludes.
You can see some sample output below:


## Contributing

Contributions are welcome. Suggested workflow:

1. Fork the repository
2. create a feature branch
3. make changes and add tests
4. open a pull request with a clear description of the change

## License

No license file is included in this repository. Add a LICENSE file if you want to define terms for reuse.

## Contact

For questions or issues, open an issue on the repository.
