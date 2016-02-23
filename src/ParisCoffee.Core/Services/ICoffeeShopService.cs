using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParisCoffee.Core
{
	public interface ICoffeeShopService
	{
		Task<IEnumerable<CoffeeShop>> GetAllCoffeeShops ();
	}
}

