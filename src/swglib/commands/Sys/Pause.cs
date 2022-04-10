using macromanager.swglib.core;

namespace macromanager.swglib.commands.sys;

public class Pause : ISwgCommand
{
    private int seconds;
    public Pause(CommandSequence sequence, int seconds)
    {
        this.seconds = seconds;
        sequence.Add(this);
    }

    public string TextRepresentation
    {
        get => $"/pause {this.seconds}";
    }

    public string ShortTextRepresentation
    {
        get => $"/pause {this.seconds}";
    }
}
