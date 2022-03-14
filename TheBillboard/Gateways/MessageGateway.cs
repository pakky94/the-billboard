using TheBillboard.Abstract;
using TheBillboard.Models;

namespace TheBillboard.Gateways;

public class MessageGateway : IMessageGateway  
{
    private IEnumerable<Message> _messages = new List<Message>()
    {
        new ("Hello  World!", "What A Wonderful World!", "Alberto", DateTime.Now.AddHours(-2), DateTime.Now.AddHours(-1), 1),
        new ("Hello  World!", "What A Wonderful World!", "Alberto", DateTime.Now, DateTime.Now, 2),
    };
    
    public IEnumerable<Message> GetMessages() => _messages;

    public Message? GetMessage(int id) => _messages.SingleOrDefault(message => message.Id == id);
    public void DeleteMessage(int id)
    {
        _messages = _messages.Where(message => message.Id != id);
    }
}