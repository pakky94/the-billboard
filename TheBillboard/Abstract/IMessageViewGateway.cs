using TheBillboard.Models;

namespace TheBillboard.Abstract
{
    public interface IMessageViewGateway
    {
        public IEnumerable<MessageViewModel> GetAll();

        public MessageViewModel? GetById(int id);
    }
}
