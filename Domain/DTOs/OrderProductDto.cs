using Domain.DBOs;
using Domain.Interfaces.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
	public class OrderProductDto
	{
		public Guid Id { get; set; }
		public Guid OrderId { get; set;}
		public Guid ProductId { get; set;}
		public OrderProductDto() { }

		public OrderProductDto(Guid id, Guid orderId, Guid productId)
		{
			Id = id;
			OrderId = orderId;
			ProductId = productId;
		}

		public OrderProductDbo OrderProductDbo()
		{
			return new OrderProductDbo(Id, OrderId, ProductId);
		}
	}
}
