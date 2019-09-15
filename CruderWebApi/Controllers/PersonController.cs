using Crud.Core;
using System.Web.Http.Cors;

namespace CruderWebApi.Controllers
{
	[EnableCors(origins: "*", headers: "*", methods: "PUT, POST, GET, DELETE, OPTIONS")]
	public class PersonController : CrudController<Person>
	{
	}
}
