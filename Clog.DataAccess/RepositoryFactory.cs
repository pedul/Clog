using Clog.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clog.Data
{
	public class RepositoryFactory : IRepositoryFactory
	{
		public DbContext DbContext { get; set; }

		protected Dictionary<Type, object> Repositories { get; private set; }

		public RepositoryFactory()
		{
			Repositories = new Dictionary<Type, object>();
		}

		public IRepository<T> GetRepositoryForEntityType<T>() where T : class
		{
			object repo;
			Repositories.TryGetValue(typeof(IRepository<T>), out repo);

			if (repo != null)
			{
				return (IRepository<T>)repo;
			}

			return MakeRepositoryForEntityType<T>();
		}

		protected IRepository<T> MakeRepositoryForEntityType<T>() where T : class
		{
			var repo = new EFRepository<T>(DbContext);
			Repositories[typeof(T)] = repo;

			return repo;
		}
	}
}
