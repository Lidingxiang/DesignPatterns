using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Context c=new Context(new ConcreteStateA());
            //c.Request();
            //c.Request();
            //c.Request();
            //c.Request();

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(i);
                if (i == 2)
                {
                    Console.WriteLine("continue  begin");
                    continue;
                }
                if (i == 4)
                {
                    Console.WriteLine("break  begin");
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
