using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyComponent
{
    public abstract class Company
    {
        protected readonly string _name;

        protected Company(string name)
        {
            _name = name;
        }

        public abstract void Add(Company company);

        public abstract void Remove(Company company);

        public abstract void Display(int depth);

        public abstract void LineOfDuty();
    }
}
