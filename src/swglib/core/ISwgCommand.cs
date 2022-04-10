namespace macromanager.swglib.core;

/// <summary>
/// Represents an individual command - For example, "/dump"
/// </summary>
public interface ISwgCommand
{
    /// <summary>
    /// Retrieves the text representation of a command to be used when creating a macro or alias string.
    /// </summary>
    /// <value></value>
    string TextRepresentation { get; }

    /// <summary>
    /// Retrieves the condensed text representation of the command. Ex: /dump can be shortened to /du
    /// </summary>
    /// <value></value>
    string ShortTextRepresentation { get; }

    /// <summary>
    /// Adds the command to a CommandSequence.
    /// </summary>
    /// <param name="target"></param>
    void RegisterToSequence(CommandSequence target) => target.Add(this);
}
