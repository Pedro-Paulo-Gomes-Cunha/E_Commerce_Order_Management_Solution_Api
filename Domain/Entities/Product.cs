using Domain.Interfaces.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class Product : IProduct
	{
		public Guid Id { get; set; }
		public string Name { get; set;}

		public string Description { get; set;}

		public double Price { get; set;}

		public Product() { }

		public Product(Guid id, string name, string description, double price)
		{
			Id = id;
			Name = name;
			Description = description;
			Price = price;
		}
	}
}
