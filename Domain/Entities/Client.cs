using Domain.Interfaces.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class Client : IClient
	{
		public Guid Id { get; set; }
		public string Name { get; set;}

		public string PassWord { get; set;}
		public Client() { }
		public Client(Guid id, string name, string passWord)
		{
			Id = id;
			Name = name;
			PassWord = passWord;
		}
	}
}
