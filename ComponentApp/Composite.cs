using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentApp
{
    public class Composite : Component
    {
        private readonly IList<Component> _children = new List<Component>();

        public Composite(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + _name);

            foreach (var component in _children)
            {
                component.Display(depth + 2);
            }
        }
    }
}
