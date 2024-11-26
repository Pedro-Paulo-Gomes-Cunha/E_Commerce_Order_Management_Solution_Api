using Domain.DTOs;
using Domain.Interfaces.IEntities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;
using Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
	public class OrderService : IOrderService
	{
		IWrapperRepossitory _repositoryWrapper;
		public OrderService(IWrapperRepossitory repositoryWrapper)
		{
			this._repositoryWrapper = repositoryWrapper;
		}
		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<OrderDto> FindAll()
		{
			return this._repositoryWrapper.OrderRepository.FindAll();
		}

		public OrderDto FindById(Guid id)
		{
			return this._repositoryWrapper.OrderRepository.FindById(id);
		}

		public void Remove(Guid id)
		{
			throw new NotImplementedException();
		}

		public void Save(OrderDto obj)
		{
			this._repositoryWrapper.OrderRepository.Save(obj);
		}

		public void Update(OrderDto obj)
		{
			this._repositoryWrapper.OrderRepository.UpdateOrder(obj);
		}
	}
}
