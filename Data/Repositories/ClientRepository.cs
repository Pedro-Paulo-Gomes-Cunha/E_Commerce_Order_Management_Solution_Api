using Domain.DBOs;
using Domain.DTOs;
using Domain.Interfaces.IEntities;
using Domain.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
	public class ClientRepository : BaseRepository<ClientDbo>, IClientRepository
	{
		public IEnumerable<ClientDto> FindAll()
		{
			throw new NotImplementedException();
		}

		public ClientDto FindById(Guid id)
		{
			throw new NotImplementedException();
		}

		public void RemoveClient(Guid id)
		{
			throw new NotImplementedException();
		}

		public void Save(ClientDto obj)
		{
			throw new NotImplementedException();
		}

		public void UpdateClient(ClientDto obj)
		{
			throw new NotImplementedException();
		}
	}
}
