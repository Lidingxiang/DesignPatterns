using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BriageApp2
{
    public class RefinedAbstraction : Abstraction
    {
        public override void AbstractionOperation()
        {
            _implementor.Operation();
        }
    }
}
