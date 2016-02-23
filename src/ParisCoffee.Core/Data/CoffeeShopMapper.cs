using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;


namespace ParisCoffee.Core
{
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
}

