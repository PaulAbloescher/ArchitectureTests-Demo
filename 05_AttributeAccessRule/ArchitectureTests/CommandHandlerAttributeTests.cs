using ArchitectureTests.Application;
using ArchUnitNET.Domain;
using ArchUnitNET.Loader;
using ArchUnitNET.xUnit;

using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace ArchitectureTests
{
    public class CommandHandlerAttributeTests
    {
        private static readonly Architecture Architecture =
            new ArchLoader().LoadAssemblies(typeof(RequiredCapabilityAttribute).Assembly).Build();

        [Fact]
        public void CommandHandlers_Must_Use_The_RequiredCapability_Attribute()
        {
            Classes().That().AreAssignableTo(typeof(ICommandHandler))
                .Should().HaveAttributeWithArguments(typeof(RequiredCapabilityAttribute), "Writer").Check(Architecture);
        }
    }
}