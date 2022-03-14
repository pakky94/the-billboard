using TheBillboard.Models;

namespace TheBillboard.Abstract;

public interface IMessageGateway
{
    IEnumerable<Message> GetMessages();
    Message? GetMessage(int id);
}