﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IEntities
{
	public interface IProduct: IBaseEntity
	{
		string Name { get; }
		string Description { get; }
		double Price { get; }
	}
}
