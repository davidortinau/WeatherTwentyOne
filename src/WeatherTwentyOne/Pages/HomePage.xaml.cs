using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using WeatherTwentyOne.Services;

namespace WeatherTwentyOne.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            var trayService = ServiceProvider.GetService<ITrayService>();
            var notificationService = ServiceProvider.GetService<INotificationService>();

            if (trayService != null)
            {
                trayService.Initialize();
                trayService.ClickHandler = () => notificationService.ShowNotification("Tray Clicked");
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            VisualStateManager.GoToState(NavBar, "Home");
        }
    }
}
