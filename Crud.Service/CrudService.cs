using Crud.Core;
using Crud.DataBase;
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

		public CrudService(string connectionString)
		{
			repo = new SqlRepository<T>(connectionString);
		}

		public T Get(int id)
		{
			return repo.Get(id);
		}

		public IEnumerable<T> GetAll()
		{
			return repo.GetAll();
		}

		public virtual void Create(T item)
		{
			var newItem = repo.Add(item);
		}

		public virtual void Update(T item)
		{
			repo.Update(item);
		}
	}
}
