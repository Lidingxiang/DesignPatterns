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
    public class ConcreteColleaguel2 : Colleague
    {
        public ConcreteColleaguel2(Mediator mediator)
            : base(mediator)
        {
        }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("同事2得到消息：" + message);
        }
    }
}
