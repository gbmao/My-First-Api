using Microsoft.EntityFrameworkCore;
using MoviesAPI.Data;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// use connection string from appsettings.json
builder.Services.AddDbContext<MovieContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MovieDbCS")));

app.MapGet("/", () => "Hello World!");

app.Run();
