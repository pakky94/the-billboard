using Microsoft.AspNetCore.Mvc;

namespace TheBillboard.Models
{
    public record Author (string nome, string cognome, int? id = default)
    {

    }
}
