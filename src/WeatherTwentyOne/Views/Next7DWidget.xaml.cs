using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using WeatherTwentyOne.ViewModels;

namespace WeatherTwentyOne.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Next7DWidget : StackLayout
    {
        public Next7DWidget()
        {
            InitializeComponent();

            BindingContext = new HomeViewModel();
        }
    }
}