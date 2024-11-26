using Domain.Interfaces.IRepositories;
using Domain.IRepositories;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
	public class WrapperRepossitory : IWrapperRepossitory
	{
		public IProductRepository _ProductRepository ;

		public IOrderProductRepository _OrderProductRepository ;

		public IClientRepository _ClientRepository ;

		public IOrderRepository _OrderRepository ;

		public WrapperRepossitory() { }


		public IProductRepository ProductRepository
		{
			get
			{
				if (_ProductRepository == null)
				{
					_ProductRepository = new ProductRepository();
				}
				return _ProductRepository;
			}
		}

		public IOrderProductRepository OrderProductRepository
		{
			get
			{
				if (_OrderProductRepository == null)
				{
					_OrderProductRepository = new OrderProductRepository();
				}
				return _OrderProductRepository;
			}
		}

		public IClientRepository ClientRepository
		{
			get
			{
				if (_ClientRepository == null)
				{
					_ClientRepository = new ClientRepository();
				}
				return _ClientRepository;
			}
		}

		public IOrderRepository OrderRepository
		{
			get
			{
				if (_OrderRepository == null)
				{
					_OrderRepository = new OrderRepository();
				}
				return _OrderRepository;
			}
		}
	}
}
