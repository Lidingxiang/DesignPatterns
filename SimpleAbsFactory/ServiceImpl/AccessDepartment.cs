using System;
using SimpleAbsFactory.Model;
using SimpleAbsFactory.Service;

namespace SimpleAbsFactory.ServiceImpl
{
    public class AccessDepartment : IDepartment
    {
        public void Insert(Department department)
        {
            Console.WriteLine("在AccessUser中给Department表添加一条记录 ");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine("在AccessDepartment中根据Id返回一条记录");
            return null;
        }
    }
}
