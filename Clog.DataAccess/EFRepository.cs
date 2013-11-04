using Clog.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clog.Data
{
	public class EFRepository<T> : IRepository<T> where T : class
	{
		public EFRepository(DbContext dbContext)
		{
			DbContext = dbContext;
			DbSet = DbContext.Set<T>();
		}

		protected DbContext DbContext { get; set; }
		protected DbSet<T> DbSet { get; set; }

		public virtual IEnumerable<T> GetAll()
		{
			return DbSet.ToList();
		}

		public virtual void Add(T entity)
		{
			DbSet.Add(entity);
		}
	}
}
