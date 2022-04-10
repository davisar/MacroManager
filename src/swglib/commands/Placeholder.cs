using macromanager.swglib.core;

namespace macromanager.swglib.commands;

public class Placeholder : ISwgCommand
{
    public Placeholder(CommandSequence sequence)
    {
        sequence.Add(this);
    }

    public string TextRepresentation
    {
        get => "/Placeholder";
    }

    public string ShortTextRepresentation
    {
        get => "/Placeholder";
    }
}
