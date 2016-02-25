using System;
using System.Collections.Generic;

using Xamarin.Forms;
using ParisCoffee.Core;

namespace ParisCoffee.Forms
{
	public partial class CoffeeList : TabbedPage
	{
		ListViewModel ViewModel { get { return ((App)App.Current).ViewModelLocator.ListViewModel;} }
		
		public CoffeeList ()
		{
			InitializeComponent ();
		

			BindingContext = ViewModel;
		}

		protected override async void OnAppearing ()
		{
			base.OnAppearing ();
			await ViewModel.InitVm ();

		}
	}
}

