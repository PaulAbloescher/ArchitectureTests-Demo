namespace ArchitectureTests.Application;

public class FakeCommandHandler : ICommandHandler
{
    public Task HandleAsync()
    {
        throw new NotImplementedException();
    }
}