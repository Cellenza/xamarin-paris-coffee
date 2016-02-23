using Foundation;
using UIKit;

namespace ParisCoffee.Tests.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register ("AppDelegate")]
	public class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();            

			// This will load all tests within the current project
			var nunit = new NUnit.Runner.App();

		
			// If you want to add tests in another assembly
			//nunit.AddTestAssembly(typeof(MyTests).Assembly);

			// Do you want to automatically run tests when the app starts?
			nunit.AutoRun = true;

			LoadApplication(nunit);

			return base.FinishedLaunching(app, options);
		}
	}
}


