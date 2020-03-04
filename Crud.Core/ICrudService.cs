using System.Collections.Generic;

namespace Crud.Core
{
	public interface ICrudService<T>
	{
		T Get(int ID);
		void Create(T o);
		void Update(T o);
		IEnumerable<T> GetAll();
	}
}
