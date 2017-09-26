using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class StockObserver
    {
        private readonly string _name;
        private readonly Secretary _secretary;

        public StockObserver(string name, Secretary secretary)
        {
            _name = name;
            _secretary = secretary;
        }

        public void Update()
        {
            Console.WriteLine("{0}  {1} 关闭股票行情，继续工作", _name, _secretary.SecretaryAction);
        }
    }
}
