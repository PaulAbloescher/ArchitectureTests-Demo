using ArchitectureTests.Module.Two;

namespace ArchitectureTests.Module.One
{
    public class ClassInModuleOne
    {
        public ClassInModuleTwo ClassInModuleTwo { get; set; } = new();
    }
}
