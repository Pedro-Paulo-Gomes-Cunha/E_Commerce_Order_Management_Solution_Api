using Domain.Interfaces.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DBOs
{
	public class OrderProductDbo 
	{
		public Guid Id { get; set; }
		public Guid OrderId { get; set;}
		public Guid ProductId { get; set;}
		public OrderProductDbo() { }

		public OrderProductDbo(Guid id, Guid orderId, Guid productId)
		{
			Id = id;
			OrderId = orderId;
			ProductId = productId;
		}
	}
}
