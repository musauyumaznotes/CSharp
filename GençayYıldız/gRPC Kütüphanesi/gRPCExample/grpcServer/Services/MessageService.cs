using Grpc.Core;
using grpcMessageServer;

namespace grpcServer
{
    public class MessageService : Message.MessageBase
    {
        public override async Task<MessageResponse> SendMessage(MessageRequest request,ServerCallContext context)
        {
            Console.WriteLine($" Unary --->  Name : {request.Name} | Message : {request.Message} ");
            return new (){Message = "Unary ---> Mesaj başarıyla alınmıştır...."};
            
        }
    }
}
