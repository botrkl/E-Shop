namespace E_Shop.DAL.Entities
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public Guid? ParentCategoryId { get; set; }
        public virtual Category? ParentCategory { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
        public virtual ICollection<Category>? SubCategories { get; set; }
    }
}
