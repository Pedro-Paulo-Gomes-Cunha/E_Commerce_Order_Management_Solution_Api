using Domain.DTOs;
using Domain.Interfaces.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IRepositories
{
	public interface IProductRepository 
	{
		IEnumerable<ProductDto> FindAll();
		void Save(ProductDto obj);
		ProductDto FindById(Guid id);
		void UpdateProduct(ProductDto obj);
		void RemoveProduct(Guid id);
	}
}
