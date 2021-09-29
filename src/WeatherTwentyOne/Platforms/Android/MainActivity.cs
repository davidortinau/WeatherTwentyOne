using Android.App;

namespace WeatherTwentyOne
{
    [IntentFilter(
        new[] { Platform.Intent.ActionAppAction },
        Categories = new[] { Android.Content.Intent.CategoryDefault })]
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true)]
    public class MainActivity : MauiAppCompatActivity
    {
    }
}