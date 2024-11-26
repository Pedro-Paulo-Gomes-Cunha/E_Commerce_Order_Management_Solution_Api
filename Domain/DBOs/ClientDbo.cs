using Domain.Interfaces.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DBOs
{
	public class ClientDbo 
	{
		public Guid Id { get; set; }
		public string Name { get; set;}

		public string PassWord { get; set;}
		public ClientDbo() { }
		public ClientDbo(Guid id, string name, string passWord)
		{
			Id = id;
			Name = name;
			PassWord = passWord;
		}
	}
}
