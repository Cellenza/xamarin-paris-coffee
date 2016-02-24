// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ParisCoffee.iOS
{
	[Register ("DetailController")]
	partial class DetailController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblAddress { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblName { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MapKit.MKMapView mapView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (lblAddress != null) {
				lblAddress.Dispose ();
				lblAddress = null;
			}
			if (lblName != null) {
				lblName.Dispose ();
				lblName = null;
			}
			if (mapView != null) {
				mapView.Dispose ();
				mapView = null;
			}
		}
	}
}
