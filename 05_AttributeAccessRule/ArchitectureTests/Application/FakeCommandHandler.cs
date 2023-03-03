namespace ArchitectureTests.Application;

[RequiredCapability("GvsWriter")]
public class FakeCommandHandler : ICommandHandler
{
    public Task HandleAsync()
    {
        throw new NotImplementedException();
    }
}