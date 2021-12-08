using WeatherTwentyOne.Mvvm;
using WeatherTwentyOne.ViewModels.Widget;

namespace WeatherTwentyOne.ViewModels;

public class HomePageViewModel : PageViewModel
{
    public HomePageViewModel(IWidgetViewModelFactory viewModelFactory)
    {
        WeekViewModel = viewModelFactory.Create<WeekForecastsWidgetViewModel>();
        DayViewModel = viewModelFactory.Create<DayForecastsWidgetViewModel>();
    }

    public WeekForecastsWidgetViewModel WeekViewModel { get; private set; }
    public DayForecastsWidgetViewModel DayViewModel { get; private set; }

    public override async Task InitializeAsync()
    {
        await WeekViewModel.InitializeAsync();
        await DayViewModel.InitializeAsync();
    }
}
