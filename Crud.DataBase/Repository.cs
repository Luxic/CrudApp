
using Crud.Core;
using Crud.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Infrastructure
{
	public class Repository<T> : IRepository<T> where T : class
	{
		PersonDbContext dbContext;

		public Repository()
		{
			dbContext = new PersonDbContext("DataAccessEntities");
		}

		public T Get(int id)
		{
			var entity = dbContext.Set<T>().Find(id);
			return entity;
		}

		public T Add(T o)
		{
			var entity = dbContext.Set<T>().Create();
			dbContext.Set<T>().Add(entity);
			return entity;
		}

		public IEnumerable<T> GetAll()
		{
			var entity = dbContext.Set<T>();
			return entity;
		}

	}
}
