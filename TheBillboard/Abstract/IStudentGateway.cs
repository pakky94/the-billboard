namespace TheBillboard.Abstract;

public interface IStudentGateway
{
    IEnumerable<string> GetStudents();
}