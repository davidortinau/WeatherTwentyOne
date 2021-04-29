using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherTwentyOne.Services;

namespace WeatherTwentyOne.WinUI.Windows
{
	public class NotificationService : INotificationService
	{
		public void ShowNotification(string title)
		{
			new ToastContentBuilder()
				.AddToastActivationInfo(null, ToastActivationType.Foreground)
				.AddAppLogoOverride(new Uri("ms-appx:///Assets/dotnet_bot.png"))
				.AddText(title)
				.Show();
		}
	}
}
