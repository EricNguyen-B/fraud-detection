namespace FraudDetection
{
    class producerService : IProducerService
    {
        public Task Send(string message)
        {
            throw new NotImplementedException();
        }

        public Task SetTopic(string topicName)
        {
            throw new NotImplementedException();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    internal interface IProducerService : IHostedService
    {
        Task Send(string message);
        Task SetTopic(string topicName);
    }
}
