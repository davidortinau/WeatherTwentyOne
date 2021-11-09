using WeatherTwentyOne.Pages;

namespace WeatherTwentyOne;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        if (Device.Idiom == TargetIdiom.Phone)
            Shell.Current.CurrentItem = PhoneTabs;

        Routing.RegisterRoute("settings", typeof(SettingsPage));
    }

    void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync("///settings");
    }
}
