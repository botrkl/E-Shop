namespace E_Shop.DAL.Entities
{
    public class ProductImage : BaseEntity
    {
        public string Image { get; set; }
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
