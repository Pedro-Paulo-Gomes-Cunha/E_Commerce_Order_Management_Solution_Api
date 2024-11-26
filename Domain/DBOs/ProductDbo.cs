using Domain.Interfaces.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DBOs
{
	public class ProductDbo 
	{
		public Guid Id { get; set; }
		public string Name { get; set;}

		public string Description { get; set;}

		public double Price { get; set;}

		public ProductDbo() { }

		public ProductDbo(Guid id, string name, string description, double price)
		{
			Id = id;
			Name = name;
			Description = description;
			Price = price;
		}
	}
}
