using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryApp.Model;
using AbstractFactoryApp.Service; 

namespace AbstractFactoryApp.ServiceImpl
{
    public class SqlServerUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在SqlServer中给User表添加一条记录 ");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在SqlServer中根据Id返回一条记录");
            return null;
        }
    }
}
