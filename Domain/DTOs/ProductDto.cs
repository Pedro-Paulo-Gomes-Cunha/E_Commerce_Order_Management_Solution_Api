using Domain.DBOs;
using Domain.Interfaces.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
	public class ProductDto 
	{
		public Guid Id { get; set; }
		public string Name { get; set;}

		public string Description { get; set;}

		public double Price { get; set;}

		public ProductDto() { }

		public ProductDto(Guid id, string name, string description, double price)
		{
			Id = id;
			Name = name;
			Description = description;
			Price = price;
		}
		
		public ProductDbo toDbo()
		{
			return new ProductDbo(Id, Name, Description, Price);
		}
	}
}
