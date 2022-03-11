namespace TheBillboard.Abstract;

public interface IGateway
{
    IEnumerable<string> GetStudents();
}