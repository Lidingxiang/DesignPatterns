using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyComponent
{
    public class ConcreteCompany : Company
    {
        private readonly List<Company> _children = new List<Company>();
        public ConcreteCompany(string name)
            : base(name)
        {
        }

        public override void Add(Company company)
        {
            _children.Add(company);
        }

        public override void Remove(Company company)
        {
            _children.Remove(company);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + _name);

            foreach (var company in _children)
            {
                company.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (var company in _children)
            {
                company.LineOfDuty();
            }
        }
    }
}
