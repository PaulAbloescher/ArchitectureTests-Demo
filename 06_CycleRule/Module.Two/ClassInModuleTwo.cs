using ArchitectureTests.Module.Three;

namespace ArchitectureTests.Module.Two
{
    public class ClassInModuleTwo
    {
        public ClassInModuleThree ClassInModuleThree { get; set; } = new();
    }
}
