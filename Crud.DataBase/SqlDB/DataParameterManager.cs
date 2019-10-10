﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.DataBase.SqlDB
{
	public class DataParameterManager
	{
		public static IDbDataParameter CreateParameter (string providerName, string name, object value, DbType dbType, ParameterDirection direction = ParameterDirection.Input)
		{
			IDbDataParameter parameter = null;

			switch(providerName.ToLower())
			{
				case "system.data.sqlclient":
					return CreateSqlParameter(name, value, dbType, direction);
			
			}

			return parameter;
		}

		private static IDbDataParameter CreateSqlParameter(string name, object value, DbType dbType, ParameterDirection direction)
		{
			return new SqlParameter
			{
				DbType = dbType,
				ParameterName = name,
				Direction = direction,
				Value = value
			};
		}

		private static IDbDataParameter CreateSqlParameter(string name, int size, object value, DbType dbType, ParameterDirection direction)
		{
			return new SqlParameter
			{
				DbType = dbType,
				Size = size,
				ParameterName = name,
				Direction = direction,
				Value = value
			};
		}
	}
}
