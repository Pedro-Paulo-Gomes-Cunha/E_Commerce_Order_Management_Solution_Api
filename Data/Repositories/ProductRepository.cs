using Data.Repositories;
using Domain.DBOs;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IEntities;
using Domain.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
	public class ProductRepository : BaseRepository<ProductDbo>, IProductRepository
	{
		public IEnumerable<ProductDto> FindAll()
		{
			throw new NotImplementedException();
		}

		public ProductDto FindById(Guid id)
		{
			throw new NotImplementedException();
		}

		public void RemoveProduct(Guid id)
		{
			throw new NotImplementedException();
		}

		public void Save(ProductDto obj)
		{
			throw new NotImplementedException();
		}

		public void UpdateProduct(ProductDto obj)
		{
			throw new NotImplementedException();
		}
	}
}
