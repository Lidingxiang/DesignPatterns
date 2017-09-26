using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandApp
{
    /// <summary>
    /// 吃客
    /// </summary>
    public class Waiter
    {
        private Command _command;
        public void SetOrder(Command command)
        {
            _command = command;
        }

        public void Notify()
        {
            _command.ExcuteCommand();
        }
    }
}
