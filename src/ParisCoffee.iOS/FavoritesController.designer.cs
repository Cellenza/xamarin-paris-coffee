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
	[Register ("FavoritesController")]
	partial class FavoritesController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView coffeeTableView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (coffeeTableView != null) {
				coffeeTableView.Dispose ();
				coffeeTableView = null;
			}
		}
	}
}
