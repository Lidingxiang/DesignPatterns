using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDelegate
{
    public abstract class Subject
    {
        public delegate void EventHandler();

        public abstract void Notify();

        public string SubjectState { get; set; }
    }
}
