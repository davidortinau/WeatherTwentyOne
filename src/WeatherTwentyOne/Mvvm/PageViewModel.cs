namespace WeatherTwentyOne.Mvvm;

public abstract class PageViewModel : BindableBase
{
    public virtual Task InitializeAsync()
    {
        return Task.CompletedTask;
    }
}
