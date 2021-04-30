using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace WeatherTwentyOne.Services.MacCatalyst
{
	public class TrayService : ITrayService
	{
		[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nfloat(IntPtr receiver, IntPtr selector, nfloat arg1);

		[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend(IntPtr receiver, IntPtr selector);

		[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr(IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_bool(IntPtr receiver, IntPtr selector, bool arg1);

		NSObject systemStatusBarObj;
		NSObject statusBarObj;
		NSObject statusBarItem;
		NSObject statusBarButton;
		NSObject statusBarImage;

		public Action ClickHandler { get; set; }

		public void Initialize()
		{
			statusBarObj = Runtime.GetNSObject(Class.GetHandle("NSStatusBar"));
			systemStatusBarObj = statusBarObj.PerformSelector(new Selector("systemStatusBar"));
			statusBarItem = Runtime.GetNSObject(IntPtr_objc_msgSend_nfloat(systemStatusBarObj.Handle, Selector.GetHandle("statusItemWithLength:"), -1));
			statusBarButton = Runtime.GetNSObject(IntPtr_objc_msgSend(statusBarItem.Handle, Selector.GetHandle("button")));
			statusBarImage = Runtime.GetNSObject(IntPtr_objc_msgSend(ObjCRuntime.Class.GetHandle("NSImage"), Selector.GetHandle("alloc")));

			var imgPath = System.IO.Path.Combine(NSBundle.MainBundle.BundlePath, "Contents", "trayicon.png");
			var imageFileStr = NSString.CreateNative(imgPath);
			var nsImagePtr = IntPtr_objc_msgSend_IntPtr(statusBarImage.Handle, Selector.GetHandle("initWithContentsOfFile:"), imageFileStr);

			void_objc_msgSend_IntPtr(statusBarButton.Handle, Selector.GetHandle("setImage:"), statusBarImage.Handle);
			void_objc_msgSend_bool(nsImagePtr, Selector.GetHandle("setTemplate:"), true);
		}
	}
}
