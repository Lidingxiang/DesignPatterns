using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ConcreteObserver : Observer
    {
        private readonly ConcreteSubject _concreteSubject;
        private readonly string _name;

        public ConcreteObserver(ConcreteSubject concreteSubject, string name)
        {
            _concreteSubject = concreteSubject;
            _name = name;
        }

        public override void Update()
        {
            Console.WriteLine("观察者{0}的新状态是{1}", _name, _concreteSubject.SubjectState);
        }
    }
}
