using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverAbstract
{
    public interface ISubject
    {
        void Attach(Observer observer);

        void Detch(Observer observer);

        void Notify();

        string SubjectState { set; get; }
    }
}
