using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorApp2
{
    public class Iraq:Country
    {
        public Iraq(UnitedNations mediator) : base(mediator)
        {
        }

        public void Declare(string message)
        {
            _mediator.Declare(message, this);
        }

        public void GetMessage(string message)
        {
            Console.WriteLine("伊拉克获得对方消息：" + message);
        }
    }
}
