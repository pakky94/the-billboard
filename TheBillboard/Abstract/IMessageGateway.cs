using TheBillboard.Models;

namespace TheBillboard.Abstract;

public interface IMessageGateway
{
    IEnumerable<Message> GetMessages();
}