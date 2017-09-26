using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryApp.ConcreteFactory;
using AbstractFactoryApp.Model;

namespace AbstractFactoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new SqlServerFactory();
            factory.CreateUser().Insert(new User() { Id = "l", Name = "小明" });
            factory.CreateUser().GetUser(1);

            Console.ReadLine(); 
        }
    }
}
