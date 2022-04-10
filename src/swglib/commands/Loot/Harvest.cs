using macromanager.swglib.core;

namespace macromanager.swglib.commands;

public class Harvest : ISwgCommand
{
    private HarvestType _harvestType;

    public Harvest(CommandSequence sequence, HarvestType harvestType)
    {
        this._harvestType = harvestType;
        sequence.Add(this);
    }

    public string TextRepresentation
    {
        get => $"/harvest{this.GetHarvestTypeString()}";
    }

    public string ShortTextRepresentation
    {
        get => $"/harvest{this.GetHarvestTypeString()}";
    }

    // Returns a string formatted to be appended to the /harvest command.
    private string GetHarvestTypeString()
    {
        switch (this._harvestType)
        {
            case HarvestType.Any:
                return string.Empty;
            default:
                return $" {this._harvestType.ToString()}";
        }
    }
}
