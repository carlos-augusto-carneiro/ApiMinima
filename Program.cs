using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c=>
{
    c.SwaggerDoc("v1", new OpenApiInfo 
    {   Title = "PizzariaStore Api", 
        Description = "Criando pizzaria", 
        Version = "v1"});
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c=>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Pizzaria Api v1");
});

app.MapGet("/", () => "Vá para o Swagger");

app.Run();
