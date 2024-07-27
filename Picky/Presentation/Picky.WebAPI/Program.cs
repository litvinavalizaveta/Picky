using Microsoft.EntityFrameworkCore;
using Picky.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<PickyDbContext>(option =>
    option.UseNpgsql(builder.Configuration.GetConnectionString(CONNECTION_STRING)));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

