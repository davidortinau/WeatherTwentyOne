namespace WeatherTwentyOne
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new HomePage());

            //Routing.RegisterRoute("settings", typeof(SettingsPage));
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Shell.Current.GoToAsync("///settings");
        }
    }
}