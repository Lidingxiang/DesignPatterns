using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton2
    {
        private static readonly Singleton2 Instance = new Singleton2();

        private Singleton2()
        {
        }

        public static Singleton2 GetInSingleton2()
        {
            return Instance;
        }
    }
}
