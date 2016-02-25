using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using GalaSoft.MvvmLight.Views;
using ParisCoffee.Core;
using MapKit;
using CoreLocation;

namespace ParisCoffee.iOS
{
	partial class DetailController : ControllerBase
	{
		public const string StoryBoardId = "DetailController";
		public const string NavigationKey = "DetailController";

		protected DetailViewModel ViewModel { get { return AppDelegate.ViewModelLocator.DetailViewModel; } }


		public DetailController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var coffeshop = this.NavigationParameter as CoffeeShop;

			if (coffeshop != null) {

				lblName.Text = coffeshop.Name;
				lblAddress.Text = coffeshop.Address;

				this.ViewModel.InitVm (new MapHandle (mapView), coffeshop);
			}
		}
	}
}
