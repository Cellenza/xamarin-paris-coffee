using System;
using System.Net;
using System.Net.Http;

namespace ParisCoffee.Core
{
	public interface ICoffeeShopApiClientFactory
	{
		HttpMessageHandler CreateApiClient();
	}
}

