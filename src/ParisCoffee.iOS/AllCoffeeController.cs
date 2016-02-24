using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using ParisCoffee.Core;
using Microsoft.Practices.ServiceLocation;

namespace ParisCoffee.iOS
{
	partial class AllCoffeeController : UIViewController
	{
		private ListViewModel _viewModel;

		protected ListViewModel ViewModel {
			get{ return _viewModel = _viewModel ?? ServiceLocator.Current.GetInstance<ListViewModel> (); }
		}

		public AllCoffeeController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.ViewModel.InitVm ();
		}
	}
}
