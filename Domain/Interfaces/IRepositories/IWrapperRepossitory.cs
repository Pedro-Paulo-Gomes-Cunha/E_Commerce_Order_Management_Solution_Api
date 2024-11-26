using Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IRepositories
{
	public interface IWrapperRepossitory
	{
		IProductRepository ProductRepository { get; }
		IOrderProductRepository OrderProductRepository { get; }
		IClientRepository ClientRepository { get; }
		IOrderRepository OrderRepository { get; }
	}
}
