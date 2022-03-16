using TheBillboard.Abstract;
using TheBillboard.Models;

namespace TheBillboard.Gateways
{
    public class MessageViewGateway : IMessageViewGateway
    {
        private readonly IMessageGateway _messageGateway;
        private readonly IAuthorGateway _authorGateway;

        public MessageViewGateway(IAuthorGateway authorGateway, IMessageGateway messageGateway)
        {
            _authorGateway = authorGateway;
            _messageGateway = messageGateway;
        }
        
        private MessageWithAuthor InjectAuthor(Message message)
        {
            return new MessageWithAuthor(message, _authorGateway.GetById(message.AuthorId) ?? new Author("Unknown Author"));
        }

        public IEnumerable<MessageWithAuthor> GetAll() => _messageGateway.GetAll().Select(InjectAuthor);

        public MessageWithAuthor? GetById(int id) {
            var message = _messageGateway.GetById(id);
            return message is null ? null : InjectAuthor(message);
        }
    }
}
