namespace ArchitectureTests.Application;

public class RequiredCapabilityAttribute : Attribute
{
    public string Capability { get; }

    public RequiredCapabilityAttribute(string capability)
    {
        Capability = capability;
    }
}