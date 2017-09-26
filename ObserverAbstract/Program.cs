using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject secretary=new Secretary();
            Observer zhangsan=new StockObserver("张三",secretary);
            Observer lisi=new StockObserver("lisi",secretary);

            secretary.Attach(zhangsan);
            secretary.Attach(lisi);

            secretary.SubjectState = "老板回来了";

            secretary.Notify();

            Console.ReadLine();
        }
    }
}
