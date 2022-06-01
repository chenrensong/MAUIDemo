using MAUIDemo.Controls;
using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace MAUIDemo;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureMauiHandlers(handlers =>
            {
                handlers.AddHandler(typeof(ICustomButton), typeof(CustomButtonHandler));
            })
            .ConfigureEffects(x =>
            {
#if WINDOWS 
                x.Add<TouchRoutingEffect, TouchPlatformEffect>();
#endif
            })
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("fontawesome.otf", "fontawesome");
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        return builder.Build();
    }
}
