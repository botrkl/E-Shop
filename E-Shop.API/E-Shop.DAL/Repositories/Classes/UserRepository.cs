using E_Shop.DAL.Context;
using E_Shop.DAL.Entities;
using E_Shop.DAL.Repositories.Interfaces;

namespace E_Shop.DAL.Repositories.Classes
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private EShopDbContext _dbContext;
        public UserRepository(EShopDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
