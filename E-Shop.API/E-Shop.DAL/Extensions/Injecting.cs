using E_Shop.DAL.Context;
using E_Shop.DAL.Repositories.Classes;
using E_Shop.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace E_Shop.DAL.Extensions
{
    public static class Injecting
    {
        public static void InjectDAL(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EShopDbContext>(options =>
            {
                options.UseSqlServer(configuration["ConnectionString"]);
            });

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductImageRepository, ProductImageRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
        }
    }
}
