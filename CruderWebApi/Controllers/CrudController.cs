﻿using Crud.Core;
using Crud.Service;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Http;

namespace CruderWebApi.Controllers
{ 
	public abstract class CrudController<T> : ApiController where T : class
	{
		ICrudService<T> service;

		public CrudController()
		{
			string connString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
			service = new CrudService<T>(connString);
		}

		[HttpGet]
		public virtual IEnumerable<T> Index()
		{
			var p = service.GetAll();

			return p;
		}

		[HttpGet]
		public virtual T Get(int ID)
		{
			var p = service.Get(ID);

			return p;
		}

		[HttpPost]
		public  void Post([FromBody]T p)
		{
			service.Create(p);
		}

		[HttpPut]
		public void update([FromBody]T p)
		{
			service.Update(p);
		}
	}
}