using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BriageApp2
{
    public class Abstraction
    {
        protected Implementor _implementor;
        public void SetImplementor(Implementor implementor)
        {
            _implementor = implementor;
        }

        public virtual void AbstractionOperation()
        {
            _implementor.Operation();
        }
    }
}
