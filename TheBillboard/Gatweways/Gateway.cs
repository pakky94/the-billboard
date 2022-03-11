using Microsoft.Extensions.Options;
using TheBillboard.Abstract;
using TheBillboard.Options;

namespace TheBillboard.Gatweways;

public class Gateway : IGateway
{
    private readonly ILogger<Gateway> _logger;
    private readonly AppOptions _options;

    public Gateway(IOptions<AppOptions> options, ILogger<Gateway> logger)
    {
        _logger = logger;
        _options = options.Value;
    }
    
    public IEnumerable<string> GetStudents()
    {
        _logger.LogInformation("GetStudents Called!");
        return _options.Students;
    }
}