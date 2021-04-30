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
        }

        private void SetupAppActions()
        {
            try
            {
                AppActions.SetAsync(
                       new AppAction("current_info", "Check Current Weather"),
                             new AppAction("add_location", "Add a Location")
                );
            }
            catch(FeatureNotEnabledException ex)
            {
                Debug.WriteLine("App Actions not supported");
            }
        }

        private void SetupTrayIcon()
        {
            var trayService = ServiceProvider.GetService<ITrayService>();
            var notificationService = ServiceProvider.GetService<INotificationService>();

            if (trayService != null && notificationService != null)
            {
                trayService.Initialize();
                trayService.ClickHandler = () => notificationService.ShowNotification("Tray Clicked");
            }
        }
    }
}
