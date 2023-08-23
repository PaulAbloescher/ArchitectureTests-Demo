namespace ConsoleApp.Application.Common
{
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        public Task HandleAsync(TCommand command);
    }
}
