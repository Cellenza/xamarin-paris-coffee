using System;
using SQLite;

namespace ParisCoffee.Core
{
	public interface IDbProvider
	{
		SQLiteConnection GetDatabaseInstance();
	}
}

