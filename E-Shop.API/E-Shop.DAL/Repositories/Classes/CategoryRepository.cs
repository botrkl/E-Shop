using E_Shop.DAL.Context;
using E_Shop.DAL.Entities;
using E_Shop.DAL.Repositories.Interfaces;

namespace E_Shop.DAL.Repositories.Classes
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        private EShopDbContext _dbContext;
        public CategoryRepository(EShopDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
