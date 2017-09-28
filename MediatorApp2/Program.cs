using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteUnitedNations unitedNations=new ConcreteUnitedNations();

            USA usa=new USA(unitedNations);
            Iraq iraq=new Iraq(unitedNations);

            unitedNations.Usa = usa;
            unitedNations.Iraq = iraq;

            usa.Declare("不准研制核武器，否则要打你");
            iraq.Declare("难道我怕你");

            Console.Read();
        }
    }
}
