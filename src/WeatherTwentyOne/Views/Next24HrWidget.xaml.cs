using WeatherTwentyOne.ViewModels;

namespace WeatherTwentyOne.Views;

public partial class Next24HrWidget
{
    private HomePageViewModel viewModel;

    public Next24HrWidget()
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
