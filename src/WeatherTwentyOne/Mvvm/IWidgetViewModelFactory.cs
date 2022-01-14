namespace WeatherTwentyOne.Mvvm;

public interface IWidgetViewModelFactory
{
    T Create<T>() where T : WidgetViewModel;
}
