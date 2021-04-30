using Microsoft.Maui;
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;

namespace WeatherTwentyOne
{
	public static class AppHostExtensions
	{
		public static IAppHostBuilder UseCompatibility(this IAppHostBuilder builder)
			=> builder
				.UseFormsCompatibility()
				.UseMauiControlsHandlers()
				.ConfigureMauiHandlers(handlers =>
				{
#if WINDOWS10_0_17763_0_OR_GREATER
					handlers.AddCompatibilityRenderer<ImageButton,
						Microsoft.Maui.Controls.Compatibility.Platform.UWP.ImageButtonRenderer>();
#elif ANDROID
					handlers.AddCompatibilityRenderer<ImageButton,
						Microsoft.Maui.Controls.Compatibility.Platform.Android.ImageButtonRenderer>();
#elif IOS || MACCATALYST
					handlers.AddCompatibilityRenderer<ImageButton,
						Microsoft.Maui.Controls.Compatibility.Platform.iOS.ImageButtonRenderer>();
#endif
				});
	}
}
