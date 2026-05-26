var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hello from .NET Container");

app.Run("http://0.0.0.0:8080");
