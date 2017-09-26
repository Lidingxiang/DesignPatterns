using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s2 == s1)
            {
                Console.WriteLine("这两个对象是相同的实例");
            }

            Console.ReadLine();
        }
    }
}
