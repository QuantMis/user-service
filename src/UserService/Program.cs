using Microsoft.EntityFrameworkCore;
using UserService.Persistence;

// Services and DI
var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

    builder.Services.AddControllers();
}

// Request Pipeline and Middleware
var app = builder.Build();
{
    app.UseRouting();
    app.MapControllers();
    app.Run();
}


