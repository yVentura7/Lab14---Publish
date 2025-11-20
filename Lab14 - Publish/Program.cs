var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();

// ✅ AGREGAR ESTA RUTA MÍNIMA
app.MapGet("/", () => "¡Laboratorio 14 funcionando en Render!");
app.MapGet("/api", () => new { message = "API funcionando", status = "OK" });
app.MapGet("/health", () => "Healthy");

// Configure the HTTP request pipeline.
app.MapControllers();

app.Run();