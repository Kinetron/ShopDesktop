using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSiteBackups.Contracts;

namespace WebSiteBackups
{
	public class WebSiteBackups : IWebSiteBackups
	{
		public string Name { get; } = "Бэкап сайта";
		public void CreateBackup()
		{
			throw new NotImplementedException();
		}
	}
}
