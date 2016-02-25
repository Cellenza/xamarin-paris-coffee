using System;
using ParisCoffee.Core;
using GalaSoft.MvvmLight.Views;

namespace ParisCoffee.Forms
{
	public interface IViewModelLocator
	{
		 ListViewModel ListViewModel {get;}

		 DetailViewModel DetailViewModel { get;}

		INavigationService InitializeNavigationService ();
	}
}

