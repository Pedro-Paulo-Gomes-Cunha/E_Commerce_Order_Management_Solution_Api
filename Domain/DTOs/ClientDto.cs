using Domain.DBOs;
using Domain.Interfaces.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
	public class ClientDto 
	{
		public Guid Id { get; set; }
		public string Name { get; set;}

		public string PassWord { get; set;}
		public ClientDto() { }
		public ClientDto(Guid id, string name, string passWord)
		{
			Id = id;
			Name = name;
			PassWord = passWord;
		}

		public ClientDbo toDbo()
		{
			return new ClientDbo(Id, Name, PassWord);
		}
	}
}
