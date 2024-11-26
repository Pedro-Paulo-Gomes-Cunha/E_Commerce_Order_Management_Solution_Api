using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IServices
{
	public interface IServiceBase<TEntity> where TEntity : class
	{
		void Save(TEntity obj);
		TEntity FindById(Guid id);
		IEnumerable<TEntity> FindAll();
		void Update(TEntity obj);
		void Remove(Guid id);
		void Dispose();
	}
}
