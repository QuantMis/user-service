var builder = WebApplication.CreateBuilder(args);
{
    // configure services (DI) for this project
}
var app = builder.Build();
{
    // configure request pipeline (routing)
}

app.Run();

