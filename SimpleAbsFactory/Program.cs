using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleAbsFactory.ConcreteFactory;
using SimpleAbsFactory.Model;
using SimpleAbsFactory.Service;
using SimpleAbsFactory.SimpleFactory;

namespace SimpleAbsFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //IUser iUser = DataAccess.CreateUser();

            IUser iUser = ReFactory.CreateUser();
            iUser.Insert(new User() { Id = "l", Name = "小明" });
            iUser.GetUser(1);

            Console.ReadLine(); 
        }
    }
}
