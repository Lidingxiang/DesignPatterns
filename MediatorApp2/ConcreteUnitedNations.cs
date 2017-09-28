using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorApp2
{
    public class ConcreteUnitedNations : UnitedNations
    {
        protected USA _usa;
        protected Iraq _iraq;

        public USA Usa
        {
            set { _usa = value; }
        }

        public Iraq Iraq
        {
            set { _iraq = value; }
        }

        public override void Declare(string message, Country colleague)
        {
            if (colleague == _usa)
            {
                _iraq.GetMessage(message);
            }
            else
            {
                _usa.GetMessage(message);
            }
        }
    }
}
