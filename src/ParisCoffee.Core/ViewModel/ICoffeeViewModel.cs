using System;
using System.Collections.Generic;

namespace ParisCoffee.Core
{
	public interface ICoffeeViewModel
	{
		IEnumerable<CoffeeShop> CoffeeShops { get; }

		IEnumerable<CoffeeShop> FavouriteCoffeeShops { get; }
	}
}

