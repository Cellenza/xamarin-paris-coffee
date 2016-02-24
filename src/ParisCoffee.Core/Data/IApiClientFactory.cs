using System;
using System.Net;
using System.Net.Http;

namespace ParisCoffee.Core
{
	public interface IApiClientFactory
	{
		HttpMessageHandler CreateApiClient();

		Uri ApiUrl { get; }
	}
}

