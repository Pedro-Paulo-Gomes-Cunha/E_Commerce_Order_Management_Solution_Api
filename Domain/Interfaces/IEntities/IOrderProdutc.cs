using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IEntities
{
	public interface IOrderProdutc: IBaseEntity
	{
		Guid OrderId { get; }
		Guid ProductId { get; }
	}
}
