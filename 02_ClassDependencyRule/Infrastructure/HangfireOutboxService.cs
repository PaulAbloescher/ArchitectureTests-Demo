using Hangfire;

namespace Infrastructure
{
    public class HangfireOutboxService
    {
        private readonly IBackgroundJobClient _backgroundJobClient;

        public HangfireOutboxService(IBackgroundJobClient backgroundJobClient)
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
