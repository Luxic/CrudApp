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
			var sdf = new object();
			 
			return (T)sdf;
		}

		public T Add(T o)
		{

			var sdf = new object();

			return (T)sdf;
		}

		public IEnumerable<T> GetAll()
		{
			return null;
		}
	}
}
