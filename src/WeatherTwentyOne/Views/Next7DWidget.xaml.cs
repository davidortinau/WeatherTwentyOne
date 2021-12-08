using WeatherTwentyOne.ViewModels;

namespace WeatherTwentyOne.Views;

public partial class Next7DWidget
{
    private HomePageViewModel viewModel;

    public Next7DWidget()
    {
        InitializeComponent();

        viewModel = ServiceLocator.GetService<HomePageViewModel>();

        BindingContext = viewModel;
    }

    protected override async void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();

        await viewModel.InitializeAsync();
    }
}
