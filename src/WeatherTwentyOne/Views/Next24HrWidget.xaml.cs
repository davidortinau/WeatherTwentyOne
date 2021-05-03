using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using WeatherTwentyOne.ViewModels;

namespace WeatherTwentyOne.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Next24HrWidget
    {
        public Next24HrWidget()
        {
            InitializeComponent();

            BindingContext = new HomeViewModel();
        }
    }
}