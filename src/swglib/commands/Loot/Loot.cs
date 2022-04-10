using macromanager.swglib.core;

namespace macromanager.swglib.commands.looting;

public class Loot : ISwgCommand
{
    private bool lootAll = false;
    public Loot(CommandSequence sequence, bool all = false)
    {
        sequence.Add(this);
        this.lootAll = all;
    }

    public string TextRepresentation
    {
        get
        {
            return this.lootAll ? "/loot all" : "/loot";
        }
    }

    public string ShortTextRepresentation
    {
        get
        {
            return this.lootAll ? "/loo all" : "/loot";
        }
    }
}
