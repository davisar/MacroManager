using macromanager.swglib.core;
using macromanager.swglib.commands.sys;

namespace macromanager.swglib.commands;

public static partial class Sys
{
    public static Dump Dump(CommandSequence seq)
    {
        return new Dump(seq);
    }

    public static Pause Pause(CommandSequence sequence, int seconds)
    {
        return new Pause(sequence, seconds);
    }
}
