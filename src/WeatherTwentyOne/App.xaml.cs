using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using WeatherTwentyOne.Pages;
using Application = Microsoft.Maui.Controls.Application;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace WeatherTwentyOne
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState activationState) =>
            new Window(new NavigationPage(new HomePage())) { Title = "Weather TwentyOne" };
    }
}