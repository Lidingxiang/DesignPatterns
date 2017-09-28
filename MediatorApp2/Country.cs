using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorApp2
{
    public abstract class Country
    {
        protected readonly UnitedNations _mediator;

        protected Country(UnitedNations mediator)
        {
            _mediator = mediator;
        }
    }
}
