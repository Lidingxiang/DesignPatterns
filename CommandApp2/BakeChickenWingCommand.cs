

namespace CommandApp2
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
