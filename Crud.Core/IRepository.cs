using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Core
{
	public interface IRepository<T>
	{
		T Get(int ID);
		T Add(T o);
		void Update(T o);
		IEnumerable<T> GetAll();
	}
}
