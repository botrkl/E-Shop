namespace E_Shop.DAL.Entities
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PreviewImage { get; set; }
        public int Amount { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<ProductImage>? Images { get; set; }
    }
}
