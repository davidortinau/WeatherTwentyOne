using Microsoft.Maui.Controls;
using WeatherTwentyOne.ViewModels;
using System;

namespace WeatherTwentyOne.Pages
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();

            BindingContext = new SettingsViewModel();

            NavBar.ActiveTab = "Settings";
        }

        async void OnSignOut(object sender, EventArgs eventArgs)
        {
            await DisplayAlert("Sign Out", "Are you sure?", "Yes", "No");
        }

        async void OnSupportTapped(object sender, EventArgs eventArgs)
        {
            string action = await DisplayActionSheet ("Get Help", "Cancel", null, "Email", "Chat", "Phone");
            await DisplayAlert("You Chose", action, "Okay");
        }
    }
}