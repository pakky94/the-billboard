using TheBillboard.Abstract;

namespace TheBillboard.Gatweways;

public class Gateway : IGateway
{
    public IEnumerable<string> GetStudents()
    {
        return new[] {"Sebastian", "Doriano", "Elia", "Igor", "Marco", "Michele", "Luca", "Giacomo"};
    }
}