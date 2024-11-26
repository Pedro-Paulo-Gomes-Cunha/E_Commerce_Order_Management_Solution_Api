using Data.Context;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
	public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
	{
		protected Context_Ecommerce Db= new();

		public void Add(TEntity obj)
		{
			Db.Set<TEntity>().Add(obj);

			Db.SaveChanges();
		}

		public TEntity GetById(Guid id)
		{
			return Db.Set<TEntity>().Find(id);
		}

		public IEnumerable<TEntity> GetAll()
		{
			return Db.Set<TEntity>().ToList();
		}

		public void Update(TEntity obj)
		{
			Db.Entry(obj).State = EntityState.Modified;

			Db.SaveChanges();
		}

		public void Remove(TEntity obj)
		{
			Db.Set<TEntity>().Remove(obj);

			Db.SaveChanges();
		}

		public void Dispose()
		{

		}
	}
}
