namespace Asou.Abstractions;

public record EventRepresentation(
    string Id,
    string Source,
    string Type,
    string Subject,
    DateTime Time,
    string? Data
)
{
}
