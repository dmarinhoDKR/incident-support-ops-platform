namespace IncidentOps.Api.Models;

public class CreateIncidentRequest
{
    public string Title { get; set; } = string.Empty;
    public string Customer { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Priority { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string Owner { get; set; } = string.Empty;
    public List<string> Tags { get; set; } = new();
}
