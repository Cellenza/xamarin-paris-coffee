

Class implementations

```cs

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

```

Test setup

```cs

		private void AddOneItemToDb(string itemId)
		{
			var id = itemId;
			_db.Insert (new FavoriteShop{ Id = id });
		}

		[TestCase("some-id1")]
		[TestCase("some-id2")]
		[TestCase("some-id3")]
		public void Should_retrive_favorite_shops_from_storage_when_there_is_one_entry(string id)
		{
			AddOneItemToDb (id);

			var result = _service.GetFavoriteShops ().ToArray();

			Assert.AreEqual (id, result.ElementAt (0).Id);
		}

		[TestCase("some-id")]
		public void Should_get_favorite_status(string id)
		{
			AddOneItemToDb (id);

			var result = _service.CheckFavoriteStatus (id);

			Assert.True(result);
		}

		[Test]
		public void Should_add_favorite()
		{
			var id = "some-id";

			_service.AddToFavorites (id);

			Assert.NotNull (_db.Find<FavoriteShop> (shop => shop.Id == id));
		}

		[TestCase("some-id")]
		public void Should_remove_favorite(string id)
		{
			AddOneItemToDb (id);

			_service.RemoveFromFavorites (id);

			Assert.Null (_db.Find<FavoriteShop> (shop => shop.Id == id));
		}

		[TestCase("some-0d", "some-Od")]
		public void Should_not_remove_favorite_when_i_remove_wrong_id(string id, string wrongId)
		{
			AddOneItemToDb (id);

			_service.RemoveFromFavorites (wrongId);

			Assert.IsNotNull (_db.Find<FavoriteShop> (shop => shop.Id == id));
		}
```

Mappper

```cs

	public static class CoffeeSopMapper
	{
		public static IEnumerable<CoffeeShop> MapToCoffeeShop (this string json)
		{
			var data = JsonConvert.DeserializeObject (json) as JObject;

			foreach (var record in data["records"]) {

				var fields = (record as JObject) ["fields"];

				yield return new CoffeeShop {
					Name = fields ["nom_du_cafe"].Value<string> (),
					Address =fields ["adresse"].Value<string> (),
					Id = record["recordid"].Value<string>()
				};
			}
		}
	}

```
