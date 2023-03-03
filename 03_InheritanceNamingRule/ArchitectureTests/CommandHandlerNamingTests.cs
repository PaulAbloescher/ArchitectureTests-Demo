using ArchitectureTests.Application;
using ArchUnitNET.Domain;
using ArchUnitNET.Loader;
using ArchUnitNET.xUnit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace ArchitectureTests
{
    public class CommandHandlerNamingTests
    {
        private static readonly Architecture Architecture =
            new ArchLoader().LoadAssemblies(typeof(ICommandHandler).Assembly).Build();

        [Fact]
        public void ClassNames_Of_CommandHandlers_Must_End_With_CommandHandler()
        {
            Classes().That().AreAssignableTo(typeof(ICommandHandler))
                .Should().HaveNameEndingWith("CommandHandler").Check(Architecture);
        }
    }
}