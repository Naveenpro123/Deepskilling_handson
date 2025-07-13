using Swashbuckle.Swagger;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Configure the HTTP request pipeline.
//Configuring Swagger Gen
builder.Services.AddSwaggerGen();
var app = builder.Build();
//using Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FirstWebApi v1"));
}


app.UseAuthorization();

app.MapControllers();

app.Run();
