using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BriageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HandsetBrand ab;
            ab = new HandsetBrandN();

            ab.SetHandsetSoft(new HandsetGame());
            ab.SetHandsetSoft(new HandsetAddressList());
            ab.HandsetSoftRun();

            //ab = new HandsetBrandM();
            //ab.SetHandsetSoft(new HandsetGame());
            //ab.HandsetSoftRun();

            //ab.SetHandsetSoft(new HandsetAddressList());
            //ab.HandsetSoftRun();

            Console.ReadLine();
        }
    }
}
