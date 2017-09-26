using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDelegate
{
    public class StockObserver
    {
        private readonly string _name;
        private readonly Subject _subject;

        public StockObserver(string name, Subject subject)
        {
            _name = name;
            _subject = subject;
        }

        public void CloseStockMarket()
        {
            Console.WriteLine("{0} {1} 关闭股票行情，继续工作", _name, _subject.SubjectState);
        }
    }
}
