using System;
using MapKit;
using ParisCoffee.Core;
using CoreLocation;

namespace ParisCoffee.iOS
{
	public class CoffeeShopAnnotation : MKAnnotation
	{
		CoffeeShop _shop;
		CLLocationCoordinate2D _coords;

		public CoffeeShopAnnotation (CoffeeShop shop)
		{
			_shop = shop;
			_coords = new CLLocationCoordinate2D (_shop.Coordinates.Longitude, _shop.Coordinates.Latitude);
		}

		public override CoreLocation.CLLocationCoordinate2D Coordinate { get { return _coords; } }

		public override string Title { get { return _shop.Name; } }

		public override string Subtitle { get { return _shop.Address; } }
	}
}

