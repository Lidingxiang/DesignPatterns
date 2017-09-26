using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Secretary secretary = new Secretary();

            StockObserver zhangsan = new StockObserver("张三", secretary);
            StockObserver lisi = new StockObserver("李四", secretary);

            secretary.Attach(zhangsan);
            secretary.Attach(lisi);

            secretary.SecretaryAction = "老板回来了";
            secretary.Update();

            Console.ReadLine();
        }
    }
}
