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
	public class OrderProductRepository : BaseRepository<OrderProductDbo>, IOrderProductRepository
	{
		public IEnumerable<OrderProductDto> FindAll()
		{
			throw new NotImplementedException();
		}

		public OrderProductDto FindById(Guid id)
		{
			throw new NotImplementedException();
		}

		public void RemoveOrderProdutc(Guid id)
		{
			throw new NotImplementedException();
		}

		public void Save(OrderProductDto obj)
		{
			throw new NotImplementedException();
		}

		public void UpdateOrderProduct(OrderProductDto obj)
		{
			throw new NotImplementedException();
		}
	}
}
