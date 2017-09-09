using Dolores.DbAccess.EF;
using Dolores.DbAccess.Interfaces;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Dolores.DbAccess.Access
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly DbContext _dataContext = new DoloresDbContext();

		public IRepository<T> Repository<T>() where T : class, IEntity
		{
			return new Repository<T>(_dataContext);
		}

		public void Save()
		{
			_dataContext.SaveChanges();
		}

		public async Task SaveAsync()
		{
			await _dataContext.SaveChangesAsync();
		}

		public void Dispose()
		{
			_dataContext.Dispose();
		}
	}
}
