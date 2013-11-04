using Clog.Data.Contracts;
using Clog.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clog.Data
{
	public class ClogUnitOfWork : IClogUnitOfWork
	{
		private IRepositoryFactory RepositoryFactory { get; set; }

		public ClogUnitOfWork(IRepositoryFactory repositoryFactory)
		{
			CreateDbContext();

			repositoryFactory.DbContext = DbContext;
			RepositoryFactory = repositoryFactory;
		}

		public DbContext DbContext { get; set; }

		public IRepository<Log> Logs { get { return GetRepositoryForEntityType<Log>(); } }

		public void Commit()
		{
			DbContext.SaveChanges();
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		private void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (DbContext != null)
				{
					DbContext.Dispose();
				}
			}
		}

		protected void CreateDbContext()
		{
			DbContext = new ClogContext();
		}

		protected IRepository<T> GetRepositoryForEntityType<T>() where T : class
		{
			return RepositoryFactory.GetRepositoryForEntityType<T>();
		}
	}
}
