using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorApp
{
    /// <summary>
    /// 具体同事类
    /// </summary>
    public class ConcreteColleaguel1 : Colleague
    {
        public ConcreteColleaguel1(Mediator mediator)
            : base(mediator)
        {
        }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("同事1得到消息：" + message);
        }
    }
}
