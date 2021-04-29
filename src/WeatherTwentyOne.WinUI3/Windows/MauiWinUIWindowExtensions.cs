using Microsoft.Maui;
using System;
using System.Runtime.InteropServices;
using WinRT;

namespace WeatherTwentyOne.WinUI
{
	public static class MauiWinUIWindowExtensions
	{
		public static IntPtr GetNativeWindowHandle(this MauiWinUIWindow window)
		{
			var nativeWindow = window.As<IWindowNative>();
			return nativeWindow.WindowHandle;
		}

		public static void BringToFront(this MauiWinUIWindow window)
		{
			var hwnd = window.GetNativeWindowHandle();

			PInvoke.User32.ShowWindow(hwnd, PInvoke.User32.WindowShowStyle.SW_SHOW);
			PInvoke.User32.ShowWindow(hwnd, PInvoke.User32.WindowShowStyle.SW_RESTORE);

			_ = PInvoke.User32.SetForegroundWindow(hwnd);
		}

		public static void MinimizeToTray(this MauiWinUIWindow window)
		{
			var hwnd = window.GetNativeWindowHandle();

			PInvoke.User32.ShowWindow(hwnd, PInvoke.User32.WindowShowStyle.SW_MINIMIZE);
			PInvoke.User32.ShowWindow(hwnd, PInvoke.User32.WindowShowStyle.SW_HIDE);
		}
	}

	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("EECDBF0E-BAE9-4CB6-A68E-9598E1CB57BB")]
	internal interface IWindowNative
	{
		IntPtr WindowHandle { get; }
	}
}
