using Hangfire;

namespace ArchitectureTests.Infrastructure
{
    public class IncorrectOutboxService
    {
        public Task SendUnsentIntegrationEvents()
        {
            BackgroundJob.Enqueue(() => Task.Delay(500));
            return Task.CompletedTask;
        }
    }
}
