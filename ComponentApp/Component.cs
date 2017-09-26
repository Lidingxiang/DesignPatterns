using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentApp
{
    public abstract class Component
    {
        protected readonly string _name;

        protected Component(string name)
        {
            _name = name;
        }

        public abstract void Add(Component component);

        public abstract void Remove(Component component);

        public abstract void Display(int depth); 
    }
}
