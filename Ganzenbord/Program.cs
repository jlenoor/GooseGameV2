using Microsoft.Extensions.DependencyInjection;
using Ganzenbord;
using Ganzenbord.Business;
using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Services;
using Ganzenbord.Business.Factories.Interfaces;
using Ganzenbord.Business.Factories;
using Ganzenbord.Business.Player;
using Ganzenbord.ConsolLogger;


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
