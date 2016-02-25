using System;
using ParisCoffee.Core;
using SQLite;

namespace ParisCoffee.Droid
{
	public class DbProvider : IDbProvider
	{
		readonly SQLiteConnection _db;

		public DbProvider ()
		{
			_db = null;// new SQLiteConnection ("my_db_location");
		}



		public SQLiteConnection GetDatabaseInstance ()
		{
			return _db;
		}

	}
}

