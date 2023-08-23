// See https://aka.ms/new-console-template for more information

using ArchUnitNET.Domain;
using ArchUnitNET.Domain.PlantUml.Export;
using ArchUnitNET.Fluent.PlantUml;
using ArchUnitNET.Fluent.Slices;
using ArchUnitNET.Loader;
using ConsoleApp.Domain.OrderAggregate;
using static ArchUnitNET.Fluent.Slices.SliceRuleDefinition;

string pattern = "ConsoleApp.(**)";
GivenSlices sliceRule = Slices().MatchingWithPackages(pattern);
Architecture arch = new ArchLoader().LoadAssembly(typeof(Order).Assembly).Build();

var path = @"..\..\..\Diagrams\console_app_diagram.puml";

PlantUmlDefinition.ComponentDiagram().WithDependenciesFromSlices(sliceRule.GetObjects(arch)).WriteToFile(path, new RenderOptions
{
    Overwrite = true,
    OmitClassFields = false,
});
