namespace E_Shop.DAL.Context
{
    public class Initializer
    {
        public static void Initialize(EShopDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
