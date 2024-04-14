using E_Shop.DAL.Context;
using E_Shop.DAL.Entities;
using E_Shop.DAL.Repositories.Interfaces;

namespace E_Shop.DAL.Repositories.Classes
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private EShopDbContext _dbContext;
        public ProductRepository(EShopDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
