using TheBillboard.Abstract;
using TheBillboard.Models;

namespace TheBillboard.Gateways;

public class MessageGateway : IMessageGateway  
{
    private static readonly IEnumerable<Message> Messages = new List<Message>()
    {
        new ("Hello  World!", "What A Wonderful World!", "Alberto", DateTime.Now, DateTime.Now, 1),
    };
    
    public IEnumerable<Message> GetMessages() => Messages;

    public Message? GetMessage(int id) => Messages.SingleOrDefault(message => message.Id == id);
}