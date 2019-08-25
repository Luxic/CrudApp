using Crud.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.DataBase
{
	public class SqlRepository<T> : IRepository<T>
	{

		PersonSqlDbContext dbContext;

		public SqlRepository()
		{
			dbContext = new PersonSqlDbContext();
		}

		public T Get(int id)
		{
			var sdf = T;
			 
			return new ;
		}

		public T Add(T o)
		{
			 
			return entity;
		}
	}
}
