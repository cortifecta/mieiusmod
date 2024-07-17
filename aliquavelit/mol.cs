public static async Task Main(string[] args)
{
    var options = new NatsOptions { Url = "nats://localhost:4222" };
    
    await using var connection = new NatsConnection(options);
    
    // Use the connection...
}
