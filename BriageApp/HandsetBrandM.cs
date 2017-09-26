using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BriageApp
{
    public class HandsetBrandM : HandsetBrand
    {
        public override void HandsetSoftRun()
        {
            foreach (var soft in HandsetSofts)
            {
                soft.Run();
            }
        }
    }
}
