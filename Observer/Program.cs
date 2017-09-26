using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject concreteSubject = new ConcreteSubject();
            concreteSubject.Attach(new ConcreteObserver(concreteSubject, "x"));
            concreteSubject.Attach(new ConcreteObserver(concreteSubject, "y"));
            concreteSubject.Attach(new ConcreteObserver(concreteSubject, "z"));

            concreteSubject.SubjectState = "hello";

            concreteSubject.Notify();

            Console.ReadLine();
        }
    }
}
