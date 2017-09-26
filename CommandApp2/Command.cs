using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandApp2
{
    public abstract class Command
    {
        protected readonly Barbecuer _barbecuer;

        protected Command(Barbecuer barbecuer)
        {
            _barbecuer = barbecuer;
        }

        public abstract void ExcuteCommand();
    }
}
