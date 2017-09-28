using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator m = new ConcreteMediator();

            ConcreteColleaguel1 c1 = new ConcreteColleaguel1(m);
            ConcreteColleaguel2 c2 = new ConcreteColleaguel2(m);
            m.Conlleague1 = c1;
            m.Conlleague2 = c2;

            c1.Send("吃过饭了吗");
            c2.Send("还没有呢");

            Console.Read();
        }
    }
}
