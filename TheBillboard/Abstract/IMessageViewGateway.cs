using TheBillboard.Models;

namespace TheBillboard.Abstract
{
    public interface IMessageViewGateway
    {
        public IEnumerable<MessageWithAuthor> GetAll();

        public MessageWithAuthor? GetById(int id);
    }
}
