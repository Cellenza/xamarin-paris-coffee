﻿using System;
using ParisCoffee.Core;
using System.Net.Http;

namespace ParisCoffee.Forms.iOS
{
	public class ApiFactory : IApiClientFactory
	{
		public System.Net.Http.HttpMessageHandler CreateApiClient ()
		{
			return new ModernHttpClient.NativeMessageHandler ();
		}

		public Uri ApiUrl {
			get {
				return new Uri ("http://opendata.paris.fr/api/records/1.0/search/?dataset=liste-des-cafes-a-un-euro");
			}
		}	
	}
}

