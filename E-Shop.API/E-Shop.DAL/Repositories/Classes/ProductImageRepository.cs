using E_Shop.DAL.Context;
using E_Shop.DAL.Entities;
using E_Shop.DAL.Repositories.Interfaces;

namespace E_Shop.DAL.Repositories.Classes
{
    public class ProductImageRepository : BaseRepository<ProductImage>, IProductImageRepository
    {
        private EShopDbContext _dbContext;
        public ProductImageRepository(EShopDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
