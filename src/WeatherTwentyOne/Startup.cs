using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.LifecycleEvents;
using WeatherTwentyOne.Services;

namespace WeatherTwentyOne
{
    public class Startup : IStartup
    {
        public void Configure(IAppHostBuilder appBuilder)
        {
            appBuilder
                .UseMauiApp<App>()
                .ConfigureServices(services => {
#if WINDOWS
                    services.AddSingleton<ITrayService, WinUI.TrayService>();
                    services.AddSingleton<INotificationService, WinUI.NotificationService>();
#elif MACCATALYST
                    services.AddSingleton<ITrayService, MacCatalyst.TrayService>();
                    services.AddSingleton<INotificationService, MacCatalyst.NotificationService>();
#endif
                })
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
                        }));
#endif
                });
        }
    }
}
