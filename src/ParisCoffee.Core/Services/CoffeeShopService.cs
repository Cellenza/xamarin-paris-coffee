using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;

namespace ParisCoffee.Core
{
	public class CoffeeShopService : ICoffeeShopService
	{
		private readonly ICoffeeShopApiClientFactory _apiClientFactory;
		private readonly Uri _apiUrl;

		public CoffeeShopService (ICoffeeShopApiClientFactory apiClientFactory, 
		                          Uri apiUrl)
		{
			_apiClientFactory = apiClientFactory;
			_apiUrl = apiUrl;
		}


		public async Task<IEnumerable<CoffeeShop>> GetAllCoffeeShops ()
		{
			using (var client = new HttpClient( _apiClientFactory.CreateApiClient ())) {
				
				var jsonCoffeeShopResult = await client.GetStringAsync (_apiUrl.ToString());
			
				return jsonCoffeeShopResult.MapToCoffeeShop ();
			}
		}
	}
}

