using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Assign17.Data;
//using Assign17.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Assign17DBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Assign17DBContext")));
//builder.Services.AddDbContext<MovieContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("MovieConStr")));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
