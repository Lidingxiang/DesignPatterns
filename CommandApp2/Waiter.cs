using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandApp2
{
    /// <summary>
    /// 吃客
    /// </summary>
    public class Waiter
    {
        private readonly IList<Command> _orders = new List<Command>();
        public void SetOrder(Command command)
        {
            if (command.ToString() == "CommandApp2.BakeChickenWingCommand")
            {
                Console.WriteLine("服务员：鸡翅没有了，请点别的烧烤");
            }
            else
            {
                _orders.Add(command);
                Console.WriteLine("增加订单：" + command + "  时间：" + DateTime.Now);
            }
        }

        public void CancelOrder(Command command)
        {
            _orders.Remove(command);
            Console.WriteLine("取消订单：" + command + "时间：" + DateTime.Now);
        }

        public void Notify()
        {
            foreach (var command in _orders)
            {
                command.ExcuteCommand();
            }
        }
    }
}
