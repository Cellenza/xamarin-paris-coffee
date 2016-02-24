using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;


namespace ParisCoffee.Core
{
	public static class CoffeeShopMapper
	{
		public static IEnumerable<CoffeeShop> MapToCoffeeShop (this string json)
		{
			var data = JsonConvert.DeserializeObject (json) as JObject;

			foreach (var record in data["records"]) {

				var fields = (record as JObject) ["fields"];
				var localisation = (record as JObject) ["geometry"] as JObject;
				var coordinates = localisation ["coordinates"] as JArray;


				yield return new CoffeeShop {
					Name = fields ["nom_du_cafe"].Value<string> (),
					Address =fields ["adresse"].Value<string> (),
					Id = record["recordid"].Value<string>(),
					Coordinates = new Coordinates{
						Latitude =	coordinates.ElementAt(0) .Value<double>(),
						Longitude = coordinates.ElementAt(1).Value<double>()
					}
				};
			}
		}
	}
}

