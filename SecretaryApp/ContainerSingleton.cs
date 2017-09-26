using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretaryApp
{
    public static class ContainerSingleton
    {
        public static ItemModel ItemModel = new ItemModel();

        public static ItemModel Instance
        {
            get { return ItemModel; }
        }

        public static void SetContainer(byte[] key, byte[] iv)
        {
            ItemModel.Key = key;
            ItemModel.Iv = iv;
        }
    }
}
