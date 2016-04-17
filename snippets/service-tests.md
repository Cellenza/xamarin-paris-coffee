
## Testing session walkthrough

* [ ] Discover [NUnit](http://nunit.org/) - [NSubstitue](http://nsubstitute.github.io/)

  * How to mock http request ?
* [ ] Integration of the local db [sqlite3 library](https://www.nuget.org/packages/sqlite-net-pcl/)
* [ ] Integration of the .net [http client library](https://blogs.msdn.microsoft.com/bclteam/p/httpclient/)  
* [ ] Integration of the [json.net deserialization lib](http://www.newtonsoft.com)


## Feature tests 

* Testing the favorite service :  

```cs
	  [Test]
		public void Should_retrive_favorite_shops_from_storage()
		{
		  // ...
		    var result = _service.GetFavoriteShops ();
		  // add related assertions (i.e : result should contain some data)
		}

	  [Test]
		public void Should_get_favorite_status()
		{
		  // ...
		    var result = _service.CheckFavoriteStatus (id); 
		  // add related assertions (i.e : result should be true or false depending on the context)
		}
		
	  [Test]
		public void Should_add_favorite()
		{
		  // ...
		    _service.AddToFavorites (id); 
		  // add related assertions (i.e : id added should be found in database)
		}

	  [Test]
		public void Should_remove_favorite()
		{
		  // ...
		    _service.RemoveFromFavorites (id); 
		  // add related assertions (i.e : id added should not be found in database)
		}
```

* Testing the coffee shop service :  

```cs

		[Test]
		public void Should_retrive_and_map_coffee_shop_from_api()
		{
		  // given any context
			var result = _service.GetAllCoffeeShops ();
			
			// add relate assertion (i.e : result should contains at least one shop)
		}
```
