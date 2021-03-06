﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Barbecuer boy = new Barbecuer();
            Command bakeMuttonCommand1 = new BakeMuttonCommand(boy);
            Command bakeMuttonCommand2 = new BakeMuttonCommand(boy);
            Command bakeChickenWingCommand1 = new BakeChickenWingCommand(boy);

            Waiter girl = new Waiter();
            girl.SetOrder(bakeMuttonCommand1);
            girl.Notify();
            girl.SetOrder(bakeMuttonCommand2);
            girl.Notify();
            girl.SetOrder(bakeChickenWingCommand1);
            girl.Notify();

            Console.Read();
        }
    }
}
