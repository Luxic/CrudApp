using Crud.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CruderWebApi.Controllers
{
	[EnableCors(origins: "*", headers: "*", methods: "PUT, POST, GET, DELETE, OPTIONS")]
	public class PersonController : CrudController<Person>
	{ 

		
		
	}
}
