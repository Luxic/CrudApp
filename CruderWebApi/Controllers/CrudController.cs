using Crud.Core;
using Crud.Service;
using System.Collections.Generic;
using System.Web.Http;

namespace CruderWebApi.Controllers
{ 
	public abstract class CrudController<T> : ApiController where T : class
	{
		ICrudService<T> service;

		public CrudController()
		{
			service = new CrudService<T>();
		}

		[HttpGet]
		public virtual IEnumerable<T> Index()
		{
			var p = service.GetAll();

			return p;
		}
 
	}
}