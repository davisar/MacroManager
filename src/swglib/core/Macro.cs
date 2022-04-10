namespace macromanager.swglib.core;
public abstract class Macro : ISwgCommand
{
    public string TextRepresentation
    {
        get
        {
            return "/macro " + this.Name;
        }
    }

    public string ShortTextRepresentation
    {
        get
        {
            return "/ma " + this.Name;
        }
    }

    public abstract string Name { get; }

    /// <summary>
    /// Define the Macro command steps. Each step needs to be registered to the CommandSequence.
    /// </summary>
    /// <param name="sequence"></param>
    public abstract void MacroSteps(CommandSequence sequence);

    /// <summary>
    /// Calls the macro as a command in the command sequence.
    /// </summary>
    /// <param name="sequence"></param>
    public void CallAsCommand(CommandSequence sequence)
    {
        ((ISwgCommand)this).RegisterToSequence(sequence);
    }

    /// <summary>
    /// Allows validation to be performed on the macro.
    /// </summary>
    /// <returns></returns>
    public virtual List<string> Validate()
    {
        // TODO: Perform general validation routine
        return null;
    }
}
