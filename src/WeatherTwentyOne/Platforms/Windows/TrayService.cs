using Hardcodet.Wpf.TaskbarNotification.Interop;

namespace WeatherTwentyOne
{
    public class TrayService : ITrayService
    {
        WindowsTrayIcon tray;

        public Action ClickHandler { get; set; }

        public void Initialize()
        {
            tray = new WindowsTrayIcon("Platforms/Windows/trayicon.ico");
            tray.LeftClick = () => {
                MauiWinUIApplication.Current.MainWindow.BringToFront();
                ClickHandler?.Invoke();
            };
        }
    }
}
