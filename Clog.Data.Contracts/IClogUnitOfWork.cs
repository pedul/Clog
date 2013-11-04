using Clog.Model;
using System;

namespace Clog.Data.Contracts
{
	public interface IClogUnitOfWork : IDisposable
	{
		void Commit();

		IRepository<Log> Logs { get; }
	}
}
