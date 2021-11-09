using Hardcodet.Wpf.TaskbarNotification.Interop;
using Microsoft.UI.Xaml;
using WeatherTwentyOne.Services;

namespace WeatherTwentyOne.WinUI;

public class TrayService : ITrayService
{
    WindowsTrayIcon tray;

    public Action ClickHandler { get; set; }

    public void Initialize()
    {
        tray = new WindowsTrayIcon("Platforms/Windows/trayicon.ico");
        tray.LeftClick = () => {
            var winuiApp = (Microsoft.Maui.Controls.Window)MauiWinUIApplication.Current.Application.Windows[0].Handler!.NativeView!;
            winuiApp.BringToFront();
            //Microsoft.Maui.MauiWinUIApplication.Current.Application.Windows[0].BringToFront();
            ClickHandler?.Invoke();
        };
    }
}
