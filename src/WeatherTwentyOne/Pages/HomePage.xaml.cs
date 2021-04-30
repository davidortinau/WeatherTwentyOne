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

            // Setup App Actions
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

            // Register services
            var trayService = ServiceProvider.GetService<ITrayService>();
            var notificationService = ServiceProvider.GetService<INotificationService>();

            trayService?.Initialize();
            trayService.ClickHandler = () => 
                notificationService.ShowNotification("Hello Windows! 😻 .NET MAUI says it's currently 18°. Brrr!");

        }
    }
}
