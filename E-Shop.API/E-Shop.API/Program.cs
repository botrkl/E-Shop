using E_Shop.DAL.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EShopDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionString"]);
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
