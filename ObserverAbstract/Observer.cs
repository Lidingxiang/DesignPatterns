using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverAbstract
{
    public abstract class Observer
    { 
        public abstract void Update();


        protected readonly string _name;
        protected readonly ISubject _subject;

        protected Observer(string name, ISubject subject)
        {
            _name = name;
            _subject = subject;
        }

    }
}
