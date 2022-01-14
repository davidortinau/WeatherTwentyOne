using WeatherTwentyOne.ViewModels;

namespace WeatherTwentyOne.Pages;

public partial class SettingsPage : ContentPage
{
    private SettingsPageViewModel viewModel;

    public SettingsPage()
    {
        InitializeComponent();

        viewModel = ServiceLocator.GetService<SettingsPageViewModel>();

        BindingContext = viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await viewModel.InitializeAsync();
    }

    async void OnSignOut(object sender, EventArgs eventArgs)
    {
        await DisplayAlert("Sign Out", "Are you sure?", "Yes", "No");
    }

    async void OnSupportTapped(object sender, EventArgs eventArgs)
    {
        string action = await DisplayActionSheet("Get Help", "Cancel", null, "Email", "Chat", "Phone");
        await DisplayAlert("You Chose", action, "Okay");
    }
}
