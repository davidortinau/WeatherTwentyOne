using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Extensions.DependencyInjection;
using WeatherTwentyOne.Services;

namespace WeatherTwentyOne
{
	public class Startup : IStartup
	{
		public void Configure(IAppHostBuilder appBuilder)
		{
			appBuilder
				.UseCompatibility()
				.UseMauiApp<App>()
				.ConfigureServices(services =>
				{
#if WINDOWS
					services.AddSingleton<ITrayService, WinUI.Windows.TrayService>();
					services.AddSingleton<INotificationService, WinUI.Windows.NotificationService>();
#elif MACCATALYST
					services.AddSingleton<ITrayService, Services.MacCatalyst.TrayService>();
#endif
				})
				.ConfigureFonts((fonts)=>
				{
					fonts.AddFont("fa-solid-900.ttf", "FontAwesome");
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
				});
		}
	}
}