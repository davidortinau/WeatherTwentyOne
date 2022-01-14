namespace WeatherTwentyOne.Mvvm;

public class WidgetViewModelFactory : IWidgetViewModelFactory
{
    private readonly IServiceProvider serviceProvider;

    public WidgetViewModelFactory(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
    }

    public T Create<T>() where T : WidgetViewModel
    {
        return serviceProvider.GetService<T>();
    }
}

