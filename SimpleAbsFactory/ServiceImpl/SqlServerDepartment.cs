using System;
using SimpleAbsFactory.Model;
using SimpleAbsFactory.Service;

namespace SimpleAbsFactory.ServiceImpl
{
    public class SqlServerDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("在SqlServer中根据Id返回一条记录");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("在SqlServer中给Department表添加一条记录 ");
        }
    }
}
