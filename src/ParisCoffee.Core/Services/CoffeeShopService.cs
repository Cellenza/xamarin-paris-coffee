using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ParisCoffee.Core
{
	public class CoffeeShopService : ICoffeeShopService
	{
		private readonly IApiClientFactory _apiClientFactory;

		public CoffeeShopService (IApiClientFactory apiClientFactory)
		{
			_apiClientFactory = apiClientFactory;
		}


		public async Task<IEnumerable<CoffeeShop>> GetAllCoffeeShops ()
		{
			using (var client = new HttpClient( _apiClientFactory.CreateApiClient ())) {
				
				var jsonCoffeeShopResult = await client.GetStringAsync (_apiClientFactory.ApiUrl.ToString());
			
				return jsonCoffeeShopResult.MapToCoffeeShop ();
			}
		}
	}
}

