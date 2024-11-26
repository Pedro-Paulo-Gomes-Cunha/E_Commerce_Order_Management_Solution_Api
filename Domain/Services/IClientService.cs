using Domain.DTOs;
using Domain.Interfaces.IEntities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;
using Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
	public class ClientService : IClientService
	{
		IWrapperRepossitory _repositoryWrapper;
		public ClientService(IWrapperRepossitory repositoryWrapper)
		{
			this._repositoryWrapper = repositoryWrapper;
		}
		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ClientDto> FindAll()
		{
			return this._repositoryWrapper.ClientRepository.FindAll();
		}

		public ClientDto FindById(Guid id)
		{
			return this._repositoryWrapper.ClientRepository.FindById(id);
		}

		public void Remove(Guid id)
		{
			throw new NotImplementedException();
		}

		public void Save(ClientDto obj)
		{
			this._repositoryWrapper.ClientRepository.Save(obj);
		}

		public void Update(ClientDto obj)
		{
			throw new NotImplementedException();
		}
	}
}
