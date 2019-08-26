using Crud.Core;
using Crud.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
	public abstract class Cruder<T> : Controller where T : class
	{


		ICrudService<T> service;

		public Cruder()
		{
			service = new CrudService<T>();
		}

		public virtual ActionResult Index()
		{

			var p = service.Get(1);

			return View();
		}
	}
}