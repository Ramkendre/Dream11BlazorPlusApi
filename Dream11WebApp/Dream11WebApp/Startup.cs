using Dream11WebApp.Model;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Dream11WebApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IMatchData, MatchData>();
            services.AddSingleton<IplayerData, PlayerData>();
            services.AddSingleton<ILogin, LoginData>();
            services.AddSingleton<IUserCustomTeam, UserCustomTeam>();
            services.AddSingleton<IContestData, ContestData>();
            services.AddSingleton<IJsonFile, JsonFile>();
            services.AddSingleton<AppState>();
            services.AddSingleton<Common>();
            services.AddScoped<ToastService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
