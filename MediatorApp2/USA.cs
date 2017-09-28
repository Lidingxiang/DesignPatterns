using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorApp2
{
    public class USA : Country
    {
        public USA(UnitedNations mediator)
            : base(mediator)
        {

        }

        public void Declare(string message)
        {
            _mediator.Declare(message, this);
        }

        public void GetMessage(string message)
        {
            Console.WriteLine("美国获得对方消息：" + message);
        } 
    }
}
