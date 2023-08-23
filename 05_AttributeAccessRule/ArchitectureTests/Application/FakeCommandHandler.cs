namespace ArchitectureTests.Application;

[RequiredCapability("Writer")]
public class FakeCommandHandler : ICommandHandler
{
    public Task HandleAsync()
    {
        throw new NotImplementedException();
    }
}