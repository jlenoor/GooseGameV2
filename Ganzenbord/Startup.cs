using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Factories.Interfaces;
using Ganzenbord.Business.Factories;
using Ganzenbord.Business.Services;
using Ganzenbord.Business;
using Ganzenbord.Business.Player;
using Microsoft.Extensions.DependencyInjection;

namespace Ganzenbord
{
    public class Startup
    {
        // All dependencies are registered here
        public ServiceCollection RegisterServices()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<ILogging, Logger>();
            services.AddScoped<IDiceService, DiceService>();
            services.AddScoped<IPlayerFactory, PlayerFactory>();
            services.AddScoped<ISquareFactory, SquareFactory>();
            services.AddScoped<IPlayer, Player>();
            services.AddSingleton<IGame, Game>();

            return services;
        }
    }
}
