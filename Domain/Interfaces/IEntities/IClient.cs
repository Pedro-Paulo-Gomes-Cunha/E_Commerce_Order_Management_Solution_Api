using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IEntities
{
	public interface IClient: IBaseEntity
	{
		string Name { get; }
		string PassWord { get; }
	}
}
