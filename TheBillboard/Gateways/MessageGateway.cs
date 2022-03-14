using TheBillboard.Abstract;
using TheBillboard.Models;

namespace TheBillboard.Gateways;

public class MessageGateway : IMessageGateway  
{
    public IEnumerable<Message> GetMessages()
    {
        return new Message[]
        {
            new("Hello World!", "What A Wonderful World!", "Alberto", DateTime.Now, DateTime.Now, 1)
        };
    }
}