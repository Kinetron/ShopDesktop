using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSiteBackups.Contracts
{
	public interface IWebSiteBackups
	{
		/// <summary>
		/// Module name.
		/// </summary>
		public string Name { get; }

		public void CreateBackup();
	}
}
