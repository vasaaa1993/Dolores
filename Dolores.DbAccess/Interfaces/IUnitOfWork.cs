﻿using System.Threading.Tasks;

namespace Dolores.DbAccess.Interfaces
{
	public interface IUnitOfWork
	{
		IRepository<T> Repository<T>() where T : class, IEntity;
		void Save();
		Task SaveAsync();
	}
}
