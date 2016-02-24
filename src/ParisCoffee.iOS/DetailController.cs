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

				this.mapView.AddAnnotation (new CoffeeShopAnnotation (coffeshop));

				var coords = new CLLocationCoordinate2D (coffeshop.Coordinates.Longitude, coffeshop.Coordinates.Latitude);
				var span = new MKCoordinateSpan (Location.MilesToLatitudeDegrees(2), 
					Location.MilesToLongitudeDegrees (2, coords.Longitude));
				mapView.Region = new MKCoordinateRegion (coords, span);
			}
		}
	}
}
