using System.Data;
using Dapper;
using Microsoft.Data.Sqlite;

namespace DbAdaptor
{
	/// <summary>
	/// Common methods for work with SqLite Db.
	/// </summary>
	public class SqLiteAdaptor : IDbAdaptor
	{
		private readonly string _dbPath;

		public SqLiteAdaptor(string dbPath)
		{
			_dbPath = dbPath;
		}

		public IDbConnection CreateConnection()
		{
			return new SqliteConnection($"Data Source={_dbPath}");
		}
		
		/// <summary>
		/// Create database structure.
		/// </summary>
		public void InitDb()
		{
			InitSetting();
		}

		/// <summary>
		/// Init table contains application settings.
		/// </summary>
		private async void InitSetting()
		{
			using var connection = CreateConnection();
			var sql = @"
				CREATE TABLE IF NOT EXISTS 
					Settings (
						Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
						Key TEXT,
						Value TEXT
					);
				";
			
			await connection.ExecuteAsync(sql);
		}

		/// <summary>
		/// Get setting value from Db.
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public async Task<string> GetSettingValueAsync(string key)
		{
			using (var connection = CreateConnection())
			{
				string sql = "SELECT Value FROM Settings WHERE Key = @key";

				var result = await connection.QueryAsync<string>(sql, new { key = key });
				return result.FirstOrDefault();
			}
		}
	}
}
