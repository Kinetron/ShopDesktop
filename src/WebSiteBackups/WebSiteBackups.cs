using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbAdaptor;
using WebSiteBackups.Contracts;

namespace WebSiteBackups
{
	public class WebSiteBackups : IWebSiteBackups
	{
		private readonly IDbAdaptor _dbAdaptor;

		public WebSiteBackups(IDbAdaptor dbAdaptor)
		{
			_dbAdaptor = dbAdaptor;
		}

		public string Name { get; } = "Бэкап сайта";
		public void CreateBackup()
		{
			string login = _dbAdaptor.GetSettingValueAsync("BackupUser").Result;
			string password = _dbAdaptor.GetSettingValueAsync("BackupUserPassword").Result;
		}
	}
}
