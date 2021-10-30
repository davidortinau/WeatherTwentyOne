using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml;
using WinRT;

namespace WeatherTwentyOne
{
    public static class WindowExtensions
    {
        public static IntPtr GetNativeWindowHandle(this Window window)
        {
            var nativeWindow = window.As<IWindowNative>();
            return nativeWindow.WindowHandle;
        }

        public static void SetIcon(this Window window, string iconFilename)
        {
            var hwnd = window.GetNativeWindowHandle();

            var hIcon = PInvoke.User32.LoadImage(IntPtr.Zero, iconFilename,
               PInvoke.User32.ImageType.IMAGE_ICON, 16, 16, PInvoke.User32.LoadImageFlags.LR_LOADFROMFILE);

            PInvoke.User32.SendMessage(hwnd, PInvoke.User32.WindowMessage.WM_SETICON, (IntPtr)0, hIcon);
        }

        public static void BringToFront(this Window window)
        {
            var hwnd = window.GetNativeWindowHandle();

            PInvoke.User32.ShowWindow(hwnd, PInvoke.User32.WindowShowStyle.SW_SHOW);
            PInvoke.User32.ShowWindow(hwnd, PInvoke.User32.WindowShowStyle.SW_RESTORE);

            _ = PInvoke.User32.SetForegroundWindow(hwnd);
        }

        public static void MinimizeToTray(this Window window)
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
