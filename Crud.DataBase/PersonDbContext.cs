using Crud.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.DataBase
{
    public class PersonDbContext : DbContext
	{
		public PersonDbContext(string context) : base(context)
		{
			//Database.SetInitializer<PersonDbContext>(null);
		}

		public DbSet<Person> Persons { get; set; }


		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{

		}
	}
}
