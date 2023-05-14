using Microsoft.Extensions.Logging;

using MyApp.Pages;

namespace MyApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder.Services
            .AddSingleton<AppShell>()
            .AddTransient<InitPage>().AddTransient<InitPageViewModel>()
            .AddTransient<MainPage>().AddTransient<MainPageViewModel>();

        builder
            .UseMauiApp<App>()
            .ConfigureFonts( fonts =>
            {
                fonts.AddFont( "OpenSans-Regular.ttf", "OpenSansRegular" );
                fonts.AddFont( "OpenSans-Semibold.ttf", "OpenSansSemibold" );
            } );

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}

