using System.Net.Mime;
using System.Collections.ObjectModel;
using macromanager.swglib.core;
using System.IO;
using System.Collections.Generic;

namespace macromanager.swglib.macroPrinter.lib;
public class MacroFileWriter : Collection<MacroV2>
{
    private static string MacroDirName = "Macros";
    public void WriteMacros(string targetDirectory)
    {
        if (!Directory.Exists(targetDirectory))
        {
            throw new DirectoryNotFoundException($"{targetDirectory} does not exist.");
        }
        string macrosDirectoryPath = Path.Combine(targetDirectory, MacroDirName);
        DirectoryInfo dir = Directory.CreateDirectory(macrosDirectoryPath);
        foreach (var macro in this)
        {
            string fileName = $"{macro.Name}.txt";
            StreamWriter fs = new StreamWriter(Path.Combine(macrosDirectoryPath, fileName), append: false);
            WriteMacro(fs, macro);
        }
    }

    private void WriteMacro(TextWriter writer, MacroV2 macro)
    {
        CommandSequence seq = new CommandSequence();
        macro.MacroSteps(seq);
        foreach (var command in seq.Commands)
        {
            writer.WriteLine(command.TextRepresentation);
        }
        writer.Close();
    }
}
