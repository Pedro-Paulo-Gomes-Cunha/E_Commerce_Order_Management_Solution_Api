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

		public virtual IEnumerable<ProductDbo> Produtc_lists { get; set; }

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
			var dto=new OrderDto(Id, ClientId, Total, status);
			dto.Produtc_lists = Produtc_lists.Select(x => x.ToDto());
			return new OrderDto(Id, ClientId, Total, status);
		}
	}
}
