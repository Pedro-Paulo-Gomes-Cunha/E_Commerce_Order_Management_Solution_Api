using Domain.DTOs;
using Domain.Interfaces.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IRepositories
{
	public interface IClientRepository 
	{
		IEnumerable<ClientDto> FindAll();
		void Save(ClientDto obj);
		ClientDto FindById(Guid id);
		void UpdateClient(ClientDto obj);
		void RemoveClient(Guid id);
	}
}
