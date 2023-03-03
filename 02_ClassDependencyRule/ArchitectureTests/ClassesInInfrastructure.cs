using ArchitectureTests.Infrastructure;
using ArchUnitNET.Domain;
using ArchUnitNET.Loader;
using ArchUnitNET.xUnit;
using Hangfire;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace ArchitectureTests
{
    public class ClassesInInfrastructure
    {
        private static readonly Architecture Architecture =
            new ArchLoader().LoadAssemblies(
                typeof(CorrectOutboxService).Assembly,
                typeof(BackgroundJobClient).Assembly).Build();

        [Fact]
        public void ShouldNotDependOn_Static_BackgroundJob()
        {
            var rule = Classes().That().ResideInAssembly(typeof(CorrectOutboxService).Assembly).Should()
                .NotDependOnAny(Classes().That().AreAssignableTo(typeof(BackgroundJob)));

            Architecture.CheckRule(rule);
        }
    }
}