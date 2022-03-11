using System.ComponentModel.DataAnnotations;

namespace TheBillboard.Options;

public class AppOptions
{
    [Required, MinLength(5)]
    public IEnumerable<string> Students { get; set; } = null!;
}