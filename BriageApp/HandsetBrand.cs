using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BriageApp
{
    public abstract class HandsetBrand
    {
        protected IList<HandsetSoft> HandsetSofts = new List<HandsetSoft>();

        public void SetHandsetSoft(HandsetSoft soft)
        {
            HandsetSofts.Add(soft);
        }

        public abstract void HandsetSoftRun();
    }
}
