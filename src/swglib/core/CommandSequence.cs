namespace macromanager.swglib.core;

using System.Collections.Generic;

public class CommandSequence
{
    private List<ISwgCommand> sequence = new List<ISwgCommand>();

    public List<ISwgCommand> Commands { get => this.sequence; }

    public void Add(ISwgCommand commandToAdd)
    {
        this.sequence.Add(commandToAdd);
    }
}
