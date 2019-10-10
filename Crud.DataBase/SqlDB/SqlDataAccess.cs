using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.DataBase.SqlDB
{
	public class SqlDataAccess : IDatabaseHandler
	{
		private string ConnectionString;

		public SqlDataAccess(string connectionString)
		{
			this.ConnectionString = connectionString;
		}

		public IDbConnection CreateConnection()
		{
			return new SqlConnection(ConnectionString);
		}

		public void CloseConnection(IDbConnection connection)
		{
			var sqlConnection = (SqlConnection)connection;
			sqlConnection.Close();
			sqlConnection.Dispose();
		}

		public IDbCommand CreateCommand(string commandText, CommandType commandType, IDbConnection connection)
		{
			return new SqlCommand
			{
				CommandText = commandText,
				CommandType = commandType,
				Connection = (SqlConnection)connection,
			};
		}

		public IDataAdapter CreateAdapter(IDbCommand command)
		{
			return null;
			//return new SqlDataAccess(()command);
		}

		public IDbDataParameter CreateParameter(IDbCommand command)
		{
			SqlCommand SQLComand = (SqlCommand)command;
			return SQLComand.CreateParameter();
		}

	}
}
