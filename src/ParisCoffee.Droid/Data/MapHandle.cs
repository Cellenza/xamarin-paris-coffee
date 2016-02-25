using System;
using ParisCoffee.Core;

namespace ParisCoffee.Droid
{
	public class MapHandle : IMapHandle
	{
		public void AddAnnotation (CoffeeShop coffeeShop)
		{
			// missing compat lib + play services
			throw new NotImplementedException ();
		}
		public void ZoomTo (Coordinates coordinates)
		{
			throw new NotImplementedException ();
		}
	}
}

