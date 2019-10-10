using System.Data;

namespace Crud.DataBase.SqlDB
{
	public interface IDatabaseHandler
	{
		IDbConnection CreateConnection();
		void CloseConnection(IDbConnection connection);

		IDbCommand CreateCommand(string commandText, CommandType commandType, IDbConnection connection);
		IDataAdapter CreateAdapter(IDbCommand command);
		IDbDataParameter CreateParameter(IDbCommand command);
	}
}
