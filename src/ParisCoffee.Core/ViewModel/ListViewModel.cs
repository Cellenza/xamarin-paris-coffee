using System;
using GalaSoft.MvvmLight;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Views;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace ParisCoffee.Core
{
	public class ListViewModel : ViewModelBase
	{
		private readonly ICoffeeShopService _coffeeService;
		private readonly IFavoriteService _favoriteService;

		private readonly INavigationService _navigationService;


		public ObservableCollection<CoffeeShop> CoffeeShops { get; private set; }

		public ListViewModel (ICoffeeShopService coffeeService, 
			IFavoriteService favoriteService, 
			INavigationService navigationService)
		{
			_coffeeService = coffeeService;
			_favoriteService = favoriteService;
			_navigationService = navigationService;
		}


		public async Task InitVm()
		{
			if (CoffeeShops != null && CoffeeShops.Any ()) {
				return;
			}
			var allcoffees = await _coffeeService.GetAllCoffeeShops ();

			if (allcoffees.Any ()) {

				CoffeeShops = new ObservableCollection<CoffeeShop> (allcoffees);
			}
		}

		private ICommand _selectedShopCommand;
		public ICommand SelectedShopCommand { get { return _selectedShopCommand = _selectedShopCommand ?? new RelayCommand(OnSelect);} }

		public void OnSelect()
		{
			_navigationService.NavigateTo ("Detail");
		}
	}
}

