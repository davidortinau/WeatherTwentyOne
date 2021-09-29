namespace WeatherTwentyOne
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts => {
                    fonts.AddFont("fa-solid-900.ttf", "FontAwesome");
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
                })
                .ConfigureLifecycleEvents(lifecycle => {
#if WINDOWS
                    lifecycle
                        .AddWindows(windows => windows.OnLaunched((app, args) => {
                            MauiWinUIApplication.Current.MainWindow.SetIcon("Platforms/Windows/trayicon.ico");
                            Platform.OnLaunched(args);
                        }));
#elif ANDROID
                    lifecycle.AddAndroid(android => {
                        android.OnResume(activity => Platform.OnResume(activity));
                        android.OnNewIntent((_, intent) => Platform.OnNewIntent(intent));
                    });
#endif
                });

            return builder.Build();
        }
    }
}
