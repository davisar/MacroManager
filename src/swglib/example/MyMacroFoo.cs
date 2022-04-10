namespace example;

using macromanager.swglib.core;
using macromanager.swglib.commands;

public class MyMacroFoo : MacroV2
{
    public override string Name
    {
        get => "MyMacroFoo";
    }

    public override void MacroSteps(CommandSequence sequence)
    {
        Sys.Dump(sequence);
        this.CallAsCommand(sequence);
    }
}
