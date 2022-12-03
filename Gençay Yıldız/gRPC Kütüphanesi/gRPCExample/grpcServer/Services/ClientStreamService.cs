
using Grpc.Core;
using grpcClientStreamServer;

namespace grpcServerStream
{
    public class ClientStreamService : grpcClientStreamServer.ClientStream.ClientStreamBase
    {
        public override async Task<ClientStreamResponse> SendMessage(IAsyncStreamReader<ClientStreamRequest> requestStream, ServerCallContext context)
        {
            
            while(await requestStream.MoveNext(context.CancellationToken))
            {
                System.Console.WriteLine($"ClientStream ---> Message : {requestStream.Current.Message}  | Name : {requestStream.Current.Name}");
            }

            return new ClientStreamResponse(){
                Message = "ClientStream ---> Veri Alınmıştır...."
            };
        }
    }
}