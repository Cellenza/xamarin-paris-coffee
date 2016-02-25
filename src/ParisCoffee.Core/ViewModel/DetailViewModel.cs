using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace ParisCoffee.Core
{
	public class DetailViewModel : ViewModelBase
	{
		readonly IFavoriteService _favoriteService;

		public DetailViewModel (IFavoriteService favoriteService)
		{
			_favoriteService = favoriteService;
		}

		public void InitVm(IMapHandle mapHandle, CoffeeShop coffeeShop)
		{
			mapHandle.AddAnnotation (coffeeShop);
			mapHandle.ZoomTo (coffeeShop.Coordinates);
		}
		
	}

}


