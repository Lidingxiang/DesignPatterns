using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyComponent
{
    public class FinanceDepartment : Company
    {
        public FinanceDepartment(string name)
            : base(name)
        {
        }

        public override void Add(Company company)
        {

        }

        public override void Remove(Company company)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + _name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0} 公司财务收支管理", _name);
        }
    }
}
