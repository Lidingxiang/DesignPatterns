using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorApp
{
    /// <summary>
    /// 具体中介者对象
    /// </summary>
    public class ConcreteMediator : Mediator
    {
        private ConcreteColleaguel1 _colleague1;
        private ConcreteColleaguel2 _colleague2;
        public ConcreteColleaguel1 Conlleague1
        {
            set { _colleague1 = value; }
        }

        public ConcreteColleaguel2 Conlleague2
        {
            set { _colleague2 = value; }
        }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == _colleague1)
            {
                _colleague2.Notify(message);
            }
            else
            {
                _colleague1.Notify(message);
            }
        }
    }
}
