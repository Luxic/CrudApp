﻿using Crud.Core;
using Crud.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Service
{
    public class CrudService<T> : ICrudService<T> where T : class
    {
		IRepository<T> repo;

		public CrudService()
		{
			repo = new Repository<T>();
		}

		public T Get(int id)
		{
			return repo.Get(id);
		}

		public virtual void Create(T item)
		{
			var newItem = repo.Add(item);
		}
	}
}
