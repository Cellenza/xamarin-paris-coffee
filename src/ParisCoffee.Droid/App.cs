using System;
using Android.App;
using ParisCoffee.Droid.ViewModel;
using GalaSoft.MvvmLight.Views;
using GalaSoft.MvvmLight.Ioc;

namespace ParisCoffee.Droid
{
	[Application]
	public class App : Application
	{

		private static readonly ViewModelLocator _locator = new ViewModelLocator ();
		public static ViewModelLocator ViewModelLocator { get { return _locator; } }


		public App (IntPtr javaRef, 
			Android.Runtime.JniHandleOwnership transfert)
			:base(javaRef, transfert)
		{
		}
		public override void OnCreate ()
		{
			base.OnCreate ();
			// ioc configuration
			var navigationService = new NavigationService();

			navigationService.Configure (DetailActivity.NavigationKey, typeof(DetailActivity));

			SimpleIoc.Default.Register<INavigationService>(() => navigationService);

		}
	}
}

