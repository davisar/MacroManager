using macromanager.swglib.core;

namespace macromanager.swglib.commands.sys;

public class Dump : ISwgCommand
{
    public Dump(CommandSequence sequence)
    {
        sequence.Add(this);
    }

    public string TextRepresentation
    {
        get => "/dumpPausedCommands";
    }

    public string ShortTextRepresentation
    {
        get => "/dum";
    }
}
