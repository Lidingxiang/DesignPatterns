using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BriageApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();

            ab.SetImplementor(new ConcreteImplementorA());
            ab.AbstractionOperation();

            ab.SetImplementor(new ConcreteImplementorB());
            ab.AbstractionOperation();

            Console.ReadLine();
        }
    }
}
