using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretaryApp
{
    public class ItemModel
    {
        public byte[] Key { get; set; }

        public byte[] Iv { get; set; }
    }
}
