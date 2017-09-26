using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandApp3
{
    public abstract class Command
    {
        protected readonly Receiver _receiver;

        protected Command(Receiver receiver)
        {
            _receiver = receiver;
        }

        public abstract void Execute();
    }
}
