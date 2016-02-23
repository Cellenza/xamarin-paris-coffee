using System;
using System.Linq;
using NUnit.Framework;
using ParisCoffee.Core;
using RichardSzalay.MockHttp;
using SQLite;
using System.Net.Http;

namespace ParisCoffee.Tests
{
	public class CoffeeShopServiceTests
	{
		ICoffeeShopApiClientFactory _apiClientFactory;
		ICoffeeShopService _service;

		[SetUp]
		public void Setup()
		{
			var mockApiUrl = new Uri ("http://cellenza.test.com");
			var  mockHttp = new MockHttpMessageHandler();

			mockHttp
				.When (mockApiUrl.ToString())

				.Respond ( "application/json", _samplie_json);

			_apiClientFactory = MockHelper.CreateClient (mockHttp);

		
			_service = new CoffeeShopService (_apiClientFactory, mockApiUrl);
			
		}




		[Test]
		public void Should_retrive_and_map_coffee_shop_from_api()
		{
			var result =  _service.GetAllCoffeeShops ().Result;

			Assert.AreEqual("Coffee Chope", result.ElementAt (0).Name);
		}

	

		const string _samplie_json =@"
{
    ""format"": ""json"",
    ""nhits"": 1,
    ""records"": [
        {
            ""datasetid"": ""liste-des-cafes-a-un-euro"",
            ""fields"": {
                ""adresse"": ""344 rue Vaugirard"",
                ""arrondissement"": 75015,
                ""date"": ""2014-02-01"",
                ""geoloc"": [
                    48.839471,
                    2.30286
                ],
                ""nom_du_cafe"": ""Coffee Chope"",
                ""prix_comptoir"": 1,
                ""prix_salle"": ""-"",
                ""prix_terasse"": ""-""
            },
            ""geometry"": {
                ""coordinates"": [
                    2.30286,
                    48.839471
                ],
                ""type"": ""Point""
            },
            ""record_timestamp"": ""2016-02-14T23:00:04+00:00"",
            ""recordid"": ""4588e58f447fb4dd5df12eafbaf7d9314decd475""
        }
    ],
    ""rows"": 10,
    ""timezone"": ""UTC""
}		
";
	}

}

