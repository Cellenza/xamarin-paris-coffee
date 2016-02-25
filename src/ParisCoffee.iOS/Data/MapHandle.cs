using System;
using ParisCoffee.Core;
using MapKit;
using CoreLocation;

namespace ParisCoffee.iOS
{
	public class MapHandle : IMapHandle
	{
		readonly MKMapView _mapView;

		public MapHandle (MKMapView mapView)
		{
			_mapView = mapView;
		}

		#region IMapHandle implementation

		public void AddAnnotation (CoffeeShop coffeeShop)
		{
			_mapView.AddAnnotation (new CoffeeShopAnnotation (coffeeShop));

		}

		public void ZoomTo (Coordinates coordinates)
		{
			var coords = new CLLocationCoordinate2D (coordinates.Longitude, 
				coordinates.Latitude);
			var span = new MKCoordinateSpan (Location.MilesToLatitudeDegrees(2), 
				Location.MilesToLongitudeDegrees (2, coords.Longitude));
			_mapView.Region = new MKCoordinateRegion (coords, span);
		}

		#endregion
	}
}

