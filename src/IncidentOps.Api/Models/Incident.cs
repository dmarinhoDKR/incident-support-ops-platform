namespace IncidentOps.Api.Models;

public class Incident
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Customer { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Priority { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string Owner { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime SlaDueAt { get; set; }
    public List<string> Tags { get; set; } = new();
}