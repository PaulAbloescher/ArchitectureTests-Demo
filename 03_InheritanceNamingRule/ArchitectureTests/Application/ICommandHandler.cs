namespace ArchitectureTests.Application;

public interface ICommandHandler
{
    Task HandleAsync();
}