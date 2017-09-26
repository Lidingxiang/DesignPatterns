using System;
using SimpleAbsFactory.Model;
using SimpleAbsFactory.Service;

namespace SimpleAbsFactory.ServiceImpl
{
    public class AccessUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在AccessUser中给User表添加一条记录 ");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在AccessUser中根据Id返回一条记录");
            return null;
        }
    }
}
