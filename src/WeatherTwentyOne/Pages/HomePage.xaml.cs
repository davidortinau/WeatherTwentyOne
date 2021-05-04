using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System.Diagnostics;
using WeatherTwentyOne.Services;

namespace WeatherTwentyOne.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            NavBar.ActiveTab = "Home";
            
            SetupAppActions();
            SetupTrayIcon();

#if WINDOWS
            Microsoft.Maui.MauiWinUIApplication.Current.MainWindow.Title = "Weather TwentyOne";
            WinUI.MauiWinUIWindowExtensions.SetIcon(
                Microsoft.Maui.MauiWinUIApplication.Current.MainWindow,
                "Resources/trayicon.ico");
#endif
        }

        private void SetupAppActions()
        {
            try
            {
#if WINDOWS
                AppActions.IconDirectory = "Images";
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
}
