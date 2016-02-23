using System;
using System.Collections.Generic;

namespace ParisCoffee.Core
{
	public interface IFavoriteService
	{
		IEnumerable<FavoriteShop> GetFavoriteShops();

		bool CheckFavoriteStatus (string coffeeShopId);

		void AddToFavorites(string coffeeShopId);

		void RemoveFromFavorites(string coffeeShopId);
	}
}

