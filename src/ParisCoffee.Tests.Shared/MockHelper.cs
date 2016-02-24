using System;
using ParisCoffee.Core;
using System.Net.Http;
using SQLite;

namespace ParisCoffee.Tests
{
	public class MockCoffeeShopApiClientFactory : IApiClientFactory
	{
		public Uri ApiUrl {
			get {
				return new Uri("http://test.test.com");
			}
		}

		#region ICoffeeShopApiClientFactory implementation

		HttpMessageHandler _messageHandlerToUse;

		public MockCoffeeShopApiClientFactory (HttpMessageHandler messageHandlerToUse)
		{
			_messageHandlerToUse = messageHandlerToUse;
		}

		public HttpMessageHandler CreateApiClient ()
		{
			return _messageHandlerToUse;
		}
		#endregion
		/*

	
		public System.Net.Http.HttpClient CreateApiClient ()
		{
			return new System.Net.Http.HttpClient (_messageHandlerToUse);
		}*/

	}


	public class MockDbProvider: IDbProvider
	{
		#region IDbProvider implementation

		SQLiteConnection _dbToReturn;

		public MockDbProvider (SQLiteConnection dbToReturn)
		{
			_dbToReturn = dbToReturn;
		}

		public SQLiteConnection GetDatabaseInstance ()
		{
			return _dbToReturn;
		}

		#endregion


	}

	public static class MockHelper
	{

		public static IApiClientFactory CreateClient(HttpMessageHandler messageHandlerToUse)
		{
			return new MockCoffeeShopApiClientFactory(messageHandlerToUse);
		}

		public static IDbProvider CreateDbProvider(SQLiteConnection databaseToReturn)
		{
			return new MockDbProvider (databaseToReturn);
		}

	}
}

