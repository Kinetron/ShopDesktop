using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbAdaptor;
using Lamar;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ShopDesktop
{
	/// <summary>
	/// DI container.
	/// </summary>
	public static class IoC
	{
		private static readonly Container _container;

		/// <summary>
		/// Fill DI container.
		/// </summary>
		static IoC()
		{
			IConfigurationBuilder configurationBuilder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
			IConfiguration config = configurationBuilder.Build();

			_container = new Container(x =>
			{
				x.AddSingleton<IConfiguration>(x =>config);

				//Service for access to Db.
				x.AddSingleton<IDbAdaptor>(x=>new SqLiteAdaptor(config["DbStrings:Path"]));
			});
		}

		/// <summary>
		/// Return service from DI container.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public static T Get<T>()
		{
			return _container.GetInstance<T>();
		}
	}
}
