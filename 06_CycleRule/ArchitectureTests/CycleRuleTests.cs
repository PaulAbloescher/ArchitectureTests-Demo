using ArchUnitNET.Domain;
using ArchUnitNET.Loader;
using ArchUnitNET.xUnit;
using ConsoleApp.Domain.OrderAggregate;
using static ArchUnitNET.Fluent.Slices.SliceRuleDefinition;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace ArchitectureTests
{
    public class CycleRuleTests
    {
        private static readonly Architecture Architecture =
            new ArchLoader().LoadAssemblies(typeof(Order).Assembly).Build();

        [Fact]
        public void ConsoleApp_Should_Be_Free_Of_Cycles()
        {
            var pattern = "ConsoleApp.(**)";
            var sliceRule = Slices().Matching(pattern).Should().BeFreeOfCycles();

            sliceRule.Check(Architecture);
        }

        [Fact]
        public void Architecture_AdheresToDiagram()
        {
            var myDiagram = @".\Diagrams\layers_diagram.puml";
            var someRule = Types().Should().AdhereToPlantUmlDiagram(myDiagram);
            someRule.Check(Architecture);
        }
    }
}