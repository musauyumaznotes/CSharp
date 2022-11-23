using Grpc.Core;
using System;
namespace grpcServerStream
{
    public class ServerStreamService : ServerStream.ServerStreamBase
    {
        public override async Task SendMessage(ServerStreamRequest request, IServerStreamWriter<ServerStreamResponse> responseStream, ServerCallContext context)
        {
            Console.WriteLine($"Server Stream ---> Name : {request.Name} | Message : {request.Message} ");
            
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(1000);
                await responseStream.WriteAsync(new(){Message = "ServerStream ---> Merhaba " + i});
            }
        }
    }
}