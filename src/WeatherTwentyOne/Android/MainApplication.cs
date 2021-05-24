using System;
using Android.App;
using Android.Runtime;
using Microsoft.Maui;

namespace WeatherTwentyOne
{
	[Application]
	public class MainApplication : MauiApplication<Startup>
	{
		public MainApplication(IntPtr handle, JniHandleOwnership ownership)
			: base(handle, ownership)
		{
			
		}

		public override void OnCreate()
		{
			Java.Lang.JavaSystem.LoadLibrary("System.Security.Cryptography.Native.OpenSsl");
			base.OnCreate();
		}
	}
}