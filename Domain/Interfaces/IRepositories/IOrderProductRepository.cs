using Domain.DTOs;
using Domain.Interfaces.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepositories
{
	public interface IOrderProductRepository 
	{
		IEnumerable<OrderProductDto> FindAll();
		void Save(OrderProductDto obj);
		OrderProductDto FindById(Guid id);
		void UpdateOrderProduct(OrderProductDto obj);
		void RemoveOrderProdutc(Guid id);
	}
}
