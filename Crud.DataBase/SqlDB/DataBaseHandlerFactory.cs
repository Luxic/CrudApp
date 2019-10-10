using System.Configuration;


namespace Crud.DataBase.SqlDB
{
	public class DataBaseHandlerFactory
	{
		private ConnectionStringSettings connectionString;

		public DataBaseHandlerFactory(string connectionStringName)
		{
			connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"];
		}

		public IDatabaseHandler CreateDatabase()
		{
			IDatabaseHandler database = null;

			switch(connectionString.ProviderName.ToLower())
			{
				case "system.data.sqlclient":
					database = new SqlDataAccess(connectionString.ConnectionString);
					break;
			}

			return database;
		}

	}
}
