using Domain.DTOs;
using Domain.Interfaces.IEntities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IServices
{
	public class ProductService : IProductService
	{
		IWrapperRepossitory _repositoryWrapper;
		public ProductService(IWrapperRepossitory repositoryWrapper)
		{
			this._repositoryWrapper = repositoryWrapper;
		}
		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ProductDto> FindAll()
		{
			return this._repositoryWrapper.ProductRepository.FindAll();
		}

		public ProductDto FindById(Guid id)
		{
			return this._repositoryWrapper.ProductRepository.FindById(id);
		}

		public void Remove(Guid id)
		{
			throw new NotImplementedException();
		}

		public void Save(ProductDto obj)
		{
			this._repositoryWrapper.ProductRepository.Save(obj);
		}

		public void Update(ProductDto obj)
		{
			throw new NotImplementedException();
		}
	}
}
