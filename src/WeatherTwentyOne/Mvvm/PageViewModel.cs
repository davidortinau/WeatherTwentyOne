namespace WeatherTwentyOne.Mvvm;

public abstract class PageViewModel : BindableBase, IViewModel
{
    public virtual Task InitializeAsync()
    {
        return Task.CompletedTask;
    }
}
