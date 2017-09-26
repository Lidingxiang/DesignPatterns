using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss huBoss = new Boss();

            StockObserver tongshi1 = new StockObserver("zhangsan", huBoss);
            NbaObserver tongshi2 = new NbaObserver("lisi", huBoss);

            huBoss.Update += new Subject.EventHandler(tongshi1.CloseStockMarket);
            huBoss.Update += new Subject.EventHandler(tongshi2.CloseNbaDirectSeeding);

            huBoss.SubjectState = "我回来了";
            huBoss.Notify();

            Console.ReadLine();
        }
    }
}
