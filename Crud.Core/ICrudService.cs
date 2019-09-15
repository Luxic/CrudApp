using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
