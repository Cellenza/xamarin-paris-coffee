using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using ParisCoffee.Core;
using Microsoft.Practices.ServiceLocation;
using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Views;

namespace ParisCoffee.iOS
{
	partial class FavoritesController : UIViewController
	{
		ObservableTableViewController<CoffeeShop> _controller;

		protected ListViewModel ViewModel
		{
			get{ return AppDelegate.ViewModelLocator.ListViewModel;}
		}

		private INavigationService _navigationService;
		protected INavigationService NavigationService
		{
			get{return _navigationService = _navigationService ?? ServiceLocator.Current.GetInstance<INavigationService> (); }
		}

		public FavoritesController (IntPtr handle) : base (handle)
		{
		}
		public async override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			await ViewModel.InitVm ();

			_controller = ViewModel.CoffeeShops.GetController(CreateCell, UpdateCell);

			_controller.TableView = coffeeTableView;

			_controller.SelectionChanged += (object sender, EventArgs e) => 
			{
				if (NavigationService != null)
				{
					NavigationService.NavigateTo(DetailController.NavigationKey, _controller.SelectedItem);
				}

			};
		}


		UITableViewCell CreateCell(NSString cellidentifier)
		{
			return new UITableViewCell (UITableViewCellStyle.Subtitle, "coffee-shop-cell");
		}

		void UpdateCell(UITableViewCell cell, CoffeeShop shop, NSIndexPath indexPath)
		{
			cell.TextLabel.Text = shop.Name;
			cell.DetailTextLabel.Text = shop.Address;
		}
	}
}
