namespace BFFWithMultipleLanguages
{
    public class RpcClientInitializer : IHostedService
    {
        private readonly RpcClient _rpcClient;

        public RpcClientInitializer(RpcClient rpcClient)
        {
            _rpcClient = rpcClient;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            // This calls your StartAsync method when the application starts
            await _rpcClient.StartAsync();
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            // This ensures proper cleanup when the application shuts down
            await _rpcClient.DisposeAsync();
        }
    }
}
