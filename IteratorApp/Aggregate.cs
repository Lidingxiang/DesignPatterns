using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorApp
{
    /// <summary>
    /// 聚集抽象类
    /// </summary>
    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
}
