﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.DataBase
{
	class PersonSqlDbContext
	{
		private readonly string _connectionString;
		private SqlConnection _connection;

		public PersonSqlDbContext()
		{
			_connectionString = @"Server=LIGETI-PC;Database=DataAccess;Trusted_Connection=True;";
		}

		public SqlConnection Connection
		{
			get
			{
				if (_connection == null)
				{
					_connection = new SqlConnection(_connectionString);
				}
				if (_connection.State != ConnectionState.Open)
				{
					_connection.Open();
				}
				return _connection;
			}
		}


		public void Dispose()
		{
			if (_connection != null && _connection.State == ConnectionState.Open)
				_connection.Close();
		}
	}
}
