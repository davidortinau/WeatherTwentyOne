using Microsoft.Maui.Controls.Handlers;
using WeatherTwentyOne.Pages;

namespace WeatherTwentyOne;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        //App.Current.UserAppTheme = OSAppTheme.Light;

        if (Device.Idiom == TargetIdiom.Phone)
            Shell.Current.CurrentItem = PhoneTabs;

        Routing.RegisterRoute("settings", typeof(SettingsPage));

#if WINDOWS
        ShellHandler
            .Mapper
            .ModifyMapping(nameof(Shell.FlyoutBehavior), OnFlyoutBehavior);
#endif
    }

    void OnFlyoutBehavior(ShellHandler arg1, Shell arg2, Action<IElementHandler, IElement> arg3)
    {
        arg1.NativeView.PaneDisplayMode = Microsoft.UI.Xaml.Controls.NavigationViewPaneDisplayMode.LeftCompact;
    }

    void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync("///settings");
    }
}
