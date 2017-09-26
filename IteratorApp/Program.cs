using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate concreteIterator = new ConcreteAggregate();

            concreteIterator[0] = "A";
            concreteIterator[1] = "B";
            concreteIterator[2] = "C";
            concreteIterator[3] = "D";
            concreteIterator[4] = "E";
            concreteIterator[5] = "F";

            Iterator iterator = new ConcreteIterator(concreteIterator);
            object item = iterator.First();
            while (!iterator.IsDone())
            {
                Console.WriteLine("{0} 请买车票", iterator.CurrentItem());
                iterator.Next();
            }
            Console.ReadLine();
        }
    }
}
