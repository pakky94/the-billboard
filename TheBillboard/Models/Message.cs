using System.ComponentModel.DataAnnotations;

namespace TheBillboard.Models;
public record Message(
    string Title, 
    [Required(ErrorMessage = "Il campo body e' obbligatorio"), MinLength(30, ErrorMessage = "Il campo body deve essere lungo almento 30 caratteri")] string Body, 
    string Author, 
    DateTime? CreatedAt = default,
    DateTime? UpdatedAt = default, 
    int? Id = default)
{
    public string FormattedCreatedAt => CreatedAt.HasValue 
        ? CreatedAt.Value.ToString("yyyy-MM-dd HH:mm") 
        : string.Empty;
    
    public string FormattedUpdatedAt => UpdatedAt.HasValue 
        ? UpdatedAt.Value.ToString("yyyy-MM-dd HH:mm")
        : string.Empty;
}