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
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btntoto { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbltoto { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btntoto != null) {
				btntoto.Dispose ();
				btntoto = null;
			}
			if (lbltoto != null) {
				lbltoto.Dispose ();
				lbltoto = null;
			}
		}
	}
}
