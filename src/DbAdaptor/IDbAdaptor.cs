namespace DbAdaptor
{
	public interface IDbAdaptor
	{
		/// <summary>
		/// Create database structure.
		/// </summary>
		void InitDb();

		/// <summary>
		/// Get setting value from Db.
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		Task<string> GetSettingValueAsync(string key);
	}
}
