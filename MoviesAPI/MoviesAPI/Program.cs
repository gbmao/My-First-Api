using Microsoft.EntityFrameworkCore;
using MoviesAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// use connection string from appsettings.json
builder.Services.AddDbContext<MovieContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MovieDbCS")));

var app = builder.Build();

//Asynchronous method to seed data into our database

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<MovieContext>();
        await context.Database.MigrateAsync();
    }
    catch (Exception ex)
    {
        // Log the error (uncomment ex variable name and write a log.
        Console.WriteLine($"An error occurred while migrating the database: {ex.Message}");
    }

}

app.MapGet("/", () => "Hello World!");

app.Run();
