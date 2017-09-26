using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorApp
{
    public class ConcreteIterator : Iterator
    {
        private readonly ConcreteAggregate _concreteAggregate;
        private int current = 0;

        public ConcreteIterator(ConcreteAggregate concreteAggregate)
        {
            _concreteAggregate = concreteAggregate;
        }

        public override object First()
        {
            return _concreteAggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            current++;
            if (current < _concreteAggregate.Count)
            {
                ret = _concreteAggregate[current];
            }
            return ret;
        }

        public override bool IsDone()
        {
            return current >= _concreteAggregate.Count ? true : false;
        }

        public override object CurrentItem()
        {
            return _concreteAggregate[current];
        }
    }
}
