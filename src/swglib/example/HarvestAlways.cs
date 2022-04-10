using System.Xml.Linq;
using System.Data;
using System;
namespace example;

using macromanager.swglib.core;
using macromanager.swglib.commands;
using macromanager.swglib.commands.looting;

public class HarvestAlways : MacroV2
{
    private HarvestType typeToHarvest;

    public HarvestAlways(HarvestType type)
    {
        this.typeToHarvest = type;
    }

    public override string Name
    {
        get => "HarvestAlways" + this.typeToHarvest.ToString();
    }

    public override void MacroSteps(CommandSequence sequence)
    {
        Looting.Loot(sequence, all: true);
        Looting.Harvest(sequence, this.typeToHarvest);
        Sys.Pause(sequence, 1);
        this.CallAsCommand(sequence);
    }
}
