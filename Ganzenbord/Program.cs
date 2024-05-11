using Ganzenbord.Business;
using Ganzenbord.Business.Factories;
using Ganzenbord.Business.Factories.Interfaces;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Services;


Ganzenbord.Business.Logger.ILogging Logger = new Ganzenbord.Business.Logger.Logger();
IDiceService diceService = new DiceService();
IPlayerFactory playerFactory = new PlayerFactory();
IGameLoop gameLoop = new GameLoop();
ISquareFactory squareFactory = new SquareFactory();
IPlayer player = new Player("startPlayer");
IGame game = new Game(Logger, squareFactory, playerFactory, player, diceService, gameLoop);

//ServiceCollection serviceCollection = new Startup().RegisterServices();
//ServiceProvider provider = serviceCollection.BuildServiceProvider();

//IGame game = provider.GetService<IGame>();

game.StartGame();
