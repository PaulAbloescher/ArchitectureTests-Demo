using ArchitectureTests.Module.One;

namespace ArchitectureTests.Module.Three
{
    public class ClassInModuleThree
    {
        public ClassInModuleOne ClassInModuleOne { get; set; } = new();
    }
}
