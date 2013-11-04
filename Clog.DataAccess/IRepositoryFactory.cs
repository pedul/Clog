using Clog.Data.Contracts;
using System;
using System.Data.Entity;

namespace Clog.Data
{
	public interface IRepositoryFactory
	{
		DbContext DbContext { get; set; }

		IRepository<T> GetRepositoryForEntityType<T>() where T : class;
	}
}