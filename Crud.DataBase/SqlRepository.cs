using Crud.Core;
using Crud.DataBase.SqlDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Crud.DataBase
{
	public class SqlRepository<T> : IRepository<T>
	{   

		DBManager dbContext;

		public SqlRepository(string con)
		{
			dbContext = new DBManager(con);
		}

		public T Get(int id)
		{
			var sdf = new object();

			var parameters = new List<IDbDataParameter>();
			parameters.Add(dbContext.CreateParameter("@ID",  1, DbType.String));

			dbContext.GetDataReader("SELECT * FROM Person Where ID = @ID", System.Data.CommandType.Text, parameters.ToArray());

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

		public void Update(T o)
		{

		}
	}
}
