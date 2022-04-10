using macromanager.swglib.macroPrinter.lib;
using example;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

MacroFileWriter macroWriter = new MacroFileWriter(){
    new HarvestAlways(HarvestType.Bone),
    new HarvestAlways(HarvestType.Meat),
    new HarvestAlways(HarvestType.Hide)
};

macroWriter.Add(new MyMacroFoo());

macroWriter.WriteMacros("./TestMacros");