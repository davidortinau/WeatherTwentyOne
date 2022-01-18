using System.Diagnostics;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using WeatherTwentyOne.Services;
using Application = Microsoft.Maui.Controls.Application;
using WindowsConfiguration = Microsoft.Maui.Controls.PlatformConfiguration.Windows;

namespace WeatherTwentyOne.Pages;

public partial class HomePage : ContentPage
{
    static bool isSetup = false;
    private ITrayService _trayService;

    public HomePage(IEnumerable<ITrayService> trayServices)
    {
        InitializeComponent();

        if (!isSetup)
        {
            isSetup = true;

            SetupAppActions();
            SetupTrayIcon();
        }
        _trayService = trayServices.FirstOrDefault();
    }

    private void SetupAppActions()
    {
        try
        {
#if WINDOWS
                AppActions.IconDirectory = Application.Current.On<WindowsConfiguration>().GetImageDirectory();
#endif
            AppActions.SetAsync(
                new AppAction("current_info", "Check Current Weather", icon: "current_info"),
                new AppAction("add_location", "Add a Location", icon: "add_location")
            );
        }
        catch (System.Exception ex)
        {
            Debug.WriteLine("App Actions not supported", ex);
        }
    }

    private void SetupTrayIcon()
    {
        if (_trayService != null)
        {
            _trayService.Initialize();
            _trayService.ClickHandler = () =>
                ServiceProvider.GetService<INotificationService>()
                    ?.ShowNotification("Hello Build! 😻 From .NET MAUI", "How's your weather?  It's sunny where we are 🌞");
        }
    }
}
