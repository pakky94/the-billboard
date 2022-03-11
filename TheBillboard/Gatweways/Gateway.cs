using Microsoft.Extensions.Options;
using TheBillboard.Abstract;
using TheBillboard.Options;

namespace TheBillboard.Gatweways;

public class Gateway : IGateway
{
    private readonly AppOptions _options;

    public Gateway(IOptions<AppOptions> options)
    {
        _options = options.Value;
    }
    
    public IEnumerable<string> GetStudents()
    {
        return _options.Students;
    }
}