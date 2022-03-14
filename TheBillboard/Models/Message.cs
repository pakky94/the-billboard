namespace TheBillboard.Models;

public record Message(string Title, string Body, string Author, DateTime? Created = default, DateTime? Updated = default, int? Id = default);