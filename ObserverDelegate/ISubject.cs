using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDelegate
{
    public interface ISubject
    {
        void Notify();

        string SubjectState { set; get; }
    }
}
