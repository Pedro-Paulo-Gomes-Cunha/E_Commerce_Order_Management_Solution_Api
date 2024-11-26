using Domain.DTOs;
using Domain.Interfaces.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DBOs
{
	public class OrderDbo 
	{
		public Guid Id { get; set; }
		public Guid ClientId { get; set;}

		public double Total { get; set;}
		public string status { get; set; }

		public OrderDbo() { }

		public OrderDbo(Guid id, Guid clientId, double total, string _status)
		{
			Id = id;
			ClientId = clientId;
			Total = total;
			status = _status;
		}
		public OrderDto toDto()
		{
			return new OrderDto(Id, ClientId, Total, status);
		}
	}
}
