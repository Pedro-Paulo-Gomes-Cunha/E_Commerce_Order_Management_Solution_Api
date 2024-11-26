using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IEntities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

		public ProductDto ToDto()
		{
			return new ProductDto(Id, Name, Description, Price);
		}
	}
}
