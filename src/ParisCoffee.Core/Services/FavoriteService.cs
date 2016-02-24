using System;
using System.Collections.Generic;

namespace ParisCoffee.Core
{
	public class FavoriteService : IFavoriteService
	{
		private readonly IDbProvider _dbProvider;

		public FavoriteService (IDbProvider dbProvider)
		{
			_dbProvider = dbProvider;
		}

		public IEnumerable<FavoriteShop> GetFavoriteShops ()
		{
			return _dbProvider.GetDatabaseInstance ()
				.Query<FavoriteShop> ("select * from FavoriteShop");
		}

		public bool CheckFavoriteStatus (string coffeeShopId)
		{
			var fav = _dbProvider.GetDatabaseInstance ().Find<FavoriteShop> (shop => shop.Id == coffeeShopId);
			return fav != null;
		}

		public void AddToFavorites (string coffeeShopId)
		{
			_dbProvider.GetDatabaseInstance ().Insert (new FavoriteShop{ Id = coffeeShopId });
		}

		public void RemoveFromFavorites (string coffeeShopId)
		{
			_dbProvider.GetDatabaseInstance ().Delete<FavoriteShop> (coffeeShopId);
		}
	}
}

