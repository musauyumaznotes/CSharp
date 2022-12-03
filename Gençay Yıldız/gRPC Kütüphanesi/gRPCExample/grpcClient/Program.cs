using Grpc.Net.Client;
using grpcServer;
using grpcMessageClient;
using grpcServerStreamClient;

var channel = GrpcChannel.ForAddress("http://localhost:5244");

var greetClient = new Greeter.GreeterClient(channel);
var messageClient = new Message.MessageClient(channel);
var serverStreamClient = new ServerStream.ServerStreamClient(channel);
var clientStreamClient = new grpcClientStreamServer.ClientStream.ClientStreamClient(channel);
var biDirectionalStreamClient =
    new biDirectionStreamServer.BiDirectionStreamer.BiDirectionStreamerClient(channel);

// HelloReply unaryResponse1 = await greetClient.SayHelloAsync(
//     new HelloRequest() { Name = "Musa'dan selamlar" }
// );
// MessageResponse unaryResponse = messageClient.SendMessage(
//     new MessageRequest() { Name = "Musa", Message = "Unary ---> Merhaba" }
// );
// var serverStreamResponse = serverStreamClient.SendMessage(
//     new ServerStreamRequest() { Name = "Musa", Message = "Server Stream ---> Merhaba" }
// );
// var clientStreamRequest = clientStreamClient.SendMessage();
var biDirectionalStreamRequest = biDirectionalStreamClient.SendMessage();

CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

// while (await serverStreamResponse.ResponseStream.MoveNext(cancellationTokenSource.Token))
// {
//     System.Console.WriteLine(serverStreamResponse.ResponseStream.Current.Message);
// }

// System.Console.WriteLine($"Unary ---> greet : {unaryResponse1.Message}");
// System.Console.WriteLine($"Unary ---> Message : {unaryResponse.Message}");

// for (int i = 0; i < 10; i++)
// {
//     await Task.Delay(1000);
//     await clientStreamRequest.RequestStream.WriteAsync(
//         new() { Name = "Musa", Message = "ClientStream ---> Mesaj " + i }
//     );
// }

// //Stream datanın sonlandığını ifade eder.Sen bunu çağırmazsan eğer Server kanadı her daim bir tane stream nesne bekleyecek.Haliyle bunuda bildirmen gerekecek.
// await clientStreamRequest.RequestStream.CompleteAsync();

// System.Console.WriteLine((await clientStreamRequest.ResponseAsync).Message);

Task biDirectionalRequest = Task.Run(async () =>
{
    for (int i = 0; i < 10; i++)
    {
        await Task.Delay(1000);
        await biDirectionalStreamRequest.RequestStream.WriteAsync(
            new biDirectionStreamServer.BiDirectionStreamRequest()
            {
                Name = "Musa",
                Message = "BiDirectionalStream ---> Mesaj " + i
            }
        );
    }
});

Task biDirectionalResponse = Task.Run(async ()=> {
    while (await biDirectionalStreamRequest.ResponseStream.MoveNext(cancellationTokenSource.Token))
{
    System.Console.WriteLine(biDirectionalStreamRequest.ResponseStream.Current.Message);
}
});

await biDirectionalRequest;
await biDirectionalStreamRequest.RequestStream.CompleteAsync();
await biDirectionalResponse;