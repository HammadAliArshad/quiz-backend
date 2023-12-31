using quiz_backend;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<QuizContext>(opt => opt.UseInMemoryDatabase());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors(options => {
    options
    .AllowAnyHeader()
    .SetIsOriginAllowedToAllowWildcardSubdomains()
    .AllowAnyOrigin()
    .AllowAnyMethod();
});


app.UseAuthorization();

app.MapControllers();

app.Run();
