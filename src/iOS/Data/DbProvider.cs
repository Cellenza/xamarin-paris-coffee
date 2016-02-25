using System;
using SQLite;
using ParisCoffee.Core;
using Foundation;

namespace ParisCoffee.Forms.iOS
{
	public class DbProvider : IDbProvider
	{
		private readonly SQLiteConnection _dbConnection;
		public DbProvider ()
		{
			_dbConnection = new SQLiteConnection ("my_db_location");
		}

		public SQLiteConnection GetDatabaseInstance ()
		{
			return _dbConnection;
		}
	}
}

