using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using SimpleAbsFactory.Service;

namespace SimpleAbsFactory.SimpleFactory
{
    public class ReFactory
    {
        public static IUser CreateUser()
        {
            return (IUser)Assembly.Load("SimpleAbsFactory").CreateInstance("SimpleAbsFactory.ServiceImpl.SqlServerUser");
        }

        public static IDepartment CreateDepartment()
        {
            return (IDepartment)Assembly.Load("SimpleAbsFactory").CreateInstance("SimpleAbsFactory.ServiceImpl.SqlServerDepartment");
        }
    }
}
