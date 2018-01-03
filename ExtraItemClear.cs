using Rocket.Core.Logging;
using Rocket.Core.Plugins;

namespace ExtraConcentratedJuice.ExtraItemClear
{
    public class ExtraItemClear : RocketPlugin
    {
        protected override void Load()
        {
            Logger.Log("Extra's Item Clear Loaded!");
        }
    }
}
