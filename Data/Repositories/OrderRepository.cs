using Data.Repositories;
using Domain.DBOs;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepositories
{
	public class OrderRepository : BaseRepository<OrderDbo>, IOrderRepository
	{
		public IEnumerable<OrderDto> FindAll()
		{
			return GetAll().Select(x=>x.toDto());
		}

		public OrderDto FindById(Guid id)
		{
			return GetById(id)?.toDto();
		}

		public void RemoveOrder(Guid id)
		{
			throw new NotImplementedException();
		}

		public void Save(OrderDto obj)
		{
			Add(toDbo(obj));
		}

		public void UpdateOrder(OrderDto obj)
		{
			var copy= GetById(obj.Id)?.toDto();
			if(copy != null)
			{
				obj.status = copy.status;
			}
		}
		private OrderDbo toDbo(OrderDto dto)
		{
			return new OrderDbo(dto.Id, dto.ClientId, dto.Total, dto.status);
		}
	}
}
