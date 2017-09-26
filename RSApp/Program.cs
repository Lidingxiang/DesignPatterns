using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dd=RsaEncrypt.RSAEncrypt("", "123");

            var cc = RsaEncrypt.RSADecrypt("", dd);

            var tt = cc;
        }
    }
}
