using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var enDemo = new EnvDemo();
            var plainTextArray = enDemo.PlainTextArray();

            var keyIv = enDemo.GetKeyAndIv();
            ContainerSingleton.SetContainer(keyIv.Item1, keyIv.Item2);

            var envArr = EnvDemo.EncryptString(plainTextArray, ContainerSingleton.ItemModel.Key, ContainerSingleton.ItemModel.Iv);
            var dd = envArr;


            var deDemo = new DevDemo();

            var aarr = DevDemo.DecryptTextFromMemory(dd, ContainerSingleton.ItemModel.Key, ContainerSingleton.ItemModel.Iv);
            var dddc = deDemo.ClearText(aarr);

            var ddcd = dddc;


        }
    }
}
