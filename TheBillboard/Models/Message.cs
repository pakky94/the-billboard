namespace TheBillboard.Models;

public record Message(string Title, string Body, string Author, DateTime? CreatedAt = default,
    DateTime? UpdatedAt = default, int? Id = default)
{
    public string FormattedCreatedAt => CreatedAt.HasValue 
        ? CreatedAt.Value.ToString("yyyy-MM-dd HH:mm") 
        : string.Empty;
    
    public string FormattedUpdatedAt => UpdatedAt.HasValue 
        ? UpdatedAt.Value.ToString("yyyy-MM-dd HH:mm")
        : string.Empty;
}