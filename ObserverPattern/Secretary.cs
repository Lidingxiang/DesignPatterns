using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Secretary
    {
        public IList<StockObserver> StockObservers = new List<StockObserver>();

        public void Attach(StockObserver stockObserver)
        {
            this.StockObservers.Add(stockObserver);
        }

        public void Update()
        {
            foreach (var stockObserver in StockObservers)
            {
                stockObserver.Update();
            }
        }

        public string SecretaryAction { get; set; }
    }
}
