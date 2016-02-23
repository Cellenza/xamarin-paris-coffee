using System;

namespace ParisCoffee.Core
{
	public interface ICoffeeShopDetailsViewModel
	{
		CoffeeShop CoffeeShop { get; }

		bool IsFavorite { get; }

		void AddOrRemoveToFavorites ();
	}
}
	