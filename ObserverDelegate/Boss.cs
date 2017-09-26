using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDelegate
{
    public class Boss : Subject
    {
        public event EventHandler Update; 
         
        public override void Notify()
        {
            if (Update != null) Update();
        } 
    }
}
