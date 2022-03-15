using System.Diagnostics;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using WeatherTwentyOne.Services;
using WeatherTwentyOne.ViewModels;
using Application = Microsoft.Maui.Controls.Application;
using WindowsConfiguration = Microsoft.Maui.Controls.PlatformConfiguration.Windows;

namespace WeatherTwentyOne.Pages;

public partial class HomePage : ContentPage
{
    static bool isSetup = false;

    public HomePage(HomeViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;

        if (!isSetup)
        {
            isSetup = true;

            SetupAppActions();
            SetupTrayIcon();
        }
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

    protected override void OnAppearing()
    {
        base.OnAppearing();

// TODO: Remove in RC1
#if WINDOWS
        var windowsWindow = this.GetParentWindow().Handler.PlatformView as MauiWinUIWindow;

        if (windowsWindow is not null)
        {
            windowsWindow.ExtendsContentIntoTitleBar = true;

            if (WindowExtensions.Hwnd == IntPtr.Zero)
            {
                var hwnd = (this.GetParentWindow().Handler.PlatformView as MauiWinUIWindow)?.WindowHandle;
                if (hwnd is not null && hwnd.Value != IntPtr.Zero)
                {
                    WindowExtensions.Hwnd = hwnd.Value;
                    WindowExtensions.SetIcon("Platforms/Windows/trayicon.ico");
                }
            }
        }
#endif
    }

    private void SetupTrayIcon()
    {
        var trayService = ServiceProvider.GetService<ITrayService>();

        if (trayService != null)
        {
            trayService.Initialize();
            trayService.ClickHandler = () =>
                ServiceProvider.GetService<INotificationService>()
                    ?.ShowNotification("Hello Build! 😻 From .NET MAUI", "How's your weather?  It's sunny where we are 🌞");
        }
    }
}
