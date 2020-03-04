using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Crud.DataBase.SqlDB
{
	public class Mapper
	{
		public static T MapObject<T>(IDataReader dr)
		{

            object o = Activator.CreateInstance<T>();
            PropertyInfo[] p = (typeof(T)).GetProperties();
            object[] custAttr = null;
            while (dr.Read())
            {
                foreach (PropertyInfo pi in p)
                {
                    try
                    {
                        custAttr = pi.GetCustomAttributes(true);
                        if ((dr[pi.Name] != System.DBNull.Value) && (custAttr.Length == 0))
                            pi.SetValue(o, dr[pi.Name], null);
                    }
                    catch (System.IndexOutOfRangeException) { }
                }
            }

            return (T)o;
        }
	}
}
