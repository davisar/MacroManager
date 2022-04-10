using macromanager.swglib.core;
using macromanager.swglib.commands.looting;

namespace macromanager.swglib.commands;

public static partial class Looting
{
    public static Loot Loot(CommandSequence seq, bool all = false)
    {
        return new Loot(seq, all);
    }

    public static Harvest Harvest(CommandSequence seq, HarvestType harvestType)
    {
        // TODO: Add harvest type
        return new Harvest(seq, harvestType);
    }
}
