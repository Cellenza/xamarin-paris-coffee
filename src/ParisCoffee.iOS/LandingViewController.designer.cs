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
	[Register ("LandingViewController")]
	partial class LandingViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView imgBackground { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblNamFromViewModel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (imgBackground != null) {
				imgBackground.Dispose ();
				imgBackground = null;
			}
			if (lblNamFromViewModel != null) {
				lblNamFromViewModel.Dispose ();
				lblNamFromViewModel = null;
			}
		}
	}
}
