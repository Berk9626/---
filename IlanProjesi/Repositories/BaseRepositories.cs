using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IlanProjesi.Data;
using Microsoft.EntityFrameworkCore;

namespace IlanProjesi.Repositories
{
	public class BaseRepositories<T> : IBaseRepositories<T> where T : class, new()
	{
		static AllData _db;
		public BaseRepositories(AllData db)
		{
			_db = db;

		}
		public async Task<bool> Comit()
		{
			return await _db.SaveChangesAsync() > 0;
		}

		public void Delete(T entity)
		{
			_db.Entry(entity).State = EntityState.Deleted;
		}

		public void Entry(T entity)
		{
			_db.Entry(entity).State = EntityState.Added;
		}

		public async Task<T> Find(int id)
		{
			return await Set().FindAsync(id);
		}

		public async Task<ICollection<T>> List()
		{
			return await Set().ToListAsync();
		}

		public DbSet<T> Set()
		{
			return _db.Set<T>();
		}

		public void Update(T entity)
		{
			_db.Entry(entity).State = EntityState.Modified;
		}
	}
}
