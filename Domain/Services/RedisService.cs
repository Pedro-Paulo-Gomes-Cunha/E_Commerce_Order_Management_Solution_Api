using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
	public class RedisService
	{
		private readonly ConnectionMultiplexer _connectionMultiplexer;
		private readonly IDatabase _database;

		public RedisService(string connectionString)
		{
			_connectionMultiplexer = ConnectionMultiplexer.Connect(connectionString);
			_database = _connectionMultiplexer.GetDatabase();
		}

		public void SetCacheValue(string key, string value)
		{
			_database.StringSet(key, value);
		}

		public string GetCacheValue(string key)
		{
			return _database.StringGet(key);
		}
		public bool KeyExists(string key)
		{
			return _database.KeyExists(key);
		}
	}
}
