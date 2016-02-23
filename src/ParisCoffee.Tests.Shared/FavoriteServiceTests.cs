using System;
using NUnit.Framework;

using ParisCoffee.Core;
using SQLite;
using System.Linq;

namespace ParisCoffee.Tests
{
	
	public class FavoriteServiceTests
	{
		IFavoriteService _service;
		SQLiteConnection _db;

		[SetUp]
		public void Setup()
		{
			_db = new SQLiteConnection ("dbtest");
			_db.CreateTable<FavoriteShop> ();

			_service = new FavoriteService (MockHelper.CreateDbProvider(_db));

		}

		[TearDown]
		public void TearDown()
		{
			_db.DeleteAll<FavoriteShop> ();
			_db.Dispose ();
		}

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

	}
}

