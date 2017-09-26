using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandApp
{
    public class BakeChickenWingCommand : Command
    {
        public BakeChickenWingCommand(Barbecuer barbecuer)
            : base(barbecuer)
        {
        }

        public override void ExcuteCommand()
        {
            _barbecuer.BakeChickenWing();
        }
    }
}
