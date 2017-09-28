using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorApp
{
    /// <summary>
    /// 抽象同事类
    /// </summary>
    public abstract class Colleague
    {
        protected readonly Mediator _mediator;

        protected Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }
    }
}
