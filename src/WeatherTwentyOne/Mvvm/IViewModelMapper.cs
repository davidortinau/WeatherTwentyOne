namespace WeatherTwentyOne.Mvvm;

public interface IViewModelMapper
{
    View ResolveView(IViewModel viewModel);
}
