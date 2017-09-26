using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateApp
{
    public class Context
    {
        private State _state;

        public Context(State state)
        {
            _state = state;
        }

        public State State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("当前状态：" + _state.GetType().Name);
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}
