namespace AnnoChatMaui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        MauiAppBuilder builder = MauiApp.CreateBuilder();
        _ = builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                _ = fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                _ = fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Quicksand-Bold.ttf", "QuicksandBold");
                fonts.AddFont("Quicksand-Light.ttf", "QuicksandLight");
                fonts.AddFont("Quicksand-Regular.ttf", "QuicksandRegular");
            });

        return builder.Build();
    }
}
