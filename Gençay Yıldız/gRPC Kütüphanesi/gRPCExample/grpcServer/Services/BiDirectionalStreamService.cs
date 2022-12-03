using biDirectionStreamServer;
using Grpc.Core;

namespace grpcServerStream
{
    public class BiDirectionalStreamService : BiDirectionStreamer.BiDirectionStreamerBase
    {
        public override async Task SendMessage(
            IAsyncStreamReader<BiDirectionStreamRequest> requestStream,
            IServerStreamWriter<BiDirectionStreamResponse> responseStream,
            ServerCallContext context
        )
        {
            Task request = Task.Run(async () =>
            {
                while (await requestStream.MoveNext(context.CancellationToken))
                {
                    System.Console.WriteLine(
                        $"BiDirectionalStream ---> Message : {requestStream.Current.Message} | Name : {requestStream.Current.Name}"
                    );
                }
            });

            Task response  = Task.Run(async () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    await Task.Delay(1000);
                    await responseStream.WriteAsync(
                        new BiDirectionStreamResponse()
                        {
                            Message = "BiDirectionalStream ---> Mesaj " + i
                        }
                    );
                }
            });

            await request;
            await response;
        }
    }
}
