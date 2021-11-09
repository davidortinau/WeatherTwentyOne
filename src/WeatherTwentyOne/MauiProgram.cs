using Microsoft.Maui.LifecycleEvents;

namespace WeatherTwentyOne;

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
            });
        builder.ConfigureLifecycleEvents(lifecycle => {
#if WINDOWS
            lifecycle
                .AddWindows(windows => windows.OnLaunched((app, args) => {
                    var winuiApp = (Microsoft.UI.Xaml.Window)MauiWinUIApplication.Current.Application.Windows[0].Handler!.NativeView!;
                    winuiApp.SetIcon("Platforms/Windows/trayicon.ico");
                }));
#endif
        });

        var services = builder.Services;
#if WINDOWS
            services.AddSingleton<ITrayService, WinUI.TrayService>();
            services.AddSingleton<INotificationService, WinUI.NotificationService>();
#elif MACCATALYST
            services.AddSingleton<ITrayService, MacCatalyst.TrayService>();
            services.AddSingleton<INotificationService, MacCatalyst.NotificationService>();
#endif




        return builder.Build();
    }
}