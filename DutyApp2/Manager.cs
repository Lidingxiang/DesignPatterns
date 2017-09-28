using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutyApp2
{
    public abstract class Manager
    {
        protected readonly string _name;
        protected Manager _superior;

        protected Manager(string name)
        {
            _name = name;
        }

        public void SetSuperior(Manager superior)
        {
            this._superior = superior;
        }

        public abstract void RequestApplications(Request request);
    }
}
