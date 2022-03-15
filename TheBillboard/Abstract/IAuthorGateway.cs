using TheBillboard.Models;

namespace TheBillboard.Abstract
{
    public interface IAuthorGateway
    {
        public IEnumerable<Author> GetAll();

        Author? GetById(int id);

        Author Create(Author author);
        //void Update(Message message);
        void Delete(int id);
    }
}
