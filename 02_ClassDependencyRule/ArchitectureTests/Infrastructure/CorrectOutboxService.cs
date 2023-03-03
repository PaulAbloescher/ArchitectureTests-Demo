using Hangfire;

namespace ArchitectureTests.Infrastructure
{
    public class CorrectOutboxService
    {
        private readonly IBackgroundJobClient _backgroundJobClient;

        public CorrectOutboxService(IBackgroundJobClient backgroundJobClient)
        {
            _backgroundJobClient = backgroundJobClient;
        }

        public Task SendUnsentIntegrationEvents()
        {
            _backgroundJobClient.Enqueue(() => Task.Delay(500));
            return Task.CompletedTask;
        }
    }
}
