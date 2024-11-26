using Domain.DTOs;
using Domain.Interfaces.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepositories
{
	public interface IOrderRepository 
	{
		IEnumerable<OrderDto> FindAll();
		void Save(OrderDto obj);
		OrderDto FindById(Guid id);
		void UpdateOrder(OrderDto obj);
		void RemoveOrder(Guid id);
	}
}
