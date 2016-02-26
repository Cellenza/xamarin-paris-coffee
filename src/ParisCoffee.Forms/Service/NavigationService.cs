using System;
using GalaSoft.MvvmLight.Views;
using Xamarin.Forms;

namespace ParisCoffee.Forms
{
	public class NavigationService : INavigationService
	{
		INavigation _nav;

		public NavigationService (INavigation nav)
		{
			_nav = nav;
			
		}
		#region INavigationService implementation
		public void GoBack ()
		{
			_nav.PopAsync ();
		}
		public void NavigateTo (string pageKey)
		{
			throw new NotImplementedException ();
		}
		public void NavigateTo (string pageKey, object parameter)
		{
			throw new NotImplementedException ();
		}
		public string CurrentPageKey {
			get {
				throw new NotImplementedException ();
			}
		}
		#endregion
		
	}
}

