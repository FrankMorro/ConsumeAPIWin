using MauiAppBlazor.Services;
using Microsoft.Extensions.Logging;
using Users.MAUI.Data;

namespace Users.MAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

            //Inyectamos aquí el Servicio
            builder.Services.AddSingleton<IRickAndMortyService, RickAndMortyService>();

#if DEBUG
            IServiceCollection serviceCollection = builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<WeatherForecastService>();

            return builder.Build();
        }
    }
}