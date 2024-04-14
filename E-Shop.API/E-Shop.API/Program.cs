using E_Shop.DAL.Context;
using E_Shop.DAL.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.InjectDAL(builder.Configuration);

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    try
    {
        var context = serviceProvider.GetRequiredService<EShopDbContext>();
        Initializer.Initialize(context);
    }
    catch (Exception)
    {
        throw;
    }
}

app.Run();
