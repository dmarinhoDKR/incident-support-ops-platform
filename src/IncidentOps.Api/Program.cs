using IncidentOps.Api.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

var incidents = new List<Incident>
{
    new Incident
    {
        Id = Guid.NewGuid(),
        Title = "Checkout timeout during payment",
        Customer = "Northwind Commerce",
        Description = "Customer reported timeout when trying to confirm payment.",
        Priority = "High",
        Status = "Investigating",
        Owner = "Marcelo",
        CreatedAt = DateTime.UtcNow.AddHours(-5),
        SlaDueAt = DateTime.UtcNow.AddHours(3),
        Tags = new List<string> { "payment", "timeout", "checkout" }
    },
    new Incident
    {
        Id = Guid.NewGuid(),
        Title = "Authentication failure after password reset",
        Customer = "Blue Health",
        Description = "Users receive unauthorized response after password reset.",
        Priority = "Critical",
        Status = "Open",
        Owner = "Support Team",
        CreatedAt = DateTime.UtcNow.AddHours(-2),
        SlaDueAt = DateTime.UtcNow.AddHours(2),
        Tags = new List<string> { "auth", "jwt", "login" }
    }
};

app.MapGet("/", () =>
{
    return Results.Ok(new
    {
        message = "IncidentOps API is running"
    });
});

app.MapGet("/health", () =>
{
    return Results.Ok(new
    {
        service = "IncidentOps.Api",
        status = "healthy",
        checkedAt = DateTime.UtcNow
    });
});

app.MapGet("/api/incidents", () =>
{
    return Results.Ok(incidents);
});

app.MapGet("/api/incidents/{id:guid}", (Guid id) =>
{
    var incident = incidents.FirstOrDefault(i => i.Id == id);

    if (incident is null)
    {
        return Results.NotFound(new
        {
            message = "Incident not found"
        });
    }

    return Results.Ok(incident);
});

app.MapPost("/api/incidents", (CreateIncidentRequest request) =>
{
    if (string.IsNullOrWhiteSpace(request.Title) ||
        string.IsNullOrWhiteSpace(request.Customer) ||
        string.IsNullOrWhiteSpace(request.Description))
    {
        return Results.BadRequest(new
        {
            message = "Title, customer, and description are required."
        });
    }

    var incident = new Incident
    {
        Id = Guid.NewGuid(),
        Title = request.Title,
        Customer = request.Customer,
        Description = request.Description,
        Priority = string.IsNullOrWhiteSpace(request.Priority) ? "Medium" : request.Priority,
        Status = string.IsNullOrWhiteSpace(request.Status) ? "Open" : request.Status,
        Owner = string.IsNullOrWhiteSpace(request.Owner) ? "Unassigned" : request.Owner,
        CreatedAt = DateTime.UtcNow,
        SlaDueAt = DateTime.UtcNow.AddHours(4),
        Tags = request.Tags ?? new List<string>()
    };

    incidents.Add(incident);

    return Results.Created($"/api/incidents/{incident.Id}", incident);
});

app.MapPut("/api/incidents/{id:guid}/status", (Guid id, UpdateIncidentStatusRequest request) =>
{
    var incident = incidents.FirstOrDefault(i => i.Id == id);

    if (incident is null)
    {
        return Results.NotFound(new
        {
            message = "Incident not found"
        });
    }

    if (string.IsNullOrWhiteSpace(request.Status))
    {
        return Results.BadRequest(new
        {
            message = "Status is required."
        });
    }

    incident.Status = request.Status;

    return Results.Ok(incident);
});

app.Run();
