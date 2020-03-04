using System.Collections.Generic;

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
