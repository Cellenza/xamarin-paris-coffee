using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Microsoft.Practices.ServiceLocation;
using ParisCoffee.Core;

using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Views;
using GalaSoft.MvvmLight.Ioc;

namespace ParisCoffee.iOS
{
	partial class LandingViewController : UIViewController
	{
		public LandingViewController (IntPtr handle) : base (handle)
		{
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			if (!SimpleIoc.Default.IsRegistered<INavigationService> ()) {

				NavigationService nav = new NavigationService ();
				nav.Initialize (this.NavigationController);

				nav.Configure (DetailController.NavigationKey, DetailController.StoryBoardId);
				SimpleIoc.Default.Register<INavigationService> (() => nav);
			}
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			this.NavigationController.NavigationBarHidden = true;
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			this.NavigationController.NavigationBarHidden = false;
		}
	}
}
