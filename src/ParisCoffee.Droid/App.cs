using System;
using Android.App;

namespace ParisCoffee.Droid
{
	[Application]
	public class App : Application
	{
		public App (IntPtr javaRef, 
			Android.Runtime.JniHandleOwnership transfert)
			:base(javaRef, transfert)
		{
		}
		public override void OnCreate ()
		{
			base.OnCreate ();
			// ioc configuration
		}
	}
}

