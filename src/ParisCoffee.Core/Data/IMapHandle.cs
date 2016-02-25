using System;

namespace ParisCoffee.Core
{
	public interface IMapHandle
	{
		void AddAnnotation(CoffeeShop coffeeShop);


		void ZoomTo (Coordinates coordinates);

	}
}

