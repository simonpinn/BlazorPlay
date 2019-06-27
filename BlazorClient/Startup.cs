using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using BlazorClient.Services;
using Sotsera.Blazor.Toaster.Core.Models;

namespace BlazorClient
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddToaster(config =>
            {
                //example customizations
                config.PositionClass = Defaults.Classes.Position.TopRight;
                config.PreventDuplicates = true;
                config.NewestOnTop = false;
            })
                .AddSingleton<IAppStateService, AppStateService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
