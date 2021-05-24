using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Extensions.DependencyInjection;
using WeatherTwentyOne.Services;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace WeatherTwentyOne
{
	public class Startup : IStartup
	{
		public void Configure(IAppHostBuilder appBuilder)
		{
			System.AppContext.SetSwitch("System.Net.Http.UseNativeHttpHandler", true);
			appBuilder
                .ConfigureAppConfiguration(config => {
                    config.AddInMemoryCollection(
                        new Dictionary<string, string>
                        {
                            {"DefaultLocation", "St. Louis"}
                        }
                     );
                })
				.UseCompatibility()
				.UseMauiApp<App>()
                .UseMauiServiceProviderFactory(true)
				.ConfigureServices(services =>
				{
#if WINDOWS
					services.AddSingleton<ITrayService, WinUI.Windows.TrayService>();
					services.AddSingleton<INotificationService, WinUI.Windows.NotificationService>();
#elif MACCATALYST
					services.AddSingleton<ITrayService, MacCatalyst.TrayService>();
					services.AddSingleton<INotificationService, MacCatalyst.NotificationService>();
#endif
				})
				.ConfigureFonts((fonts)=>
				{
					fonts.AddFont("fa-solid-900.ttf", "FontAwesome");
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
				})
                ;

		}
	}
}